﻿using UnityEngine;
using VRTK;
public class MenuToggle : MonoBehaviour {
    public VRTK_ControllerEvents controllerEvents;
    public GameObject menu;

    bool menuState = true;
    void OnEnable()
    {
        controllerEvents.ButtonTwoPressed += ControllerEvents_ButtonTwoPressed;
        controllerEvents.ButtonTwoReleased += ControllerEvents_ButtonTwoReleased;
    }

    void OnDisable()
    {
        controllerEvents.ButtonTwoPressed -= ControllerEvents_ButtonTwoPressed;
        controllerEvents.ButtonTwoReleased -= ControllerEvents_ButtonTwoReleased;
    }

    private void ControllerEvents_ButtonTwoReleased(object sender, ControllerInteractionEventArgs e)
    {
        menuState = !menuState;
        menu.SetActive(menuState);
    }

    private void ControllerEvents_ButtonTwoPressed(object sender, ControllerInteractionEventArgs e)
    {
        
    }
}
