using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.InteractiveTutorials;

public class Trip : MonoBehaviour
{
    [SerializeField] int damage;
    bool isInvicibleMode = false;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<IPlayerAvatar>() != null)
        {
            collider.transform.GetComponent<MainStatus>().DecreaseHp(damage);
        }
    }
}
