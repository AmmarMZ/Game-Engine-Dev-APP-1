using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static Text scoreText;
    bool isDone;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.gameObject.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        if (TargetScript.totalShots == 11) {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            if (ScoreScript.score > 0) {
                scoreText.text = "Winner! You scored " + ScoreScript.score + " points";
            }
            else {
                scoreText.text = "Loser! You scored " + ScoreScript.score + " points";
            }
            return;
        } 
    }
}
