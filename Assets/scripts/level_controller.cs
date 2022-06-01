using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class level_controller : MonoBehaviour
{

    //GameObject
    public TMP_Text textLevel;
    public TMP_Text textAutoLevel;
    private bool autoLvl = false;
    private bool maxLvl = false;

    public int level = 1;
    public enemy_controller enemyControl;
    public coin_controller coin;

    // Update is called once per frame
    void Update()
    {
        SetText();

        if (autoLvl)
        {
            btnLevelUp();
        }

        if (maxLvl && (coin.coins >= coin.COINS_TO_PAY))
        {
            btnLevelUp();
        }
        else
        {
            maxLvl = false;
        }
    }

    public void btnLevelUp()
    {
        if(coin.coins > coin.COINS_TO_PAY)
        {
            level++;
            enemyControl.LevelUp();
            coin.coinPaid();
        }
        
    }

    public void btnAutoLevelUp()
    {
        autoLvl = !autoLvl;
    }

    public void btnMaxLevelUp()
    {
        maxLvl = true;
    }

    public void SetText()
    {
        textLevel.text = "" + level;
        if (autoLvl)
        {
            textAutoLevel.text = "Auto Lvl";
        }
        else
        {
            textAutoLevel.text = "";
        }
        
    }
}
