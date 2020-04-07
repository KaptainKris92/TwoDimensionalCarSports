using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftScoreScript : MonoBehaviour 
{
    Animator anim;
    private bool rightScored;
    void Start () 
    {            
        anim = GetComponent<Animator>();
        rightScored = false;   
    }	
	void FixedUpdate () {
        //Gets scored boolean value from RightTriggerScript.cs
        GameObject TriggerRight = GameObject.Find("TriggerRight");
        RightTriggerScript rightTriggerScript = TriggerRight.GetComponent<RightTriggerScript>();
        rightScored = rightTriggerScript.scoredR;

        if (rightScored)
        {
            anim.SetBool("Goalscore", true);
        }
	}
}
