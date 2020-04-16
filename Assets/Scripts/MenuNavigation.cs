using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    [SerializeField] public InputActionAsset playerControlsAsset;
    private InputAction escAction;
    public void OnEnable()
    {
        playerControlsAsset.Enable();
    }
    public void OnDisable()
    {
        playerControlsAsset.Disable();
    }
    public void Awake()
    {
        var menuActionMap = playerControlsAsset.FindActionMap("Menu");
        escAction = menuActionMap.FindAction("EscMenu");
        escAction.performed += OnEscMenu;
    }
    public void OnEscMenu(InputAction.CallbackContext context)
    {
            SceneManager.LoadScene(1);

    } //Goes back to main menu when "EscMenu" action is pressed. 
}
