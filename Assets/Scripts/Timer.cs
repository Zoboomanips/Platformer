using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public UnityEngine.UI.Text timerText;
    private float startTime;
    public float endTime;
    string seconds;
    string minutes;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        Transform timer = transform.Find("Timer");
        timerText = timer.GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float t = endTime - (Time.time - startTime);

        minutes = ((int)t / 60).ToString();
        // Conditional to add extra zero if seconds are below 10
        if (float.Parse((t % 60).ToString("f2")) >= 10)
        {
            seconds = (t % 60).ToString("f2");
        }
        else
        {
            seconds = "0" + (t % 60).ToString("f2");
        }

        // If time is above zero display, otherwise stop timer
        if ((t % 60) >= 0)
        {
            timerText.text = minutes + ":" + seconds;
        }
    }
}
