using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class quality_controller : MonoBehaviour
{
    public TextMeshProUGUI qaText;
    private string qualitysNames;

    private int newQuality = 2;

    public void NextQuality()
    {
        newQuality++;
        Qualitys();
    }
    public void BackQuality()
    {
        newQuality--;
        Qualitys();
    }

    public void Aplie()
    {
        QualitySettings.SetQualityLevel(newQuality, true);
    }

    private void Qualitys()
    {
        newQuality = Mathf.Clamp(newQuality, 0, 5);
        switch (newQuality)
        {
            case 0://Very Low
                qualitysNames = "Very Low";
                break;
            case 1://Low
                qualitysNames = "Low";
                break;
            case 2://Medium
                qualitysNames = "Medium";
                break;
            case 3://Hight
                qualitysNames = "High";
                break;
            case 4://Very Hight
                qualitysNames = "Very High";
                break;
            case 5://Ultra
                qualitysNames = "Ultra";
                break;
        }
        qaText.text = qualitysNames;
    }
}
