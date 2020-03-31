using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Jump : MonoBehaviour
{

  




    Rigidbody player;
    private float jumpForce = 10f;
    private bool onGround;

    //extra jump
    
    void Start()
    {
  
        //grabs the Rigidbody from the player
        player = GetComponent<Rigidbody>();
        //says that the player is on the ground at runtime
        onGround = true;
    }


    //SCORE
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PointZone"))
        {
            ScoreManager.instance.AddScore();

        }
        if (other.tag == "Car")
        {
            SceneManager.LoadScene("GameOver");
        }
    }


    void Update()
    {

        if (Input.GetButton("Jump") && onGround == true)
        {

            //adds force to player on the y axis by using the flaot set for the variable jumpForce. Causes the player to jump
            player.velocity = new Vector3(0f, jumpForce, 0f);
            //says the player is no longer on the ground
            onGround = false;


         
            }
    
   

    }        void OnCollisionEnter(Collision other)
    {
        //checks if collider is tagged "ground"
        if (other.gameObject.CompareTag("ground"))
        {
            //if the collider is tagged "ground", sets onGround boolean to true
            onGround = true;
       

        }

        {
            player.velocity = Vector3.up * jumpForce;
        



        }
       
    }
       

        }
    

