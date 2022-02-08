using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.InteractiveTutorials;

public class AnimateStart : MonoBehaviour
{
    public Zombie zombie;
    public float delayInSeconds;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<IPlayerAvatar>() != null)
        {
            StopAllCoroutines();
            StartCoroutine(Animate());
        }
    }

    private IEnumerator Animate()
    {
        yield return new WaitForSeconds(delayInSeconds);

        zombie.enabled = true;
    }
}
