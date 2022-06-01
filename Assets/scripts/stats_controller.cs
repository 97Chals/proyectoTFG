using System.Collections;
using System.Collections.Generic;
using PolyLabs;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stats_controller : MonoBehaviour
{
    //Text
    public TMP_Text levelStat;
    public TMP_Text damageStat;
    public TMP_Text coinCount;
    public TMP_Text coinPrice;
    public TMP_Text enemyCount;

    //External Class
    public level_controller lvl;
    public enemy_controller enemy;
    public coin_controller coin;

    // Update is called once per frame
    void Update()
    {
        printStats();
    }

    private void printStats()
    {
            levelStat.text  = "" + lvl.level;
            damageStat.text = ShortScale.ParseFloat(enemy.damage);
            coinCount.text  = ShortScale.ParseDouble(coin.coins);
            coinPrice.text  = ShortScale.ParseDouble(coin.COINS_TO_PAY); ;
            enemyCount.text = "" + enemy.enemyCount;
    }
}
