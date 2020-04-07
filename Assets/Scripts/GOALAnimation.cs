using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOALAnimation : MonoBehaviour {

    Animator anim;
    
    private bool leftScored;
    private bool rightScored; 




    
    void Start () {
        anim = GetComponent<Animator>();
        leftScored = false;
        rightScored = false;
    }
	
	
	void FixedUpdate () {

        //Gets scored boolean value from LeftTriggerScript.cs
        GameObject TriggerLeft = GameObject.Find("TriggerLeft");
        LeftTriggerScript leftTriggerScript = TriggerLeft.GetComponent<LeftTriggerScript>();
        leftScored = leftTriggerScript.scoredL;

        //Gets scored boolean value from RightTriggerScript.cs
        GameObject TriggerRight = GameObject.Find("TriggerRight");
        RightTriggerScript rightTriggerScript = TriggerRight.GetComponent<RightTriggerScript>();
        rightScored = rightTriggerScript.scoredR;

        if (leftScored || rightScored)
        {

            StartCoroutine(SecondWait());
                      

        }

    

    }

    private IEnumerator SecondWait()
    {
        anim.SetBool("AnyScored", true);
        leftScored = false;
        rightScored = false;
        yield return new WaitForSeconds(3f);
        anim.SetBool("AnyScored", false);
    }
}
