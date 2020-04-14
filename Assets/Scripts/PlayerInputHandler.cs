/*using System;
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
    private PlayerInput player1;
    private PlayerInput player2;
    private Player1Controller2 player1Controls;
    private GameObject player1Prefab;
    private GameObject player2Prefab;


    public Player1Controller2 Player1Controls { get => player1Controls; set => player1Controls = value; }

    *//*private Player2Controller2 player2Controls;*//*
    private void Awake()
    {
        player1Prefab = GameObject.Find("PlayerOne");
        player2Prefab = GameObject.Find("PlayerTwo");
        player1 = PlayerInput.Instantiate(player1Prefab, controlScheme: "GameplayP1", pairWithDevice: Keyboard.current);
        player2 = PlayerInput.Instantiate(player2Prefab, controlScheme: "GameplayP2", pairWithDevice: Keyboard.current);


        playerInput = GetComponent<PlayerInput>();
        
        var player1Cs = FindObjectsOfType<Player1Controller2>();
        var index = playerInput.playerIndex;

        player1Controls = player1Cs.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }
}
*/