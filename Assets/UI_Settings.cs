using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Settings : MonoBehaviour
{
    public void CloseSettings()
    {
        MenuManager.OpenMenu(Menu.MAIN_MENU, gameObject);
    }
}
