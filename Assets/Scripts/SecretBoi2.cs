using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class SecretBoi2 : MonoBehaviour
{
    public Text scoreText;
    private int currentScore;
    public Button buttonUP;
    public Button buttonDOWN;
    public Button buttonLEFT;
    public Button buttonRight;


    // Start is called before the first frame update
    void Start()
    {
        Button btn1 = buttonDOWN.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
        
        Button btn2 = buttonUP.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick);
        
        Button btn3 = buttonLEFT.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick);
        
        Button btn4 = buttonRight.GetComponent<Button>();
        btn4.onClick.AddListener(TaskOnClick);
        
        currentScore = 0;

    }

    private void HandleScore ()

    {
        scoreText.text = "Score: " + currentScore;
    }

    //Lis‰‰ scorea napi painalukksessa
    void TaskOnClick()
    {
        
    }


   
}
