using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Utilities;

public class Player1Controller2 : MonoBehaviour
{

    //Controls inputs
    [SerializeField] public int playerIndex;
    [SerializeField] private InputActionAsset playerControls;
    private InputAction carMovementAction;
    private InputAction jumpAction;
    private InputAction flipAction;
    private InputAction boostAction;
    private InputAction flipDirectionAction;
   
    public float AccInput { get; set; }
    public bool isBoostPressed; 

    //Jump animation stuff
    private Animator animClone;
    private Animator animClone2;
    private GameObject jumpAnimClone;
    private GameObject jumpAnimClone2;
    public GameObject jumpAnimObject;

    // Output for jump animation script
    public int jumpCount = 0;
    public bool boostPressed;

    //Boost animation stuff
    /*public GameObject boostAnimation;*/
    private Animator boostAnim;
    public GameObject boostAnimObject;

    // Ground speed
    public float Speed = 0;
    public float maxSpeed = 5f;
    public float Acceleration = 75f; //How fast object reaches max speed

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
    public float jumpForce = 2000;
    public float boostForce = 75f;
    private bool doubleJump = false;
    public float flipForce = 1500;
    public float flipRotateForce = 100;

    // Checks car orientation
    public bool facingRight = true;
    public bool upright = true;

    private bool upFlipDirection = false;
    private bool downFlipDirection = false;
    private bool usedFlip = false;

    public int GetPlayerIndex()
    {
        return playerIndex;
    }
    
    private void OnEnable()
    {
        playerControls.Enable();
    }
    private void OnDisable()
    {
        playerControls.Disable();
    }
    public void FixedUpdate()
    {
        InitialisingVariables();
        Rotate();
        Boosting();
        AccInputControl();
    }
    public void Update()
    {
        checkUpright();
        CheckGrounded();
        UpFlipCheck();
        DownFlipCheck();        
    }
    public IEnumerator SecondWait()
    {
        yield return new WaitForSeconds(0.05f);
        grounded = false;
        jumpCount += 1;
    } // Waits momentarily after player jumps, then registers them as not grounded. Needed for jump animation & flips to function properly
    private IEnumerator SecondWait2()
    {
        yield return new WaitForSeconds(0.05f);
        usedFlip = true;
    } // Waits momentarily after flip, then registers that the double jump flip has been used.
    private void Awake()
    {
        var gameplayActionMap = playerControls.FindActionMap($"GameplayP{playerIndex}");
        jumpAnimObject = GameObject.Find($"Jump animation{playerIndex}");
        boostAnimObject = GameObject.Find($"Boost animation{playerIndex}");
        carMovementAction = gameplayActionMap.FindAction("CarMovement");
        jumpAction = gameplayActionMap.FindAction("Jump");
        boostAction = gameplayActionMap.FindAction("Boost");
        flipAction = gameplayActionMap.FindAction("FlipCar");
        flipDirectionAction = gameplayActionMap.FindAction("FlipDirection");
       

        carMovementAction.performed += OnCarMovement;
        carMovementAction.canceled += OnCarMovement;
        jumpAction.performed += OnJump;
        jumpAction.canceled -= OnJump;
        boostAction.started += OnBoostOn;
        boostAction.performed += OnBoostOn;
        boostAction.canceled += OnBoostOff;
        flipAction.performed += OnFlip;
        flipDirectionAction.performed += OnFlipDirection;
        flipDirectionAction.canceled += OnFlipDirection;
        

        isBoostPressed = false;
    }
    public void UpFlipCheck() //Checks if up arrow key held + jump (slash key) pressed 
    {
        if (FlipDirection.y > 0) upFlipDirection = true;
        else upFlipDirection = false;
    }
    public void DownFlipCheck()  //Checks if down arrow key held + jump (slash key) pressed 
    {
        if (FlipDirection.y < 0) downFlipDirection = true;
        else downFlipDirection = false;
    }
    public Vector2 Direction { get; set; } //CarMovement x and y input
    public Vector2 FlipDirection { get; set; } //CarMovement x and y input

