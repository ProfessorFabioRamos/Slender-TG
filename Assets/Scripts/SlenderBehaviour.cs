using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SlenderBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform playerTransform;
    public SkinnedMeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerTransform.position);

        if(rend.isVisible)
            agent.speed = 0;
        else
            agent.speed = 2;

        //agent.speed = rend.isVisible?agent.speed = 0:agent.speed = 2;
    }
}
