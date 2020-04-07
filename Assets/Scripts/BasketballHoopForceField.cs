using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballHoopForceField : MonoBehaviour
{
    Animator anim;
    public void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(SecondWait());
    } 
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Touched", false);
    }    
    public IEnumerator SecondWait()
    {
        anim.SetBool("Touched", true);
        yield return new WaitForSeconds(1f);
        anim.SetBool("Touched", false);
    }
}
