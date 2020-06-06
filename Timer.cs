using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;

    public static float totMinutes;
    public static float totSeconds;

    public static float totalTime;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }


    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        totMinutes = ((int)t / 60);
        totSeconds = ((t % 60));

        string minutes = totMinutes.ToString();
        string seconds = totSeconds.ToString("f2");

        timerText.text = "TIMER: " + minutes + ":" + seconds;
    }
}