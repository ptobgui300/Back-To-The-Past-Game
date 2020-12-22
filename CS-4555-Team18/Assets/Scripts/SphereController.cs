using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SphereController : MonoBehaviour
{
    public Transform player;
    NavMeshAgent agent;
    public float lookDistance = 10f;
    public float stopDistance = 1f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if(distance <= lookDistance)
        {
            anim.SetBool("Roll_Anim",true);
            agent.SetDestination(player.transform.position);
        }
        else
        {
            anim.SetBool("Roll_Anim", false);
        }
    }
}
