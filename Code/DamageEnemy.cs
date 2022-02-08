using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    [SerializeField] int damage;

    [SerializeField] int force;



    void OnCollisionEnter(Collision other)
    {
        
        if(other.transform.CompareTag("Player")) {
            Debug.Log(damage);
         
            other.transform.GetComponent<MainStatus>().DecreaseHp(damage);

        }
    }
}
