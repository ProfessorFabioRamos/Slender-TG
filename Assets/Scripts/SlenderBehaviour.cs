using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class SlenderBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform playerTransform;
    public SkinnedMeshRenderer rend;
    public float scareDistance = 5;
    private float distance;
    public Image noiseEffectImage;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        noiseEffectImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(playerTransform.position);
        distance = Vector3.Distance(playerTransform.position, transform.position);
        //Debug.Log(distance);
        if(distance <=scareDistance){
            noiseEffectImage.enabled = true;
        }else{
            noiseEffectImage.enabled = false;
        }
        
        //noiseEffectImage.enabled = distance <=scareDistance?true:false;

        if(rend.isVisible)
            agent.speed = 0;
        else
            agent.speed = 2;
        //agent.speed = rend.isVisible?agent.speed = 0:agent.speed = 2;
    }
}
