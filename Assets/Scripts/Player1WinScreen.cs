using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1WinScreen : MonoBehaviour {

    Animator anim;
    private bool rightScored;
    private float rightScoreCount=0;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rightScored = false;
     
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //Gets scored boolean value from RightTriggerScript.cs
        GameObject TriggerRight = GameObject.Find("TriggerRight");
        RightTriggerScript rightTriggerScript = TriggerRight.GetComponent<RightTriggerScript>();
        rightScored = rightTriggerScript.scoredR;

        if (rightScored)
        {
            rightScoreCount = rightScoreCount + 1;
            rightScored = false;
            
            
        }

        if (rightScoreCount == 11)
        {
            anim.SetBool("FinalGoalScored", true);
        }

    }
}
