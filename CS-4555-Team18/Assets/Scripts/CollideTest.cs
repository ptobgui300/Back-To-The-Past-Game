using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTest : MonoBehaviour
{
  /*  void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            Debug.Log("Contacted with player");
        }
    }*/


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            HealthManager d = other.GetComponent<HealthManager>();
            d.Damage(1);

        }
    }



}
