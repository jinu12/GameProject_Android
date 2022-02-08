using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
     void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
