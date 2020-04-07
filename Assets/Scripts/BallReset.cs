using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour {

    Vector3 originalPosP1;
    
    

    private bool rightScored;
    private bool leftScored;
   

    




// Use this for initialization
void Start () {
       
    originalPosP1 = gameObject.transform.position;

    
}
	
	// Update is called once per frame
	void FixedUpdate () {

        //Gets scored boolean value from RightTriggerScript.cs
        GameObject TriggerRight = GameObject.Find("TriggerRight");
        RightTriggerScript rightTriggerScript = TriggerRight.GetComponent<RightTriggerScript>();
        rightScored = rightTriggerScript.scoredR;
        //Gets scored boolean value from LeftTriggerScript.cs
        GameObject TriggerLeft = GameObject.Find("TriggerLeft");
        LeftTriggerScript leftTriggerScript = TriggerLeft.GetComponent<LeftTriggerScript>();
        leftScored = leftTriggerScript.scoredL;



        if (rightScored)
        {
            StartCoroutine(SecondWait());
            //GetComponent<Rigidbody2D>().velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
            //gameObject.transform.position = originalPosP1;
            //GetComponent<Rigidbody2D>().angularVelocity = 0;
            
       

            //rightScored = false;
        }

        if (leftScored)
        {
            StartCoroutine(SecondWait());
            //GetComponent<Rigidbody2D>().velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
            //gameObject.transform.position = originalPosP1;
            //GetComponent<Rigidbody2D>().angularVelocity = 0;


            //leftScored = false;
        }


	}

    private IEnumerator SecondWait()
    {
        yield return new WaitForSeconds(3f);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
        gameObject.transform.position = originalPosP1;
        GetComponent<Rigidbody2D>().angularVelocity = 0;



        rightScored = false;
        
    }

    private IEnumerator SecondWait2()
    {
        yield return new WaitForSeconds(3f);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
        gameObject.transform.position = originalPosP1;
        GetComponent<Rigidbody2D>().angularVelocity = 0;



        leftScored = false;

    }
}
