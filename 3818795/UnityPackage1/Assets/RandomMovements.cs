using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMovements : MonoBehaviour
{

    NavMeshAgent navMeshAgent;
    public GameObject[] RandomPoint;
    private int CurrentRandomPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        RandomPoint = GameObject.FindGameObjectsWithTag("WayPoints");
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if(navMeshAgent.hasPath == false)
        {
            CurrentRandomPoint = Random.Range(0, RandomPoint.Length + 1);
            navMeshAgent.SetDestination(RandomPoint[CurrentRandomPoint].transform.position);

        }
    }
}
