using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    private float JumpSpeed = 5;
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) 
        {
            rigidBody.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
          
        }
    }
}
