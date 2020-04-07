using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTriggerScript : MonoBehaviour {

    public bool scoredR = false;
    public LeftTriggerScript LD; // Not sure if needed
    public GameObject LeftTrigger;
    public BoxCollider2D LBox;

    private void Awake()
    {
        LD = GetComponent<LeftTriggerScript>(); // Not sure if needed
        LeftTrigger = GameObject.Find("TriggerLeft");
        LBox = LeftTrigger.GetComponent<BoxCollider2D>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(ScoredR());   
    }

    public void OnTriggerExit2D(Collider2D other)
    {
    }
    private IEnumerator ScoredR()
    {
        scoredR = !scoredR;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(0.01f);
        scoredR = !scoredR;
        LBox.enabled = false;
        yield return new WaitForSeconds(3f);
        GetComponent<BoxCollider2D>().enabled = true;
        LBox.enabled = true;
     }


  
}
