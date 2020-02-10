using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggers : MonoBehaviour
{


    Vector3 startPos;
    public static int playerOneScore = 0;
    public static int playerTwoScore = 0;

    public int getScoreOne()
    {
        return playerOneScore;
    }
    public int getScoreTwo()
    {
        return playerTwoScore;
    }
    private void Start()
    {
        startPos = new Vector3(0f,.4f,0f);
    }
    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        //keeps track of player two's score
        if(other.gameObject.tag == "pongball" && gameObject.name == "leftBoarder")
        {
            
            playerTwoScore++;
            //Debug.Log("SCORE : " + playerOneScore + " |  " + playerTwoScore);

            if (playerTwoScore == 11)
            {
                //Time.timeScale = 0;
                //Debug.Log("Game Over, Right Paddle Wins");
                   playerOneScore = 0;
                   playerTwoScore = 0;

                int serveZ = Random.Range(0, 2) == 0 ? -1 : 1;
                rb.velocity = Vector3.zero;
                rb.Sleep();
                other.gameObject.transform.position = startPos;
                rb.velocity = new Vector3(-2f * 2f, 0f, serveZ * 2f + (2 * serveZ));
            }
            else
            {
                //Debug.Log("Ball hit " + gameObject.name);     
                int serveZ = Random.Range(0, 2) == 0 ? -1 : 1;
                rb.velocity = Vector3.zero;
                rb.Sleep();
                other.gameObject.transform.position = startPos;
                rb.velocity = new Vector3(-2f * 2f, 0f, serveZ * 2f + (2 * serveZ));
            }
        }
        // keeps track of player ones score 
        if (other.gameObject.tag == "pongball" && gameObject.name == "rightBoarder")
        {
            playerOneScore++;
            //Debug.Log("SCORE : " + playerOneScore + " |  " + playerTwoScore);
            
            if (playerOneScore == 11)
            {
                //Debug.Log("Game Over, Left Paddle Wins");
                //Time.timeScale = 0;
                playerOneScore = 0;
                playerTwoScore = 0;

                int serveZ = Random.Range(0, 2) == 0 ? -1 : 1;
                rb.velocity = Vector3.zero;
                rb.Sleep();
                other.gameObject.transform.position = startPos;
                rb.velocity = new Vector3(2f * 2f, 0f, serveZ * 2f + (2 * serveZ));
            }
            else
            {
                //Debug.Log("Ball hit " + gameObject.name);

                //rb = GetComponent<Rigidbody>();
                int serveZ = Random.Range(0, 2) == 0 ? -1 : 1;
                rb.velocity = Vector3.zero;
                rb.Sleep();
                other.gameObject.transform.position = startPos;
                rb.velocity = new Vector3(2f * 2f, 0f, serveZ * 2f + (2 * serveZ));
                  
                
            }
        }
    }
}
