using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Reset : MonoBehaviour
{
    Vector3 originalPosP1;
    Quaternion originalRotP1;

    public bool rightScored;
    public bool leftScored;
    void Start()
    {
        originalPosP1 = gameObject.transform.position;
        originalRotP1 = gameObject.transform.rotation;
    }
    void FixedUpdate()
    {
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
            rightScored = false;
        }
        if (leftScored)
        {
            StartCoroutine(SecondWait2());
            leftScored = false;
        }
    }
    private IEnumerator SecondWait()
    {
        yield return new WaitForSeconds(3f);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
        gameObject.transform.position = originalPosP1;
        gameObject.transform.rotation = originalRotP1;

        rightScored = false;
    }
    private IEnumerator SecondWait2()
    {
        yield return new WaitForSeconds(3f);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
        gameObject.transform.position = originalPosP1;
        gameObject.transform.rotation = originalRotP1;

        leftScored = false;
    }
}
