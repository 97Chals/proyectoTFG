using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_controller : MonoBehaviour
{

    [SerializeField] public float maxHealth = 100;
    [SerializeField] public float currentHealth;
    [SerializeField] public float damage = 1;
    [SerializeField] public int enemyCount = 0;
    [SerializeField] private AudioClip clip;

    System.Random rdom = new System.Random();


    public GameObject attackBtn;

    public life_bar_controller healthBar;
    public characters_controller enemies;
    public level_controller lvl;
    public coin_controller coin;

    public void AttackBtnPressed()
    {
        TakeDamage();
        sound_manager.sm.PlaySound(clip);
    }

    void TakeDamage()
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            OnDieEnemy();
            coin.CoinGain();
        }
    }

    private void LoadData()
    {
        save_data playerData = save_manager.LoadSaveData();
        maxHealth = playerData.maxHealth;
        currentHealth = playerData.currentHealth;
        coin.coins = playerData.coin;
        lvl.level = playerData.level;
        enemyCount = playerData.enemyCounter;

        LevelUp();
        LifeUp();
        RotateEnemy();
        enemyCount--;
        if(enemyCount < 0) { enemyCount = 0; }
    }

    private void OnDestroy()
    {
        SaveData();
    }

    private void SaveData()
    {
        save_manager.SavePlayerData(coin, this, lvl);
    }

    // Start is called before the first frame update
    void Start()
    {
        damage = (int)(lvl.level * 1.654979819);
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        LoadData();
    }
    private void Awake()
    {
        //damage = (int)(lvl.level * 1.654979819);
        //LoadData();
    }
    public void LevelUp()
    {
        damage = (int)(lvl.level * 1.654979819);
    }

    public void OnDieEnemy()
    {
        currentHealth = maxHealth;
        LifeUp();
        RotateEnemy();
        enemyCount++;
    }

    private void RotateEnemy()
    {
        enemies.EnemyDeactive();
        enemies.RandEnemy();
        enemies.EnemyActive();
    }

    private void LifeUp()
    {
        maxHealth = maxHealth + ((int)(rdom.Next(lvl.level) * 0.654979819));
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(maxHealth);
    }
}
