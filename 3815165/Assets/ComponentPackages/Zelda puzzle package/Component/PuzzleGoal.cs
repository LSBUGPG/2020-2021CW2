using UnityEngine;
using UnityEngine.Events;

public class PuzzleGoal : MonoBehaviour
{

    [SerializeField] GameObject key;

    public UnityEvent onUnlock;

    public GameObject wall;

    // Start is called before the first frame update
    public void UnlockEventTriggered()
    {
        onUnlock.Invoke();    
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
        {
            UnlockEventTriggered();
        }
    }

    public void TestUnlock()
    {
        Debug.Log("GOAL!!!!");
        wall.SetActive(false);
    }
}
