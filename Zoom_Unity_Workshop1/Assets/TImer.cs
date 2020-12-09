using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TImer : MonoBehaviour
{
    public int countDown = 30;
    float timer;
    public Text timerText;
    public PlayerHealth health;
    bool outOfTime;

    private void Start()
    {
        timer = Time.time + 1;
        outOfTime = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (timer < Time.time && !outOfTime)
        {

            if (countDown >0)
            {
                countDown -= 1;
                timerText.text = "Time Left: " + countDown.ToString();
            }

            if (countDown == 0)
            {
                timerText.text = "Out of Time!";
                OutOfTime();
                outOfTime = true;
            }
            timer = Time.time + 1;
        }
    }
    void OutOfTime()
    {
        //do something!
        health.playerDies();
    }
}
