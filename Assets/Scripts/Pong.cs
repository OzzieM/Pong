using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour
{
    public Transform playerOne;
    public Transform playerTwo;
    public float movespeed = 10f;
    public float ballspeed = 1f;


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("playerOne"))
        {
            playerOne.transform.Translate(Input.GetAxisRaw("playerOne") * movespeed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetButton("playerTwo"))
        {
            playerTwo.transform.Translate(Input.GetAxisRaw("playerTwo") * movespeed * Time.deltaTime, 0f, 0f);
        }

        //playerOne Movement
        //playerTwo Movement
        //if (Input.GetKey(KeyCode.A))
        //{
        //    playerOne.transform.Translate(Vector3.left * movespeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    playerOne.transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        //}

        //playerTwo Movement
        //if (Input.GetKey(KeyCode.J))
        //{
        //    playerTwo.transform.Translate(Vector3.left * movespeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.L))
        //{
        //    playerTwo.transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        //}



    }

    [SerializeField] [Range(0, 100)] private float amplify = 1;
    public ForceMode forceMode;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        //int x = -1;

        //if (collision.gameObject.name == "topBoarder")
        //{
        //    Vector3 launchAngle = new Vector3(6, 0, 0) * amplify * 25;
        //    rb.AddForce(launchAngle, forceMode);
        //    launchAngle = launchAngle * x;
        //    Debug.Log(gameObject.name + " hit me");
        //}
        //Debug.Log(gameObject.name + " hit me");

    }

    private void OnCollisionExit(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        
    }
}
