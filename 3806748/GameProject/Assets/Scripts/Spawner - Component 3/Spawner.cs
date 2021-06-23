using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Spawner : MonoBehaviour
{
    public bool IsActive = true;

    public GameObject ItemToSpawn;
    public Transform SpawnerWall;

    public WinLoseManager ScoreManager;

    public float DifficultyScaler = 1;

    public float MaxItemLifetime = 8; public float MinItemLifetime = 4; 
    public float MaxItemSize = 2; public float MinItemSize = 1; 
    public float MaxSpawnDelay = 4; public float MinSpawnDelay = 1;
    public float TimeGainedOrLostOnHit = 1;

    public int MinSpawnCount = 1; public int MaxSpawnCount = 4;

    public float DelayedDeathTime = 2;
    public float TickRate = 0.5f;

    private List<Transform> CurrentItems = new List<Transform>();
    private List<float> CurrentItems_ShrinkPerTick = new List<float>();
    private List<float> CurrentItems_Lifetime = new List<float>();
    private List<float> CurrentItems_TimeTakenToDie = new List<float>();

    private List<Transform> DelayedDeathList = new List<Transform>();
    private List<float> DelayedDeathList_Time = new List<float>();

    private void Start()
    {
        PlayerPrefs.SetFloat("TickRate", TickRate);
        Invoke("SpawnNewItem", Random.Range(MinSpawnDelay, MaxSpawnDelay));

        float Tick = PlayerPrefs.GetFloat("TickRate"); InvokeRepeating("ShrinkAllObjects", Tick, Tick);
    }

    private void OnEnable()
    {
        MaxItemLifetime *= DifficultyScaler;
        MinItemLifetime *= DifficultyScaler;
        MaxItemSize *= DifficultyScaler;
        MinItemSize *= DifficultyScaler;

        MaxSpawnDelay *= DifficultyScaler;
        MinSpawnDelay *= DifficultyScaler;

        ScoreManager.WinScore /= DifficultyScaler;
        ScoreManager.StartingTime *= DifficultyScaler;
    }

    public void ObjectIsShot(GameObject Obj, float ScoreMultiplier)
    {
        for (int i = 0; i < CurrentItems.Count; i++)
        {
            if (CurrentItems[i].gameObject == Obj)
            {
                ScoreManager.AddScore(CurrentItems[i].transform.localScale.x * ScoreMultiplier);
                ScoreManager.AddTime(TimeGainedOrLostOnHit);

                PreDestroyAnItem(i);
            }
        }
    }

    public void ObjectIsMiss(float MissPenalty = 0)
    {
        ScoreManager.AddTime(-TimeGainedOrLostOnHit);
        ScoreManager.AddScore(MissPenalty, false);
    }

    private void SpawnNewItem()
    {
        for (int i = 0; i <= Random.Range(MinSpawnCount, MaxSpawnCount); i++)
        {
            float SpawnXPos = Random.Range(SpawnerWall.position.x - (SpawnerWall.localScale.x / 2), SpawnerWall.position.x + (SpawnerWall.localScale.x / 2));
            float SpawnYPos = Random.Range(SpawnerWall.position.y - (SpawnerWall.localScale.y / 2), SpawnerWall.position.y + (SpawnerWall.localScale.y / 2));
            float SpawnZPos = transform.position.z;
            Vector3 SpawnPos = new Vector3(SpawnXPos, SpawnYPos, SpawnZPos);

            float SpawnSize = Random.Range(MinItemSize, MaxItemSize);
            float SpawnLife = Random.Range(MinItemLifetime, MaxItemLifetime);
            float SpawnSizePerTick = MaxItemSize / (SpawnLife / PlayerPrefs.GetFloat("TickRate"));

            GameObject NewItem = Instantiate(ItemToSpawn, SpawnPos, new Quaternion(), transform);
            NewItem.transform.localScale = new Vector3(SpawnSize, SpawnSize, 0.001f);
            NewItem.transform.LookAt(Camera.main.transform);
            

            CurrentItems.Add(NewItem.transform);
            CurrentItems_Lifetime.Add(SpawnLife);
            CurrentItems_ShrinkPerTick.Add(SpawnSizePerTick);
            CurrentItems_TimeTakenToDie.Add(0);
        }

        if (IsActive)
        {
            Invoke("SpawnNewItem", Random.Range(MinSpawnDelay, MaxSpawnDelay));
        }
    }

    private void ShrinkAllObjects()
    {
        CheckItemLife();

        for (int i = 0; i < CurrentItems_Lifetime.Count; i++)
        {
            ShrinkAnObject(CurrentItems[i], CurrentItems_ShrinkPerTick[i]);
        }
    }

    private void ShrinkAnObject(Transform Object, float Ammount)
    {
        if (Object.localScale[0] > Ammount)
        {
            Object.localScale -= new Vector3(Ammount, Ammount, Ammount);
        }
        else
        {
            Object.localScale = new Vector3();
        }
    }

    private void CheckItemLife()
    {
        for(int i = 0; i < CurrentItems_Lifetime.Count; i++)
        {
            if(CurrentItems_Lifetime[i] <= 0)
            {
                PreDestroyAnItem(i);
            }
            else
            {
                float Tick = PlayerPrefs.GetFloat("TickRate");
                CurrentItems_Lifetime[i] -= Tick;
                CurrentItems_TimeTakenToDie[i] += Tick;
            }
        }

        for (int j = 0; j < DelayedDeathList.Count; j++)
        {
            if (DelayedDeathList_Time[j] <= 0)
            {
                FinalDestroyAnItem(j);
            }
            else
            {
                DelayedDeathList_Time[j] -= PlayerPrefs.GetFloat("TickRate");
            }
        }
    }

    private void PreDestroyAnItem(int position)
    {
        ScoreManager.AddObjectDecayTime(CurrentItems_TimeTakenToDie[position]);

        DelayedDeathList.Add(CurrentItems[position]);
        DelayedDeathList_Time.Add(DelayedDeathTime);

        CurrentItems.RemoveAt(position);
        CurrentItems_Lifetime.RemoveAt(position);
        CurrentItems_ShrinkPerTick.RemoveAt(position);
        CurrentItems_TimeTakenToDie.RemoveAt(position);
    }

    private void FinalDestroyAnItem(int position)
    {
        Destroy(DelayedDeathList[position].gameObject);
        DelayedDeathList.RemoveAt(position);
        DelayedDeathList_Time.RemoveAt(position);
    }

}
