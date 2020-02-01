using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour
{
    public Transform playerOne;
    public Transform playerTwo;
    public float movespeed = 10f;



    

    // Update is called once per frame
    void Update()
    {
        //playerOne Movement
        if (Input.GetKey(KeyCode.A))
        {
            playerOne.transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerOne.transform.Translate(Vector3.back * movespeed * Time.deltaTime);
        }
        //playerTwo Movement
        if (Input.GetKey(KeyCode.J))
        {
            playerTwo.transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            playerTwo.transform.Translate(Vector3.back * movespeed * Time.deltaTime);
        }
    }

    [SerializeField] [Range(0, 100)] private float amplify = 1;
    public ForceMode forceMode;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (collision.gameObject.tag == "TeamA")
        {
            rb.AddForce(Vector3.up * amplify, forceMode);
        }

        if (collision.gameObject.tag == "TeamB")
        {
            Vector3 launchAngle = new Vector3(6, 0, 0) * amplify * 100;
            rb.AddForce(launchAngle, forceMode);
        }
        //Debug.Log(gameObject.name + " hit me");
    }

    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        //Debug.Log(collision.gameObject.name + " left me");
    }
}
