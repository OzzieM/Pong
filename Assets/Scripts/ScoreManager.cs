using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text p1;
    public Text p2;

    Color c1 = new Color(0.0f, 0.8f, 1.0f);
    Color c2 = new Color(0.0f, 1.0f, 0.7f);

    //Triggers t = new Triggers();
    //Since score is already being kept in the Trigger script for debugging all we 
    //need to do is retrieve the scores from the script
    void Update()
    {
        
        if (Triggers.playerOneScore > Triggers.playerTwoScore)
        {
            p1.color = c1;
            p2.color = c1;
            p1.text = Triggers.playerOneScore.ToString();
            p2.text = Triggers.playerTwoScore.ToString();
        }
        else if (Triggers.playerOneScore < Triggers.playerTwoScore)
        {
            p1.color = c2;
            p2.color = c2;
            p1.text = Triggers.playerOneScore.ToString();
            p2.text = Triggers.playerTwoScore.ToString();
        }
        else 
        {
            p1.color = c1;
            p2.color = c2;
            p1.text = Triggers.playerOneScore.ToString();
            p2.text = Triggers.playerTwoScore.ToString();
        }
        
    }
}
