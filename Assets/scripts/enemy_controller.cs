using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_controller : MonoBehaviour
{

    public float maxHealth = 100;
    public float currentHealth;
    public float damage;
    public int enemyCount = 0;
    System.Random rdom = new System.Random();


    public GameObject attackBtn;

    public life_bar_controller healthBar;
    public characters_controller enemies;
    public level_controller lvl;
    public coin_controller coin;

    public void AttackBtnPressed()
    {
        TakeDamage();
    }

    void TakeDamage()
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            onDieEnemy();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        damage = lvl.level;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void LevelUp()
    {
        damage = (int)(lvl.level * 1.654979819);
    }

    public void onDieEnemy()
    {
        currentHealth = maxHealth;
        lifeUp();
        coin.coinGain();
        rotateEnemy();
        enemyCount++;
    }

    private void rotateEnemy()
    {
        enemies.EnemyDeactive();
        enemies.RandEnemy();
        enemies.EnemyActive();
    }

    private void lifeUp()
    {
        maxHealth = maxHealth + ((int)(rdom.Next(lvl.level) * 0.654979819));
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(maxHealth);
    }
}
