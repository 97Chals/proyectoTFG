using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habilities_manager : MonoBehaviour
{
    
    //vars
    public bool isHabilitiesOptions = false;
    bool isExitActive = false;

    public GameObject habilitiesMenu;
    public GameObject habilitiesBtn;
    public GameObject gameStats;

    public npc_manager npcManager;
    public menu_manager_v2 menuManager;

    public void habilitiesMenuBtn()
    {
        if (!isHabilitiesOptions)
        {
            isHabilitiesOptions = true;
            habilitiesMenu.SetActive(true);
            gameStats.SetActive(false);
        } else
        {
            habilitiesMenuBtnExit();
            gameStats.SetActive(true);
        }

        if (npcManager.isNpcOption)
        {
            npcManager.exitModeMenuBtn();
        }

        if (menuManager.isMenuActive)
        {
            menuManager.exitMenuBtn();
        }

        
    }

    public void habilitiesMenuBtnExit()
    {
        isExitActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isHabilitiesOptions && isExitActive)
        {
            isHabilitiesOptions = false;
            isExitActive = false;

            habilitiesMenu.SetActive(false);
            
        }
    }
}
