using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class BoostAnimation : MonoBehaviour
{

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if (keyboard.xKey.isPressed | gamepad.buttonEast.isPressed)
        {
            anim.SetBool("IsBoosting", true);
        }
        else
        {
            anim.SetBool("IsBoosting", false);
        }
    }
}
