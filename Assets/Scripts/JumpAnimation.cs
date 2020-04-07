using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class JumpAnimation : MonoBehaviour
{
    private Animator animClone;
    private Animator animClone2;

    private GameObject jumpAnimClone;
    private GameObject jumpAnimClone2;
    public GameObject jumpAnimObject;
    public int jumped;
    public bool rightFacing;
    public bool isGrounded;
    void Start()
    {
        jumpAnimObject = GameObject.Find("Jump animation");
    } 
    public void Update()
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;
        
        jumped = GameObject.Find("PlayerOne").GetComponent<Player1Controller2>().jumpCount;
        rightFacing = GameObject.Find("PlayerOne").GetComponent<Player1Controller2>().facingRight;
        isGrounded = GameObject.Find("PlayerOne").GetComponent<Player1Controller2>().grounded;

        if ((gamepad.buttonSouth.wasPressedThisFrame | keyboard.cKey.wasPressedThisFrame) && (jumped == 0) && !rightFacing)
        {
            jumpAnimClone = Instantiate(jumpAnimObject, transform.position, transform.rotation);
            animClone = jumpAnimClone.GetComponent<Animator>();
            animClone.SetBool("IsJumping", true);
            Destroy(jumpAnimClone, 0.5f);
        }
        else if ((gamepad.buttonSouth.wasPressedThisFrame | keyboard.cKey.wasPressedThisFrame) && (jumped == 1) && !rightFacing)
        {
            animClone.SetBool("IsJumping", false);
            jumpAnimClone2 = Instantiate(jumpAnimObject, transform.position, transform.rotation);
            animClone2 = jumpAnimClone2.GetComponent<Animator>();
            animClone2.SetBool("IsJumping", true);
            Destroy(jumpAnimClone2, 0.5f);
        }
        if ((gamepad.buttonSouth.wasPressedThisFrame | keyboard.cKey.wasPressedThisFrame) && (jumped == 0) && rightFacing)
        {
            jumpAnimClone = Instantiate(jumpAnimObject, transform.position, transform.rotation * Quaternion.Euler(180f, 0f, 0f));
            animClone = jumpAnimClone.GetComponent<Animator>();
            animClone.SetBool("IsJumping", true);
            Destroy(jumpAnimClone, 0.5f);
        }
        else if ((gamepad.buttonSouth.wasPressedThisFrame | keyboard.cKey.wasPressedThisFrame) && (jumped == 1) && rightFacing)
        {
            animClone.SetBool("IsJumping", false);
            jumpAnimClone2 = Instantiate(jumpAnimObject, transform.position, transform.rotation * Quaternion.Euler(180f, 0f, 0f));
            animClone2 = jumpAnimClone2.GetComponent<Animator>();
            animClone2.SetBool("IsJumping", true);
            Destroy(jumpAnimClone2, 0.5f);
        }
    }
}
