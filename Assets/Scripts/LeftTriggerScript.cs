using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTriggerScript : MonoBehaviour { 

    public bool scoredL = false;
    public RightTriggerScript RD; // Not sure if needed
    public GameObject RightTrigger;
    public GameObject LeftTrigger;
    public BoxCollider2D RBox;
    public BoxCollider2D LBox;

    private void Awake()
    {
        RD = GetComponent<RightTriggerScript>(); // Not sure if needed
        RightTrigger = GameObject.Find("TriggerRight");
        LeftTrigger = GameObject.Find("TriggerLeft");
        RBox = RightTrigger.GetComponent<BoxCollider2D>();
        LBox = LeftTrigger.GetComponent<BoxCollider2D>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(ScoredL());
    }
    public void OnTriggerExit2D(Collider2D other)
    {
    }
    private IEnumerator ScoredL()
    {
        scoredL = !scoredL;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(0.01f);
        scoredL = !scoredL;
        RBox.enabled = false;
        yield return new WaitForSeconds(3f);
        GetComponent<BoxCollider2D>().enabled = true;
        RBox.enabled = true;
    }
}
