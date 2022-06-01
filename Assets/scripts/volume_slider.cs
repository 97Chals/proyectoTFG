using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volume_slider : MonoBehaviour
{
    //Vars & objects
    [SerializeField] private Slider volumeSlider;
    public float sliderValue;
    public Image muteImage;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.onValueChanged.AddListener(val => sound_manager.sm.ChangeMasterVolume(val));

        volumeSlider.value = PlayerPrefs.GetFloat("audioVolume",0.5f);
        AudioListener.volume = volumeSlider.value;

        OnMute();
    }

    public void ChangeSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("audioVolume", sliderValue);
        AudioListener.volume = volumeSlider.value;
        OnMute();
    }

    public void OnMute()
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