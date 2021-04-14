using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    GameObject MuistutusText;
    public GameObject MyText;
    private string input;
    Text ourComponent;
    // Start is called before the first frame update
    void Start()
    {
        
        MuistutusText = (MyText);
        ourComponent = MuistutusText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ourComponent.text = input;
    }

    // Lukee tiedot käyttäjältä
    public void ReadStringInput(string s){
        input = s;
        Debug.Log(input);
    }





}
