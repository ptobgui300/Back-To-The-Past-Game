using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float lookRadius = 10f;
    public float pushRadius = 2f;
    Material myMaterial;
    NavMeshAgent agent;
    Color neutral;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        myMaterial = GetComponent<Renderer>().material;
        neutral = myMaterial.color;
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        
        if (distance <= pushRadius)
        {
            myMaterial.color = Color.red;

        } else
        {
            myMaterial.color = neutral;
        }
                
    }
}
