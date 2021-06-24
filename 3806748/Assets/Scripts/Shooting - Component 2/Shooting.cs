using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Texture2D CursorArt;
    public Texture2D CursorArtDisabled;

    public GameObject[] IgnoredObjects;
    public Spawner ObjectManager;
    public float ReloadTime = 1;
    public float MissPenalty = -15;
    public float ScoreMultiplier = 0.75f;

    private bool Active = true;
    private LineRenderer LR;

    private void Start()
    {
        LR = gameObject.GetComponent<LineRenderer>();
        LR.SetPosition(0, Camera.main.transform.position - new Vector3(0, 1, 0));
        Cursor.SetCursor(CursorArt, new Vector2(), CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if (Active)
        {
            if (Input.GetMouseButton(0))
            {
                Shoot();
            }
        }        
    }

    private void Shoot()
    {
        Cursor.SetCursor(CursorArtDisabled, new Vector2(), CursorMode.Auto);

        Active = false;
        Invoke("Reload", ReloadTime);

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            LR.SetPosition(1, hit.point);
            GameObject Obj = hit.collider.gameObject;
            bool HitIgnoredObject = false;

            for (int i = 0; i < IgnoredObjects.Length; i++)
            { 
                if(Obj == IgnoredObjects[i])
                {
                    HitIgnoredObject = true;
                    ObjectManager.ObjectIsMiss(MissPenalty);
                    break;
                }
            }

            if (!HitIgnoredObject)
            {
                ObjectManager.ObjectIsShot(Obj, ScoreMultiplier);
            }
        }
        
    }

    private void Reload()
    {
        Cursor.SetCursor(CursorArt, new Vector2(), CursorMode.Auto);
        Active = true;
    }
}
