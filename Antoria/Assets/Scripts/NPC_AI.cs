using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_AI : MonoBehaviour
{
    public float agentSpeed;
    public Transform waypoint;
    public NavMeshAgent agent;
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        { 
            Walk(); 
        }
    }
    void Walk()
    {

        agent.destination = waypoint.position;
    }

}
