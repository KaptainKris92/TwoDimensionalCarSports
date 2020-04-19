using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerController playerControl;
    /*[SerializeField] public InputActionAsset playerControlsAsset;*/
    [SerializeField] public Vector2 Direction { get; set; } //Rotation x and y input
    public Vector2 Direction2 { get; set; } //AccelDecel x and y input
    public Vector2 FlipDirection { get; set; } //FlipDirection x and y input
    public void FixedUpdate()
    {
        playerControl.InitialisingVariables();
        playerControl.Rotate();
        playerControl.AccInputControl();
    }
    public void Update()
    {
        playerControl.CheckUpright();
        playerControl.CheckGrounded();
        playerControl.UpFlipCheck();
        playerControl.DownFlipCheck();
        playerControl.GetPlayerIndex();
    }
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>(); //Gets the Player Input component 

        var playerControls = FindObjectsOfType<PlayerController>();
        var index = playerInput.playerIndex;
        playerControl = playerControls.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }
    public void OnAccelDecel(InputAction.CallbackContext context)
    {
        if(playerControl != null)
            playerControl.SetInputVectorAcc(context.ReadValue<Vector2>());
    }
    public void OnRotation(InputAction.CallbackContext context)
    {
        if (playerControl != null)
            playerControl.SetInputVectorRot(context.ReadValue<Vector2>());
    }
    public void OnJump(InputAction.CallbackContext context) { if (playerControl != null && context.performed) playerControl.Jump(); }
    public void OnBoostOn(InputAction.CallbackContext context) { if (playerControl != null && (context.performed)) playerControl.BoostOn(); }
    public void OnBoostOff(InputAction.CallbackContext context) { if (playerControl != null && context.canceled) playerControl.BoostOff(); }
    public void OnFlipCar(InputAction.CallbackContext context) {
        if (playerControl != null && context.performed)
            playerControl.FlipCar(); 
    }

    public void OnFlipDirection(InputAction.CallbackContext context)
    {
        if (playerControl != null) 
            playerControl.SetInputVectorFlip(context.ReadValue<Vector2>());
        
        
    } //Checking if Up or Down "FlipDirection" inputs are held
    public void OnRestart(InputAction.CallbackContext context)
    {
        if (playerControl != null && context.performed)
            playerControl.Restart();
    }
    public void OnEscMenu(InputAction.CallbackContext context)
    {
        if (playerControl != null && context.performed)
            playerControl.EscMenu();
    }



}