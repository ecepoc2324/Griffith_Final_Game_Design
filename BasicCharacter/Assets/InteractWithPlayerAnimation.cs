using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithPlayerAnimation : MonoBehaviour
{
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
      myAnimator=GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag =="Player" )
      {
        myAnimator.SetBool("playerIsHere",true);
      }  
    }

     private void OnTriggerExit(Collider other)
    {
       if(other.gameObject.tag=="Player")
      {
         myAnimator.SetBool("playerIsHere",false);
      }  
    } 

}
