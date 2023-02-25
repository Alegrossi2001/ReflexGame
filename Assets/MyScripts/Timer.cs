using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeRemaining = 30;
    public Text textTimer;
    //public static bool exitTimer ;
    

    void Update()
    {
        if(MenuManager.isGameOn = true)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                MenuManager.isGameOn = false;
            }
        }
        
           
            textTimer.text = Math.Round(timeRemaining, 1).ToString();
    }
}
