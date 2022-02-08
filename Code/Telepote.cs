using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telepote : MonoBehaviour
{
    public Transform Target;

   void OnTriggerEnter(Collider _col)
    {
        if(_col.gameObject.name == "player")
        {
            _col.transform.position = Target.position;
        }
    }

}
