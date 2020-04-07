using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2WinScreen : MonoBehaviour
{

    Animator anim;
    private bool leftScored;
    private float leftScoreCount = 0;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        leftScored = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Gets scored boolean value from LeftTriggerScript.cs
        GameObject TriggerLeft = GameObject.Find("TriggerLeft");
        LeftTriggerScript leftTriggerScript = TriggerLeft.GetComponent<LeftTriggerScript>();
        leftScored = leftTriggerScript.scoredL;

        if (leftScored)
        {
            leftScoreCount = leftScoreCount + 1;
            leftScored = false;


        }

        if (leftScoreCount == 11)
        {
            
            anim.SetBool("FinalGoalScored", true);
        }

       
    }

    //private IEnumerator ScoredR()
    //{

    //    yield return new WaitForSeconds(3f);
    //    leftScoreCount = leftScoreCount + 1;
    //    leftScored = false;

    //}

    //private IEnumerator ScoredR2()
    //{
    //    yield return new WaitForSeconds(3f);
    //    anim.SetBool("FinalGoalScored", true);



    //}
}
