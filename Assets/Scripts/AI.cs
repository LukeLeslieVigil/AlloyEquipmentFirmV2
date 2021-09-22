using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    NavMeshAgent agent;  
    public Transform player;
    State currentState;

    private void Start()
    {               
        agent = this.GetComponent<NavMeshAgent>();
        currentState = new Idle(this.gameObject, agent, player);
    }

    private void Update()
    {
        currentState = currentState.Process();
    }
}
