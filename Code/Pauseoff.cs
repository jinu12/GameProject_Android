using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauseoff : MonoBehaviour
{
    private bool isPause = true;
    public void Pausenow()
    {
        if (!isPause)
        {
            Time.timeScale = 0f;
            isPause = false;
        }
        else
        {
            Time.timeScale = 1f;
            isPause = true;
        }

    }
}
