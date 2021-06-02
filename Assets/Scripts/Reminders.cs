using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Reminders : MonoBehaviour
{
    public GameObject TextYear;
    public GameObject TextMonth;
    public GameObject TextDay;
    public GameObject TextClock;

    public GameObject TulevatTeksti;

    public Button AcceptButton;

    private void Start()
    {
        Button btn = AcceptButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        TextYear.SetActive(true);
        TextMonth.SetActive(true);
        TextDay.SetActive(true);
        TextClock.SetActive(true);
        TulevatTeksti.SetActive(true);
    }
}
