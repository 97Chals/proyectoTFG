using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volume_controller : MonoBehaviour
{
    //Vars & objects
    public Slider volumeSlider;
    public float sliderValue;
    public Image muteImage;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("audioVolume", 0.5f);
        AudioListener.volume = volumeSlider.value;

        onMute();
    }

    public void changeSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("audioVolume", sliderValue);
        AudioListener.volume = volumeSlider.value;
        onMute();
    }

    public void onMute()
    {
        if (sliderValue == 0)
        {
            muteImage.enabled = true;
        }
        else
        {
            muteImage.enabled = false;

        }
    }

}