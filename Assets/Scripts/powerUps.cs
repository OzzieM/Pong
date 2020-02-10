using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUps : MonoBehaviour
{
    public MeshRenderer m;
    public SphereCollider p4;
    public GameObject mTest;
    //GameObject currentPlayer;
    float timer;
    Time testTime;
    static string playerTracker;
    static bool tf = true;


    // Update is called once per frame
    void Update()
    {
        //activates the first power up when one of the players reach a score of 3
        if (Triggers.playerOneScore == 3 && tf == true || Triggers.playerTwoScore == 3 && tf == true)
        {
            mTest.SetActive(true);
        }

        if (Triggers.playerOneScore == 6 || Triggers.playerTwoScore == 6)
        {
            m.enabled = true;
            p4.enabled = true;
        }

        if(Triggers.playerOneScore == 0 && Triggers.playerTwoScore == 0)
        {
            tf = true;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "playerOne" || collision.gameObject.name == "playerTwo")
            playerTracker = collision.gameObject.name;
        //Debug.Log(playerTracker);
    }

    void OnTriggerEnter(Collider other)
    {
        //Collision p = new Collision();
        if(other.gameObject.name == "power1")
        {
           
            //Debug.Log(p.gameObject.name);
            tf = false;
            other.gameObject.SetActive(false);
            gameObject.transform.localScale = new Vector3(.1f, .1f, .1f);
        }

        if(other.gameObject.name == "power4")
        {
            other.gameObject.SetActive(false);
            GameObject.Find(playerTracker).transform.localScale = new Vector3(1.3f, 0.5f, 0.2f);   
        }
    }
}