    public void OnCarMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        Direction = new Vector2(direction.x, direction.y);   
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        //Player movement
        if ((grounded || !doubleJump) && facingRight)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * jumpForce);

            StartCoroutine(SecondWait());

            if (!doubleJump && !grounded)
            {
                doubleJump = true;
                StartCoroutine(SecondWait2());
            }
        }

        if ((grounded || !doubleJump) && !facingRight)
        {
            GetComponent<Rigidbody2D>().AddForce(-transform.up * jumpForce);
            StartCoroutine(SecondWait());

            if (!doubleJump && !grounded)
            {
                doubleJump = true;
            }
        }

        //Jump animation

        if (jumpCount == 0 && facingRight)
        {
            jumpAnimClone = Instantiate(jumpAnimObject, transform.position, transform.rotation);
            animClone = jumpAnimClone.GetComponent<Animator>();
            animClone.SetBool("IsJumping", true);
        }
        else if (jumpCount == 1 && facingRight)
        {
            Destroy(jumpAnimClone, 0.05f);
            animClone.SetBool("IsJumping", false);
            jumpAnimClone2 = Instantiate(jumpAnimObject, transform.position, transform.rotation);
            animClone2 = jumpAnimClone2.GetComponent<Animator>();
            animClone2.SetBool("IsJumping", true);
            Destroy(jumpAnimClone2, 0.5f);
        }
        if (jumpCount == 0 && !facingRight)
        {
            jumpAnimClone = Instantiate(jumpAnimObject, transform.position, transform.rotation * Quaternion.Euler(180f, 0f, 0f));
            animClone = jumpAnimClone.GetComponent<Animator>();
            animClone.SetBool("IsJumping", true);
        }
        else if (jumpCount == 1 && !facingRight)
        {
            Destroy(jumpAnimClone, 0.05f);
            animClone.SetBool("IsJumping", false);
            jumpAnimClone2 = Instantiate(jumpAnimObject, transform.position, transform.rotation * Quaternion.Euler(180f, 0f, 0f));
            animClone2 = jumpAnimClone2.GetComponent<Animator>();
            animClone2.SetBool("IsJumping", true);
            Destroy(jumpAnimClone2, 0.5f);
        }

        //Double jump flip
        if (playerIndex == 1)
        {
            if (upFlipDirection && !grounded && facingRight && !usedFlip)
            {
                GetComponent<Rigidbody2D>().AddTorque(-flipRotateForce * 100, ForceMode2D.Force);
                GetComponent<Rigidbody2D>().AddForce(transform.right * flipForce);
                StartCoroutine(SecondWait2());
            }
            else if (downFlipDirection && !grounded && facingRight && !usedFlip)
            {
                GetComponent<Rigidbody2D>().AddTorque(flipRotateForce * 100, ForceMode2D.Force);
                GetComponent<Rigidbody2D>().AddForce(-transform.right * flipForce);
                StartCoroutine(SecondWait2());
            }
            else if (upFlipDirection && !grounded && !facingRight && !usedFlip)
            {
                GetComponent<Rigidbody2D>().AddTorque(flipRotateForce * 100, ForceMode2D.Force);
                GetComponent<Rigidbody2D>().AddForce(transform.right * flipForce);
                StartCoroutine(SecondWait2());
            }
            else if (downFlipDirection && !grounded && !facingRight && !usedFlip)
            {
                GetComponent<Rigidbody2D>().AddTorque(-flipRotateForce * 100, ForceMode2D.Force);
                GetComponent<Rigidbody2D>().AddForce(-transform.right * flipForce);
                StartCoroutine(SecondWait2());
            }
        }
        else if (playerIndex == 2)
        {
            if (upFlipDirection && !grounded && facingRight && !usedFlip)
            {
                GetComponent<Rigidbody2D>().AddTorque(flipRotateForce * 100, ForceMode2D.Force);
                GetComponent<Rigidbody2D>().AddForce(-transform.right * flipForce);
                StartCoroutine(SecondWait2());
            }
            else if (downFlipDirection && !grounded && facingRight && !usedFlip)
            {
                GetComponent<Rigidbody2D>().AddTorque(-flipRotateForce * 100, ForceMode2D.Force);
                GetComponent<Rigidbody2D>().AddForce(transform.right * flipForce);
                StartCoroutine(SecondWait2());
            }
            else if (upFlipDirection && !grounded && !facingRight && !usedFlip)
            {
                GetComponent<Rigidbody2D>().AddTorque(-flipRotateForce * 100, ForceMode2D.Force);
                GetComponent<Rigidbody2D>().AddForce(-transform.right * flipForce);
                StartCoroutine(SecondWait2());
            }
            else if (downFlipDirection && !grounded && !facingRight && !usedFlip)
            {
                GetComponent<Rigidbody2D>().AddTorque(flipRotateForce * 100, ForceMode2D.Force);
                GetComponent<Rigidbody2D>().AddForce(transform.right * flipForce);
                StartCoroutine(SecondWait2());
            }
        }
    }
    public void OnBoostOn(InputAction.CallbackContext context)
    {
        isBoostPressed = true;
    }
    public void OnBoostOff(InputAction.CallbackContext context)
    {
        isBoostPressed = false;
    }
    public void Boosting()
    {
        boostAnim = boostAnimObject.GetComponent<Animator>();
        if (playerIndex == 1)
        {
            if (isBoostPressed)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * boostForce);
                boostAnim.SetBool("IsBoosting", true);
            }
            else boostAnim.SetBool("IsBoosting", false);
        }
        else if (playerIndex == 2)
        {
            if (isBoostPressed)
            {
                GetComponent<Rigidbody2D>().AddForce(-transform.right * boostForce);
                boostAnim.SetBool("IsBoosting", true);
            }
            else boostAnim.SetBool("IsBoosting", false);
        }


    }
    public void OnFlip(InputAction.CallbackContext context)
    {
        if (!grounded)
        {
            upright = !upright;
            Vector3 theScale2 = transform.localScale;
            theScale2.y *= -1;
            transform.localScale = theScale2;
            facingRight = !facingRight;
        }
    }
    public void AccInputControl()
    {
        if (playerIndex == 1)
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * Acceleration * Direction.y);
            }
        }
        else if (playerIndex == 2)
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(-transform.right * Acceleration * Direction.y);
            }
        }
    }
    public void Rotate()
    {
        if (!grounded)
        {
            GetComponent<Rigidbody2D>().AddTorque(rotationSpeed * -Direction.x * 5, ForceMode2D.Force);
            transform.Rotate(0, 0, -Direction.x * rotationSpeed);
        }
    } // Rotate the car using "left" & "right" arrow keys, or the x axis of left stick on gamepad
    public void InitialisingVariables()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround) && Physics2D.OverlapCircle(groundCheck2.position, groundRadius, whatIsGround); // Checking if grounded — Returns if colliders are present
        rotation = (GetComponent<Rigidbody2D>().rotation); // Angle of the car
        vSpeed = (GetComponent<Rigidbody2D>().velocity.y); // Vertical velocity
        CarSpeed = GetComponent<Rigidbody2D>().velocity; // Speed of the car
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
    public void OnFlipDirection(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        FlipDirection = new Vector2(direction.x, direction.y);
    } //Checking if Up or Down "FlipDirection" inputs are held
}
