using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManger : MonoBehaviour
{
    public Text timeText;
    public float time;
    GameController gamecontroll;

  
    void Update()
    {
        time -= Time.deltaTime;
        string minutes = ((int)time / 60).ToString();
        string second = (time % 60).ToString("f2");


        timeText.text = minutes + ":" + second;
        if (time < 0)
        {
            Gameover();
        }
    }
    void Gameover()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
  
}
