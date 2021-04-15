using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class SecretBoi : MonoBehaviour
{
    public Text scoreText;
    private int currentScore;
        public Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        currentScore = 0;

    }

    private void HandleScore ()

    {
        scoreText.text = "Score: " + currentScore;
    }

    //Lis‰‰ scorea napi painalukksessa
    void TaskOnClick()
    {
        currentScore++;
        HandleScore();
    }


   
}
