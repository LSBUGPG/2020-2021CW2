using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;

    private NavMeshAgent controllerAI;

    private void Start()
    {
        controllerAI = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        controllerAI.SetDestination(player.position);
    }
}
