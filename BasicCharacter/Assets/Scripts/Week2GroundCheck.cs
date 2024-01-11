using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2GroundCheck : MonoBehaviour
{
     public bool amIOnTheGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
       {
        amIOnTheGround=true;
       }

       private void OnTriggerExist(Collider other)
       {
        amIOnTheGround=false;
       }
}
