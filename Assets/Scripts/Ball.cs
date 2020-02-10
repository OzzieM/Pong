using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    ForceMode forceMode;
    //float amplify = 1f;
    float incrementSpeed = 1f;

    float ballspeed = 2.5f;
    Rigidbody rb;

    private void Start()
    {
        //when pong starts, serves ball
        rb = GetComponent<Rigidbody>();
        float rand = Random.Range(0, 2);
        int serveZ = Random.Range(0, 2) == 0 ? -1 : 1;
        //Debug.Log(serveZ);

        if (rand == 0) // serve to player one
        {
            rb.velocity = new Vector3(-2f * ballspeed, 0f, serveZ * ballspeed +(2 * serveZ));
        }
        else //serve to player two
        {
            rb.velocity = new Vector3(2f * ballspeed, 0f, serveZ * ballspeed + (2*serveZ));
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        rb = GetComponent<Rigidbody>();

        //collision effect when ball hits player one
        if (collision.gameObject.name == "playerOne")
        {
         
            //player one upper half
            if(transform.position.z - collision.gameObject.transform.position.z > .2)
            {
                rb.velocity = new Vector3(2f * incrementSpeed, 0f, 2f);
                if (incrementSpeed < 4f) //breaks after incrementSpeed passes 15
                    incrementSpeed += .5f;
            }
            //player one middle
            if (transform.position.z - collision.gameObject.transform.position.z > -.2 && transform.position.z - collision.gameObject.transform.position.z < .2)
            {
                rb.velocity = new Vector3(2f * incrementSpeed, 0f, 0f);
                if (incrementSpeed < 4f) 
                    incrementSpeed += .5f;
            }
            //player one bottom half
            if (transform.position.z - collision.gameObject.transform.position.z < -.2)
            {
                rb.velocity = new Vector3(2f * incrementSpeed, 0f, -2f);
                if (incrementSpeed < 4f)
                    incrementSpeed += .5f;
            }
           
        }

        //collision effect when ball hits player two
        if (collision.gameObject.name == "playerTwo")
        {

            //player two upper half
            if (transform.position.z - collision.gameObject.transform.position.z > .2)
            {
                rb.velocity = new Vector3(-2f * incrementSpeed, 0f, 2f);
                if (incrementSpeed < 4f) //breaks after incrementSpeed passes 15
                    incrementSpeed += .5f;
            }
            //player two middle
            if (transform.position.z - collision.gameObject.transform.position.z > -.2 && transform.position.z - collision.gameObject.transform.position.z < .2)
            {
                rb.velocity = new Vector3(-2f * incrementSpeed, 0f, 0f);
                if (incrementSpeed < 4f)
                    incrementSpeed += .5f;
            }
            //player two bottom half
            if (transform.position.z - collision.gameObject.transform.position.z < -.2)
            {
                rb.velocity = new Vector3(-2f * incrementSpeed, 0f, -2f);
                if (incrementSpeed < 4f)
                    incrementSpeed += .5f;                    
            }
        }

        //collision effect when ball hits top boarder
        if (collision.gameObject.name == "topBoarder")
        {
            //rb.velocity = new Vector3(rb.velocity.x , 0f, -2f);

            if (rb.velocity.x < 0f)
            {
                //Debug.Log(rb.velocity.x);
                rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.x );
            }
            if (rb.velocity.x > 0)
            {
                //Debug.Log(rb.velocity.x);
                rb.velocity = new Vector3(rb.velocity.x * 1f, 0f, rb.velocity.x * -1f);
            }
        }

        //collision effect when ball hits bottom boarder
        if (collision.gameObject.name == "bottomBoarder")
        {
            if(rb.velocity.x < 0f)
            {
                //Debug.Log(rb.velocity.x);
                rb.velocity = new Vector3(rb.velocity.x , 0f, rb.velocity.x * -1f);
            }
            if (rb.velocity.x > 0)
            {
                //Debug.Log(rb.velocity.x);
                rb.velocity = new Vector3(rb.velocity.x * 1f, 0f, rb.velocity.x * 1f);
            }

        }



    }
}
