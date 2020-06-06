using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScore : MonoBehaviour
{
    public Text timerText;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "" + ScoringSystem.theScore;

        string minutes = Timer.totMinutes.ToString();
        string seconds = Timer.totSeconds.ToString("f2");

        timerText.text = "TIMER: " + minutes + ":" + seconds;

    }
}
