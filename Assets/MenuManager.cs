using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MenuManager
{
    public static bool IsInitialized { get; private set; }
    public static GameObject mainMenu, settings;

    public static void Init()
    {
        GameObject canvas = GameObject.Find("Canvas");
        mainMenu = canvas.transform.Find("MainMenu").gameObject;
        settings = canvas.transform.Find("Settings").gameObject;

        IsInitialized = true;
    }

    public static void OpenMenu(Menu menu, GameObject callingMenu)
    {
        if (!IsInitialized)
        {
            Init();
        }

        switch (menu)
        {
            case Menu.MAIN_MENU:
                mainMenu.SetActive(true);
                //mainMenu.SetActive(false);
                break;

            case Menu.SETTINGS:
                //settings.SetActive(true);
                settings.SetActive(true);
                break;
        }

        callingMenu.SetActive(false);
    }
}
