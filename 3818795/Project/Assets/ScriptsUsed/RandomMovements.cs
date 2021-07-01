using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMovements : MonoBehaviour
{

    NavMeshAgent navMeshAgent;
    public GameObject[] RandomPoint;
    private int CurrentRandomPoint;
    public static int Score;
    
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        RandomPoint = GameObject.FindGameObjectsWithTag("WayPoints");
        
    }

    

    // Update is called once per frame
    void Update()
    {
        RandomPoint = GameObject.FindGameObjectsWithTag("WayPoints");
        if (navMeshAgent.hasPath == false && RandomPoint.Length > 0)
        {
            CurrentRandomPoint = Random.Range(0, RandomPoint.Length);
            navMeshAgent.SetDestination(RandomPoint[CurrentRandomPoint].transform.position);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "WayPoints")
        {
            Score+= 5;
            Destroy(other.gameObject);
            Debug.Log("MyTag");
        }
    }
}
