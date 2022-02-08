using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenseChange : MonoBehaviour
{
         public void ChangeFirstScense ()
    {
        SceneManager.LoadScene("01.FirstScene");
    }
    public void ChangeSecondScense()
    {
        SceneManager.LoadScene("02.Second Map");
    }
    public void ChangeThirdScense()
    {
        SceneManager.LoadScene("04.FourMap");
    }
    public void ChangeFourthlyScense()
    {
        SceneManager.LoadScene("03.ThirdScene");
    }
    public void ChangeFifthlyScense()
    {
        SceneManager.LoadScene("05.FiveMap");
    }
    public void ChangeSixthScene()
    {
        SceneManager.LoadScene("04.FourMap 1");
    }
    public void ChangeSeventhScene()
    {
        SceneManager.LoadScene("03.ThirdScene 1");
    }
    public void ChangeEightScene()
    {
        SceneManager.LoadScene("05.FiveMap 1");
    }
    public void ChangeNineScene()
    {
        SceneManager.LoadScene("02.Second Map 1");
    }


}
