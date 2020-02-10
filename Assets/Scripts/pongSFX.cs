using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongSFX : MonoBehaviour
{

    public AudioClip ballSound;
    public AudioClip wallSound;
    public AudioClip cornerhit;
    private AudioSource test;


    void Start()
    {
        test = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.name == "playerOne" || collision.gameObject.name == "playerTwo")
            test.PlayOneShot(ballSound, 1.0f);
        if (collision.gameObject.name == "topBoarder" || collision.gameObject.name == "bottomBoarder")
            test.PlayOneShot(wallSound, 1.0f);

        if (collision.gameObject.name == "playerOne")
        {

            //player one upper half
            if (transform.position.z - collision.gameObject.transform.position.z > .2)
            {
                test.PlayOneShot(cornerhit, 1.0f);
            }

            //player one bottom half
            if (transform.position.z - collision.gameObject.transform.position.z < -.2)
            {
                test.PlayOneShot(cornerhit, 1.0f);
            }

        }

        //collision effect when ball hits player two
        if (collision.gameObject.name == "playerTwo")
        {

            //player two upper half
            if (transform.position.z - collision.gameObject.transform.position.z > .2)
            {
                test.PlayOneShot(cornerhit, 1.0f);
            }

            //player two bottom half
            if (transform.position.z - collision.gameObject.transform.position.z < -.2)
            {
                test.PlayOneShot(cornerhit, 1.0f);
            }


        }
    }
}
