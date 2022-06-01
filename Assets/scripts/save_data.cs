using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class save_data
{
    public float maxHealth;
    public float currentHealth;
    public int level;
    public double coin;
    public int enemyCounter;

    public save_data(coin_controller c, enemy_controller enemy, level_controller lvl)
    {
        maxHealth = enemy.maxHealth;
        currentHealth = enemy.currentHealth;
        level = lvl.level;
        coin = c.coins;
        enemyCounter = enemy.enemyCount;
    }
}
