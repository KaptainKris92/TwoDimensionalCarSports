using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Utilities;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private Player1Controller2 player1Controls;

    public Player1Controller2 Player1Controls { get => player1Controls; set => player1Controls = value; }

    /*private Player2Controller2 player2Controls;*/
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        
        var player1Cs = FindObjectsOfType<Player1Controller2>();
        var index = playerInput.playerIndex;

        player1Controls = player1Cs.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }
}
