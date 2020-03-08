using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    UnityEvent goalReached = new UnityEvent();
    Clock timer = new Clock(0, 0, 0);
    Clock goal;

    public UnityEvent GoalReached
    {
        get
        {
            return goalReached;
        }
    }

    void Start()
    {
        SetGoal(0, 10, 0);
    }

    // Update is called once per frame
    public void Update()
    {
        //check to see if a goal has been set
        if (goal != null)
        {
            timer.Update();

            //check if goal has been reached
            if ((timer.Minutes >= goal.Minutes) && (timer.Seconds >= goal.Seconds) && (timer.MiliSeconds >= goal.MiliSeconds))
            {
                timer.Reset();
                goalReached.Invoke();
            }

        }

    }

    public void SetGoal(int minutes, int seconds, int miliseconds)
    {
        goal = new Clock(minutes, seconds, miliseconds);
    }

}

public class Clock
{

    private float seconds = 0;
    private int minutes = 0;
    private float miliseconds = 0;

    public float Seconds
    {
        get
        {
            return seconds;
        }

        private set
        {
            seconds = value;

            if (seconds >= 60.0)
            {
                minutes += 1;
                seconds = 0;
            }
        }
    }

    public float MiliSeconds
    {
        get
        {

            return miliseconds;
        }

        private set
        {
            miliseconds = value;

            if (miliseconds >= 1000)
            {
                seconds += 1;
                miliseconds = 0;
            }
        }
    }

    public int Minutes
    {
        get
        {
            return minutes;
        }
    }

    public Clock(int min, int seconds, int miliseconds)
    {
        this.seconds = seconds;
        minutes = min;
        this.miliseconds = miliseconds;
    }

    public void Update()
    {
        MiliSeconds += Time.deltaTime * 1000;
        //Debug.Log(ToString());


    }

    public void Reset()
    {
        minutes = 0;
        seconds = 0;
        miliseconds = 0;
    }

    public override string ToString()
    {
        return $" {minutes} :  {Mathf.FloorToInt(seconds)} : {Mathf.FloorToInt(miliseconds)}";
    }


}