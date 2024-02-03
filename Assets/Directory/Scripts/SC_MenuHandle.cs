using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MenuHandle : MonoBehaviour
{
    public GameObject unitsMenu;
    public fmod button_press;
    public void OpenUnits()
    {
        unitsMenu.SetActive(true);

    }
}
