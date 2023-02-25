using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLightUp : MonoBehaviour
{
    public Button[] buttonList = new Button[24];
    private bool[] canBePressed = new bool[24];
    public static int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
        canBePressed[0] = true;
        buttonList[0].GetComponent<Image>().color = Color.red;
        ButtonOnClick(0);


    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
    public void ButtonOnClick(int assignedValue)
    {
        if (MenuManager.isGameOn == true)
        {
            if (canBePressed[assignedValue] == true)
            {
                buttonList[assignedValue].GetComponent<Image>().color = Color.white;
                canBePressed[assignedValue] = false;
                score++;
                //create new random button to press
                int randomIndex = UnityEngine.Random.Range(0, buttonList.Length);
                UnityEngine.Debug.Log(randomIndex);
                buttonList[randomIndex].GetComponent<Image>().color = Color.red;
                canBePressed[randomIndex] = true;

            }
            else if (canBePressed[assignedValue] == false)
            {
                score--;
            }
        }


        
    }
}
