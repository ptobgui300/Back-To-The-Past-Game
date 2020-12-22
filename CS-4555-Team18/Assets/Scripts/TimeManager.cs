using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeLimit = 120;
    public AudioSource clock;
    private float timeRemaining;
    float minutes;
    float seconds;
    public bool timerIsRunning = false;
    HealthManager hm;
    

    void Start()
    {
        timeRemaining = timeLimit;
        DisplayTime(timeLimit);
        timerIsRunning = false;
        
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if(timeRemaining > 0)
            {
                if (!clock.isPlaying)
                {
                    clock.Play();
                }
                
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timerText.SetText("00:00");
                clock.Stop();
                timerIsRunning = false;
                timeRemaining = timeLimit;
                hm.Damage(1);
            }
        }
    }

    void triggerTimer()
    {
        timerIsRunning = true;
    }

    void DisplayTime(float timeToDisplay)
    {
        minutes = Mathf.FloorToInt(timeRemaining / 60);
        seconds = timeRemaining % 60;
        timerText.SetText(string.Format("{0:00}:{1:00.00}", minutes, seconds));
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(timerIsRunning == false)
            {
                triggerTimer();
                hm = other.GetComponent<HealthManager>();
            }
            
        }
    }

}
