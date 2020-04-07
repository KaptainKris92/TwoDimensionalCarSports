using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;


public class Player2Controller2 : MonoBehaviour
{
    public GameObject boostAnimation;

    // Ground speed
    public float Speed = 0;
    public float maxSpeed = 50f;
    public float Acceleration = 20f; //How fast object reaches max speed

    // Checking if grounded
    public bool grounded = false;
    public Transform groundCheck;
    public Transform groundCheck2;
    float groundRadius = 0.1f;
    public LayerMask whatIsGround;

    // Air speed & variables (Jump & Boost)
    public float vSpeed;  //Vertical speed
    public float rotation; //X axis rotation
    public Vector2 CarSpeed;

    public float rotationSpeed = 5;
    [SerializeField] public float jumpForce = 2000;
    [SerializeField] public float boostForce = 75f;
    private bool doubleJump = false;
    public float flipForce = 1500;
    public float flipRotateForce = 100;


    public bool facingRight = false;
    public bool upright = true;

    private bool upFlipKeyboard = false;
    private bool downFlipKeyboard = false;
    private bool usedFlip = false;

    // Output for jump animation script
    public int jumpCount = 0;
    public bool boostPressed;

    public void FixedUpdate()
    {
        InitialisingVariables();
        Rotate();
        KeyboardAccelerate();
        KeyboardDeccelerate();
        Boost();
    }
    public void Update()
    {
        checkUpright();
        CheckGrounded();
        CarJumping();
        VerticalFlipping();
        UpFlipCheck();
        DownFlipCheck();
        DoubleJumpFlipKeyboard();
    }
    public IEnumerator SecondWait()
    {
        yield return new WaitForSeconds(0.05f);
        grounded = false;
        jumpCount = jumpCount+1;
    } // Waits momentarily after player jumps, then registers them as not grounded. Needed for jump animation & flips to function properly
    private IEnumerator SecondWait2()
    {
        yield return new WaitForSeconds(0.05f);
        usedFlip = true;
    } // Waits momentarily after flip, then registers that the double jump flip has been used.
    public void VerticalFlipping() // "," key or "R1" flips the car upside down only if wheels are not touching the ground
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if (!grounded && (gamepad.rightShoulder.wasPressedThisFrame | keyboard.commaKey.wasPressedThisFrame))
        {
            VerticalFlip();
            facingRight = !facingRight;
        }
    }
    public void CarJumping() // Jumping  with "/" on keyboard or "X" on controller    
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if ((grounded || !doubleJump) && (gamepad.buttonSouth.wasPressedThisFrame | keyboard.slashKey.wasPressedThisFrame) && !facingRight)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * jumpForce);

            StartCoroutine(SecondWait());

            if (!doubleJump && !grounded)
            {
                doubleJump = true;
                StartCoroutine(SecondWait2());
            }

        }

        if ((grounded || !doubleJump) && (gamepad.buttonSouth.wasPressedThisFrame | keyboard.slashKey.wasPressedThisFrame) && facingRight)
        {

            GetComponent<Rigidbody2D>().AddForce(-transform.up * jumpForce);
            StartCoroutine(SecondWait());

            /*Jumping = true;*/

            if (!doubleJump && !grounded)
            {
                doubleJump = true;

            }
        }
    }
    public void Boost() //Boost with "." on keyboard or "Circle" on controller
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if ((gamepad.buttonEast.wasPressedThisFrame | keyboard.periodKey.wasPressedThisFrame))
        {
            GetComponent<Rigidbody2D>().AddForce(-transform.right * boostForce);
        }

        if ((gamepad.buttonEast.isPressed | keyboard.periodKey.isPressed))
        {
            GetComponent<Rigidbody2D>().AddForce(-transform.right * boostForce);
        }
    }
    public void DoubleJumpFlipKeyboard() //Forward or backwards flip performed by pressing the jump button and holding up on the joysick (controller) or holding accelerate (keyboard) while in the air
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if ((keyboard.slashKey.wasPressedThisFrame | gamepad.buttonSouth.wasPressedThisFrame) && upFlipKeyboard && !grounded && facingRight && !usedFlip)
        {
            GetComponent<Rigidbody2D>().AddTorque(-flipRotateForce * 100, ForceMode2D.Force);
            GetComponent<Rigidbody2D>().AddForce(-transform.right * flipForce);
            StartCoroutine(SecondWait2());
        }
        else if ((keyboard.slashKey.wasPressedThisFrame | gamepad.buttonSouth.wasPressedThisFrame) && downFlipKeyboard && !grounded && facingRight && !usedFlip)
        {
            GetComponent<Rigidbody2D>().AddTorque(flipRotateForce * 100, ForceMode2D.Force);
            GetComponent<Rigidbody2D>().AddForce(transform.right * flipForce);
            StartCoroutine(SecondWait2());
        }
        else if ((keyboard.slashKey.wasPressedThisFrame | gamepad.buttonSouth.wasPressedThisFrame) && downFlipKeyboard && !grounded && !facingRight && !usedFlip)
        {
            GetComponent<Rigidbody2D>().AddTorque(-flipRotateForce * 100, ForceMode2D.Force);
            GetComponent<Rigidbody2D>().AddForce(transform.right * flipForce);
            StartCoroutine(SecondWait2());
        }
        else if ((keyboard.slashKey.wasPressedThisFrame | gamepad.buttonSouth.wasPressedThisFrame) && upFlipKeyboard && !grounded && !facingRight && !usedFlip)
        {
            GetComponent<Rigidbody2D>().AddTorque(flipRotateForce * 100, ForceMode2D.Force);
            GetComponent<Rigidbody2D>().AddForce(-transform.right * flipForce);
            StartCoroutine(SecondWait2());
        }
    }
    public void CheckGrounded() // Resets double jump, flip, and jump animation
    {
        //Double Jump & flip reset on ground
        if (grounded)
        {
            doubleJump = false;
            usedFlip = false;
            jumpCount = 0;
        }
    }
    public void UpFlipCheck() //Checks if up arrow key held + jump (slash key) pressed 
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if (keyboard.upArrowKey.isPressed | gamepad.leftStick.up.isPressed) upFlipKeyboard = true;
        else upFlipKeyboard = false;
    }
    public void DownFlipCheck()  //Checks if down arrow key held + jump (slash key) pressed 
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if (keyboard.downArrowKey.isPressed | gamepad.leftStick.down.isPressed) downFlipKeyboard = true;
        else downFlipKeyboard = false;
    }
    public void KeyboardAccelerate() // Binary acceleration 
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if (grounded && (gamepad.rightTrigger.isPressed | keyboard.upArrowKey.isPressed))
        {
            GetComponent<Rigidbody2D>().AddForce(-transform.right * Acceleration);
        }
    }
    public void KeyboardDeccelerate() // Binary deceleration
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        if (grounded && (gamepad.leftTrigger.isPressed | keyboard.downArrowKey.isPressed) && (vSpeed < maxSpeed))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * Acceleration);
        }
    }
    public void InitialisingVariables()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround) && Physics2D.OverlapCircle(groundCheck2.position, groundRadius, whatIsGround); // Checking if grounded — Returns if colliders are present
        rotation = (GetComponent<Rigidbody2D>().rotation); // Angle of the car
        vSpeed = (GetComponent<Rigidbody2D>().velocity.y); // Vertical velocity
        CarSpeed = GetComponent<Rigidbody2D>().velocity; // Speed of the car
    }
    public void Rotate()
    {
        var gamepad = Gamepad.current;
        var keyboard = Keyboard.current;

        // Car rotation with controller
        float rotate = -gamepad.leftStick.x.ReadValue();

        if (!grounded)
        {
            GetComponent<Rigidbody2D>().AddTorque(rotationSpeed * rotate * 5, ForceMode2D.Force);
            transform.Rotate(0, 0, rotate * rotationSpeed);
        }

        //Car rotation with keyboard
        float rotate2;
        if (keyboard.rightArrowKey.isPressed) rotate2 = -1;
        else if (keyboard.leftArrowKey.isPressed) rotate2 = 1;
        else rotate2 = 0;

        if (!grounded)
        {
            GetComponent<Rigidbody2D>().AddTorque(rotationSpeed * rotate2 * 5, ForceMode2D.Force);
            transform.Rotate(0, 0, rotate2 * rotationSpeed);
        }
    } // Rotate the car using "left" & "right" arrow keys, or the x axis of left stick on gamepad
    public void checkUpright() //Checking if upright
    {
        if ((rotation < -140) && (rotation > -190))
        {
            upright = false;
        }
        else upright = true;

        if ((rotation > 140) && (rotation < 190))
        {
            upright = false;
        }
    }
    public void VerticalFlip() // Flips car vertically (Transforms -1 on y-axis)
    {
        upright = !upright;
        Vector3 theScale2 = transform.localScale;
        theScale2.y *= -1;
        transform.localScale = theScale2;
    }
}
