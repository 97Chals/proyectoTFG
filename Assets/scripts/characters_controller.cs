using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class characters_controller : MonoBehaviour
{
    public TMP_Text enemyName;
    string enemyNameCorrect;
 
    //Lista de enemigos
    public GameObject[] enemyList;

    int iterator = 0;
    System.Random rdom = new System.Random();

    //Se oculta el enemigo que acaba de morir
    public void EnemyDeactive()
    {
        enemyList[iterator].SetActive(false);
    }

    //Se muestra el siguiente enemigo
    public void EnemyActive()
    {
        enemyList[iterator].SetActive(true);
    }

    //Se escoje un enemigo al azar de la lista
    public void RandEnemy()
    {
        iterator = rdom.Next(enemyList.Length);
    }

    //Se obtiene el nombre
    public void getEnemyName()
    {
        string eName = enemyList[iterator].ToString();
        enemyNameCorrect = eName.Replace("(UnityEngine.GameObject)", "");
        enemyName.text = "" + enemyNameCorrect;
    }

    private void Update()
    {
        getEnemyName();
    }
}
