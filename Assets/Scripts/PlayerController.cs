using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
/*using UnityEngine.InputSystem.Users;*/
using UnityEngine.SceneManagement;
/*using System.Linq;*/

public class PlayerController : MonoBehaviour 
{   
    private Vector2 inputVectorAcc;
    private Vector2 inputVectorRot;
    private Vector2 inputVectorFlip;

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
    [SerializeField] public bool grounded = false;
    [SerializeField] public Transform groundCheck;
    [SerializeField] public Transform groundCheck2;
    [SerializeField] public float groundRadius = 0.1f;
    [SerializeField] public LayerMask whatIsGround;

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

    public void SetInputVectorAcc(Vector2 direction)
    {
        inputVectorAcc = direction;
    }
    public void SetInputVectorRot(Vector2 direction)
    {
        inputVectorRot = direction;
    }
    public void SetInputVectorFlip(Vector2 direction)
    {
        inputVectorFlip = direction;
    }
    public void FixedUpdate()
    {
        Boost();
    }
    private void Awake()
    {
        playerObject = gameObject.name; //Retrieves the name of each player object — PlayerOne for Player 1, PlayerTwo for Player 2

        AssignIndex(); //Gives Player 1 an index of 1 and Player 2 an index of 2
        
        /*var gameplayActionMap = playerControlsAsset.FindActionMap($"GameplayP{playerIndex}"); //Assigns an action map to each player (GameplayP1 for player 1, GameplayP2 for player 2)*/

        //Finds animation objects for each player
        jumpAnimObject = GameObject.Find($"Jump animation{playerIndex}");
        boostAnimObject = GameObject.Find($"Boost animation{playerIndex}");
    }
    public void AssignIndex()
    {
        if (playerObject == "PlayerOne") { playerIndex = 0; } else if (playerObject == "PlayerTwo") { playerIndex = 1; }
    } //Gives Player 1 an index of 1 and Player 2 an index of 2
    public int GetPlayerIndex()
    {
        return playerIndex;
    }
    public void UpFlipCheck() //Checks if up arrow key held + jump (slash key) pressed 
    {
        if (inputVectorFlip.y > 0) upFlipDirection = true;
        else upFlipDirection = false;
    }
    public void DownFlipCheck()  //Checks if down arrow key held + jump (slash key) pressed 
    {
        if (inputVectorFlip.y < 0) downFlipDirection = true;
        else downFlipDirection = false;
    }
    public void Jump()
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
        else if
      ((grounded || !doubleJump) && !facingRight)
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
        if (playerIndex == 0)
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
            else if (playerIndex == 1)
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
    public void BoostOn()
    {
        isBoostPressed = true;
        Debug.Log($"Boost is {isBoostPressed}");
    }
    public void BoostOff()
    {
        isBoostPressed = false;
        Debug.Log($"Boost is {isBoostPressed}");
    }
    public void Boost()
    {
        boostAnim = boostAnimObject.GetComponent<Animator>();

        if (playerIndex == 0)
        {
            if (isBoostPressed)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * boostForce);
                boostAnim.SetBool("IsBoosting", true);
            }
            else boostAnim.SetBool("IsBoosting", false);
        }
        else if (playerIndex == 1)
        {
            if (isBoostPressed)
            {
                GetComponent<Rigidbody2D>().AddForce(-transform.right * boostForce);
                boostAnim.SetBool("IsBoosting", true);
            }
            else boostAnim.SetBool("IsBoosting", false);
        }
    }
    public void FlipCar()
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
        if (playerIndex == 0)
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * Acceleration * inputVectorAcc.y);
            }
        }
        else if (playerIndex == 1)
        {
            if (grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(-transform.right * Acceleration * inputVectorAcc.y);
            }
        }
    }
    public void Rotate()
    {
        if (!grounded)
        {
            GetComponent<Rigidbody2D>().AddTorque(rotationSpeed * -inputVectorRot.x * 5, ForceMode2D.Force);
            transform.Rotate(0, 0, -inputVectorRot.x * rotationSpeed);
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
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Restart key pressed.");

    } //Resets the scene when the "Restart" menu is pressed.
    public void EscMenu()
    {
        SceneManager.LoadScene(1);
    } //Goes back to main menu when "EscMenu" action is pressed. 
}
