using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KuukausiArvot : MonoBehaviour
{
    private int kuukausi;
    private string kuukaudenNimi;

    public class Day
    {
        public int DayNum;
        public GameObject Obj;
        public Color dayColor;

        public Day (int DayNum, Color dayColor, GameObject Obj)
        {
            this.DayNum = DayNum;
            this.Obj = Obj;
            UpdateColor(dayColor);
            UpdateDay(DayNum);
        }

        public void UpdateColor(Color newColor)
        {
            Obj.GetComponent<Image>().color = newColor;
            dayColor = newColor;
        }

        public void UpdateDay(int newDayNum)
        {
            this.DayNum = newDayNum;
            if (dayColor == Color.white)
            {
                Obj.GetComponentInChildren<Text>().text = (DayNum + 1).ToString();
            }
            else
            {
                Obj.GetComponentInChildren<Text>().text = "";
            }
        }
        
    }

    private readonly List<Day> Days = new List<Day>();

    public Transform[] weeks;

    public DateTime currentDate = DateTime.Now;

    void Start()
    {
        UpdateCalendar(DateTime.Now.Year, DateTime.Now.Month);
    }
    
    void UpdateCalendar(int year, int month)
    {
        DateTime date = new DateTime(year, month, 1);


        currentDate = date;
        int startDay = GetMonthStartDay(year, month);
        int endDay = GetTotalNumberOfDays(year, month);

        if(Days.Count == 0)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int a = 0; a < 7; a++)
                {
                    Day newDay;

                    int currDay = (i * 7) + a;

                    if (currDay < startDay || currDay - startDay >= endDay)
                    {
                        newDay = new Day(currDay - startDay, Color.grey, weeks[i].GetChild(a).gameObject);
                    }
                    else
                    {
                        newDay = new Day(currDay - startDay, Color.white, weeks[i].GetChild(a).gameObject);
                    }

                    Days.Add(newDay);
                }
            }
        }

        else
        {
            for (int b = 0; b < 42; b++)
            {
                if (b < startDay || b - startDay >= endDay)
                {
                    Days[b].UpdateColor(Color.grey);
                }
                else
                {
                    Days[b].UpdateColor(Color.white);
                }
                Days[b].UpdateDay(b - startDay);
            }
        }

        if (DateTime.Now.Year == year && DateTime.Now.Month == month)
        {
            Days[(DateTime.Now.Day - 1) + startDay].UpdateColor(Color.green);
        }
    }

    int GetMonthStartDay(int year, int month)
    {
        DateTime temp = new DateTime(year, month, 1);

        //DayOfWeek Monday == 0;

        return (int)temp.DayOfWeek;
    }

    int GetTotalNumberOfDays(int year, int month)
    {
        return DateTime.DaysInMonth(year, month);
    }

    public void SwitchMonth(int direction)
    {
        if (direction == 1)
        {
            currentDate = currentDate.AddMonths(1);
        }
        else if (direction == 2)
        {
            currentDate = currentDate.AddMonths(2);
        }
        else if (direction == 3)
        {
            currentDate = currentDate.AddMonths(3);
        }
        else if (direction == 4)
        {
            currentDate = currentDate.AddMonths(4);
        }
        else if (direction == 5)
        {
            currentDate = currentDate.AddMonths(5);
        }
        else if (direction == 6)
        {
            currentDate = currentDate.AddMonths(6);
        }
        else if (direction == 7)
        {
            currentDate = currentDate.AddMonths(7);
        }
        else if (direction == 8)
        {
            currentDate = currentDate.AddMonths(8);
        }
        else if (direction == 9)
        {
            currentDate = currentDate.AddMonths(9);
        }
        else if (direction == 10)
        {
            currentDate = currentDate.AddMonths(10);
        }
        else if (direction == 11)
        {
            currentDate = currentDate.AddMonths(11);
        }
        else if (direction == 12)
        {
            currentDate = currentDate.AddMonths(12);
        }
        else
        {
            Debug.LogError("Unity.exe lakkasi toiminnasta");
        }

        UpdateCalendar(currentDate.Year, currentDate.Month);
    }

    public void Tammikuu()
    {
        kuukausi = 1;
        kuukaudenNimi = kuukausi.ToString("Tammikuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(1);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);
        Days.Add(31);*/
    }

    public void Helmikuu()
    {
        kuukausi = 2;
        kuukaudenNimi = kuukausi.ToString("Helmikuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(2);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);*/
    }

    public void Maaliskuu()
    {
        kuukausi = 3;
        kuukaudenNimi = kuukausi.ToString("Maaliskuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(3);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);
        Days.Add(31);*/
    }

    public void Huhtikuu()
    {
        kuukausi = 4;
        kuukaudenNimi = kuukausi.ToString("Huhtikuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(4);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);*/
    }

    public void Toukokuu()
    {
        kuukausi = 5;
        kuukaudenNimi = kuukausi.ToString("Toukokuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(5);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);
        Days.Add(31);*/
    }

    public void Kesäkuu()
    {
        kuukausi = 6;
        kuukaudenNimi = kuukausi.ToString("Kesäkuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(6);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);*/
    }

    public void Heinäkuu()
    {
        kuukausi = 7;
        kuukaudenNimi = kuukausi.ToString("Heinäkuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(7);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);
        Days.Add(31);*/
    }

    public void Elokuu()
    {
        kuukausi = 8;
        kuukaudenNimi = kuukausi.ToString("Elokuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(8);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);
        Days.Add(31);*/
    }

    public void Syyskuu()
    {
        kuukausi = 9;
        kuukaudenNimi = kuukausi.ToString("Syyskuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(9);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);*/
    }

    public void Lokakuu()
    {
        kuukausi = 10;
        kuukaudenNimi = kuukausi.ToString("Lokakuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(10);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);
        Days.Add(31);*/
    }

    public void Marraskuu()
    {
        kuukausi = 11;
        kuukaudenNimi = kuukausi.ToString("Marraskuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(11);
        /*Days.Add(1);
        Days.Add(2);
        Days.Add(3);
        Days.Add(4);
        Days.Add(5);
        Days.Add(6);
        Days.Add(7);
        Days.Add(8);
        Days.Add(9);
        Days.Add(10);
        Days.Add(11);
        Days.Add(12);
        Days.Add(13);
        Days.Add(14);
        Days.Add(15);
        Days.Add(16);
        Days.Add(17);
        Days.Add(18);
        Days.Add(19);
        Days.Add(20);
        Days.Add(21);
        Days.Add(22);
        Days.Add(23);
        Days.Add(24);
        Days.Add(25);
        Days.Add(26);
        Days.Add(27);
        Days.Add(28);
        Days.Add(29);
        Days.Add(30);*/
    }

    public void Joulukuu()
    {
        kuukausi = 12;
        kuukaudenNimi = kuukausi.ToString("Joulukuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(12);
        /* Days.Add(1);
         Days.Add(2);
         Days.Add(3);
         Days.Add(4);
         Days.Add(5);
         Days.Add(6);
         Days.Add(7);
         Days.Add(8);
         Days.Add(9);
         Days.Add(10);
         Days.Add(11);
         Days.Add(12);
         Days.Add(13);
         Days.Add(14);
         Days.Add(15);
         Days.Add(16);
         Days.Add(17);
         Days.Add(18);
         Days.Add(19);
         Days.Add(20);
         Days.Add(21);
         Days.Add(22);
         Days.Add(23);
         Days.Add(24);
         Days.Add(25);
         Days.Add(26);
         Days.Add(27);
         Days.Add(28);
         Days.Add(29);
         Days.Add(30);
         Days.Add(31);*/
    }
}
