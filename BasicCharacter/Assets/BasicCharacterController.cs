using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacterController : MonoBehaviour
{
    public float moveForce;
    public float maxSpeed;
    private Rigidbody playerRigidbody;
    public GameObject child;
    public float rotateSpeed;
    public float rotationSensitivity;

    public float jumpForce;
    public GameObject groundcheck;
    public Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
       playerRigidbody=gameObject.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(playerRigidbody.velocity.magnitude)<maxSpeed)
        {
        playerRigidbody.AddForce( (Input.GetAxis("Horizontal")*moveForce), 0, (Input.GetAxis("Vertical")*moveForce));
        }

        Vector3 moveDirection=new Vector3(playerRigidbody.velocity.x,0,playerRigidbody.velocity.z);
        if(moveDirection.magnitude>rotationSensitivity)
        {
            child.transform.rotation=Quaternion.Slerp(child.transform.rotation, Quaternion.LookRotation(moveDirection), Time.deltaTime*rotateSpeed);
        }
        
        if(Input.GetButtonDown("Jump") && groundcheck.GetComponent<Exercise2GroundCheck>().amIOnTheGround==true)
        {
            playerRigidbody.AddForce(0,jumpForce,0);
        }
      
      playerAnimator.SetFloat("speed",moveDirection.magnitude);
      playerAnimator.SetFloat("verticalSpeed",playerRigidbody.velocity.y);
      playerAnimator.SetBool("amIGrounded",groundcheck.GetComponent<Exercise2GroundCheck>().amIOnTheGround);
    }
}
