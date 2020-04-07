using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;

public class EscMenu : MonoBehaviour
{
    public void Update()
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if (keyboard.escapeKey.wasPressedThisFrame | gamepad.startButton.wasPressedThisFrame)
        {
            SceneManager.LoadScene(1);
    }
}
    
}
