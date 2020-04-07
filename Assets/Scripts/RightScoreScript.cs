using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightScoreScript : MonoBehaviour
{
    Animator anim;
    private bool leftScored;
    void Start()
    {
        anim = GetComponent<Animator>();
        leftScored = false;
    }
    void FixedUpdate()
    {
        //Gets scored boolean value from LeftTriggerScript.cs
        GameObject TriggerLeft = GameObject.Find("TriggerLeft");
        LeftTriggerScript leftTriggerScript = TriggerLeft.GetComponent<LeftTriggerScript>();
        leftScored = leftTriggerScript.scoredL;


        if (leftScored)
        {
            anim.SetBool("Goalscore", true);
        }
    }
}
