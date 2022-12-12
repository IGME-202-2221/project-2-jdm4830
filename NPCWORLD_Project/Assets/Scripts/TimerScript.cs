/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float remainTime;
    public bool timerOn = false;

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timerOn)
        {
            if(remainTime > 0)
            {
                remainTime -= Time.deltaTime;
                updateTimer(remainTime);
            }
            else
            {
                Debug.Log("Time is UP!");
                remainTime = 0;
                timerOn = false;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float min = Mathf.FloorToInt(currentTime / 60);
        float sec = Mathf.FloorToInt(currentTime % 60);

        timerText.Text = string.Format("{0:00 : {1:00}", min, sec);
    }
}
*/
