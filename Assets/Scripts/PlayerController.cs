using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour 
{   
    //Control inputs
    [SerializeField] public InputActionAsset playerControlsAsset;

    private InputAction rotationAction;
    private InputAction accelDecelAction;
    private InputAction jumpAction;
    private InputAction flipAction;
    private InputAction boostAction;
    private InputAction flipDirectionAction;
    private InputAction restartAction;
    private InputAction escAction;
    public Vector2 Direction { get; set; } //Rotation x and y input
    public Vector2 Direction2 { get; set; } //AccelDecel x and y input
    public Vector2 FlipDirection { get; set; } //FlipDirection x and y input

    [HideInInspector] public bool isBoostPressed = false; 

    //Jump animation stuff
    private Animator animClone;
    private Animator animClone2;
    private GameObject jumpAnimClone;
    private GameObject jumpAnimClone2;
    private GameObject jumpAnimObject;

    // Output for jump animation script
    [HideInInspector] public int jumpCount = 0;

    //Boost animation stuff
    private Animator boostAnim;
    [HideInInspector] public GameObject boostAnimObject;

    // Ground speed
    [HideInInspector] public float Speed = 0;
    [HideInInspector] public float maxSpeed = 5f;
    [HideInInspector] public float Acceleration = 75f; //How fast object reaches max speed

    // Checking if grounded
    [HideInInspector] public bool grounded = false;
    public Transform groundCheck;
    public Transform groundCheck2;
    public float groundRadius = 0.1f;
    [HideInInspector] public LayerMask whatIsGround;

    // Air speed & variables (Jump & Boost)
    [HideInInspector] public float vSpeed;  //Vertical speed
    [HideInInspector] public float rotation; //X axis rotation
    [HideInInspector] public Vector2 CarSpeed;
    [HideInInspector] public float rotationSpeed = 5;
    [HideInInspector] public float jumpForce = 2000;
    [HideInInspector] public float boostForce = 75f;
    [HideInInspector] private bool doubleJump = false;
    [HideInInspector] public float flipForce = 1500;
    [HideInInspector] public float flipRotateForce = 100;

    // Checks car orientation
    [HideInInspector] public bool facingRight = true;
    [HideInInspector] public bool upright = true;

    //Booleans responsible for the direction of double flip, and whether it is allowed
    [HideInInspector] private bool upFlipDirection = false;
    [HideInInspector] private bool downFlipDirection = false;
    [HideInInspector] private bool usedFlip = false;


    [SerializeField] public int playerIndex;
    [SerializeField] public string playerObject;
    public void FixedUpdate()
    {
        InitialisingVariables();      
        Rotate();
        AccInputControl();
        OnBoost();
    }
    public void Update()
    {
        CheckUpright();
        CheckGrounded();
        UpFlipCheck();
        DownFlipCheck();
        GetPlayerIndex();
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
        playerObject = gameObject.name;
        AssignIndex();
        var gameplayActionMap = playerControlsAsset.FindActionMap($"GameplayP{playerIndex}");

        jumpAnimObject = GameObject.Find($"Jump animation{playerIndex}");
        boostAnimObject = GameObject.Find($"Boost animation{playerIndex}");
        rotationAction = gameplayActionMap.FindAction("Rotation");
        accelDecelAction = gameplayActionMap.FindAction("AccelDecel");
        jumpAction = gameplayActionMap.FindAction("Jump");
        boostAction = gameplayActionMap.FindAction("Boost");
        flipAction = gameplayActionMap.FindAction("FlipCar");
        flipDirectionAction = gameplayActionMap.FindAction("FlipDirection");
        restartAction = gameplayActionMap.FindAction("Restart");
        escAction = gameplayActionMap.FindAction("EscMenu");

        rotationAction.performed += OnRotation;
        rotationAction.canceled += OnRotation;
        accelDecelAction.performed += OnAccelDecel;
        accelDecelAction.canceled += OnAccelDecel;
        jumpAction.performed += OnJump;
        jumpAction.canceled -= OnJump;
        boostAction.started += OnBoostOn;
        boostAction.performed += OnBoostOn;
        boostAction.canceled += OnBoostOff;
        flipAction.performed += OnFlipCar;
        flipDirectionAction.performed += OnFlipDirection;
        flipDirectionAction.canceled += OnFlipDirection;
        restartAction.performed += OnRestart;
        escAction.performed += OnEscMenu;
    }
    public void AssignIndex()
    {
        if (playerObject == "PlayerOne") { playerIndex = 1; } else if (playerObject == "PlayerTwo") { playerIndex = 2; }
    }
    public int GetPlayerIndex()
    {
        return playerIndex;
    }
    public void OnEnable()
    {
        playerControlsAsset.Enable();
    }
    public void OnDisable()
    {
        playerControlsAsset.Disable();
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
    public void OnRotation(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        Direction = new Vector2(direction.x, direction.y);
    }
    public void OnAccelDecel(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        Direction2 = new Vector2(direction.x, direction.y);
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
    public void OnBoost()
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
    public void OnFlipCar(InputAction.CallbackContext context)
    {if (context.performed)
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
        
    }
    public void AccInputControl()
    {
        if (playerIndex == 1)
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * Acceleration * Direction2.y);
            }
        }
        else if (playerIndex == 2)
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(-transform.right * Acceleration * Direction2.y);
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
    public void CheckUpright() //Checking if upright
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
    public void OnRestart(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Restart key pressed.");
        }
        
    } //Resets the scene when the "Restart" menu is pressed.
    public void OnEscMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SceneManager.LoadScene(1);
        }
    } //Goes back to main menu when "EscMenu" action is pressed. 
}
