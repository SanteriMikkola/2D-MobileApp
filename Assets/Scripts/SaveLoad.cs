using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveLoad : MonoBehaviour
{
    public string MuistutusText;
    public GameObject ournote;
    public GameObject placeholder;
    public Text Tallennus;
    // Start is called before the first frame update
    void Start()
    {

        MuistutusText = PlayerPrefs.GetString("NoteContents");
    placeholder.GetComponent<InputField>().text = MuistutusText;
        
            }

    void Update()
    {
        Tallennus.text = MuistutusText;
    }


    public void SaveNote()

    {
        MuistutusText = ournote.GetComponent<Text>().text;
        PlayerPrefs.SetString("NoteContents", MuistutusText);
    }
}
