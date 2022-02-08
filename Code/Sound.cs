using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour { 

    public Slider backvolume;
    public AudioSource audio;

    private float backVol = 1f;
    void Start()
    {
        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        backvolume.value = backVol;
        audio.volume = backvolume.value;
    }

    // Update is called once per frame
    void Update()
    {
        SoundSlider();
    }
    public void SoundSlider()
    {
        audio.volume = backvolume.value;
        PlayerPrefs.SetFloat("backvol", backVol);
    }
}
