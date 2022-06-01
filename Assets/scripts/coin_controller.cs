using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_controller : MonoBehaviour
{
    public double coins;
    System.Random rdom = new System.Random();
    public level_controller lvl;

    public double COINS_TO_PAY;

    private void Start()
    {
        COINS_TO_PAY = 100;
    }

    public void CoinGain()
    {
        coins += (100 + rdom.Next(lvl.level ));
    }

    public void CoinPaid()
    {
        if (lvl.level == 1)
        {
            coins -= COINS_TO_PAY;
        }
        else
        {
            COINS_TO_PAY = 100 + (lvl.level * 10);
            coins -= COINS_TO_PAY;
        }
    }
}
