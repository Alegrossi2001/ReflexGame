using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject ButtonPanelEasy;
    public GameObject ButtonPanelEay;
    public GameObject ScorePanel;
    public GameObject Startpanel;
    public Text Score;
    public Button colourButton;
    public Text colourText;
    public static bool isGameOn;
    public static int randomstart;

    // Start is called before the first frame update
    void Start()
    {
        ButtonPanelEasy.SetActive(false);
        ScorePanel.SetActive(false);
        Startpanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOn == false)
        {
            ButtonPanelEasy.SetActive(false);
            ScorePanel.SetActive(false);
            Startpanel.SetActive(true);            
        }
        Score.text = "Score: " + ButtonLightUp.score.ToString();
        
    }

    public void StartGame()
    {
        ButtonPanelEasy.SetActive(true);
        ScorePanel.SetActive(true);
        Startpanel.SetActive(false);
        ButtonLightUp.score = 0;
        Timer.timeRemaining = 30;
        isGameOn = true;
    }
}
