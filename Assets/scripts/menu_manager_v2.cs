using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_manager_v2 : MonoBehaviour
{
    //vars
    public bool isMenuActive = false;
    bool isExitActive = false;

    //Menu Obj's
    public GameObject optionsMenu;
    public GameObject menuButton;
    

    //External obj's
    public GameObject gameStats;

    //other scripts
    public habilities_manager habManager;
    public npc_manager npcManager;

    //Funcion del boton settings que aparece en la UI
    public void optionsMenuBtn()
    {
        if (!isMenuActive)
        {
            isMenuActive = true; //Controlamos que el menu este activo o no

            //Activamos el menu y el boton de exit
            optionsMenu.SetActive(true);

            //Desactivamos el boton de control de clicks
            gameStats.SetActive(false);
        } else
        {
            //Si se vuelve a pulsar el boton se llama a la funcion de salir
            exitMenuBtn();
            gameStats.SetActive(true);
        }

        //Si el menu social esta abierto llama a la funcion de cerrar
        if (npcManager.isNpcOption)
        {
            npcManager.exitModeMenuBtn();
        }

        //si el menu de habilidades esta abierto llama a la funcion de cerrar
        if (habManager.isHabilitiesOptions)
        {
            habManager.habilitiesMenuBtnExit();
        }
        
    }

    //Funcion del boton exit o del boton settings al ser pulsado de nuevo
    public void exitMenuBtn()
    {
        isExitActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMenuActive && isExitActive)
        {
            //Se resetean los valores en salida
            isMenuActive = false;
            isExitActive = false;

            optionsMenu.SetActive(false);            
        }
    }
}


