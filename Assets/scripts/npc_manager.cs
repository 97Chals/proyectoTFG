using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_manager : MonoBehaviour
{
    public bool isNpcOption = false;
    bool isExitActive = false;

    public GameObject NpcMenu;
    public GameObject NpcBtn;

    public GameObject gameStats;

    public habilities_manager habManager;
    public menu_manager_v2 menuManager;


    public void clickNpcMenuBtn()
    {
        if(!isNpcOption)
        {
            NpcMenu.SetActive(true);
            isNpcOption = true;
            gameStats.SetActive(false);
        } else
        {
            exitModeMenuBtn();
            gameStats.SetActive(true);
        }

        if (habManager.isHabilitiesOptions)
        {
            habManager.habilitiesMenuBtnExit();
        }

        if (menuManager.isMenuActive)
        {
            menuManager.exitMenuBtn();
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        if (isNpcOption && isExitActive)
        {
            isNpcOption = false;
            isExitActive = false;
            
            NpcMenu.SetActive(false);
            
        }
    }

    public void exitModeMenuBtn()
    {
        isExitActive = true;
        
    }
}
