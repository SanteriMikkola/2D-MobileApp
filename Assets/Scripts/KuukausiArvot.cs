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

    public Transform DAYS;

    public DateTime currentDate = DateTime.Now;

    void Start()
    {
        UpdateCalendar(DateTime.Now.Year, DateTime.Now.Month);
    }

    /*private void Update()
    {
        Debug.Log("Year: " + currentDate.Year + " , Month: " + currentDate.Month + " , Day: " + currentDate.Day + " , Hours: " + currentDate.Hour + " , Minutes: " + currentDate.Minute);
    }*/

    void UpdateCalendar(int year, int month)
    {
        DateTime date = new DateTime(year, month, 1);


        currentDate = date;
        int startDay = GetMonthStartDay(year, month);
        int endDay = GetTotalNumberOfDays(year, month);

        /*if(Days.Count == 0)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 7; a++)
                {
                    Day newDay;

                    int currDay = (i * 7) + a;

                    if (currDay < startDay || currDay - startDay >= endDay)
                    {
                        newDay = new Day(currDay - startDay, Color.grey, weeks[i].GetChild(a).gameObject);
                        Destroy(newDay.Obj);
                    }
                    else
                    {
                        newDay = new Day(currDay - startDay, Color.white, weeks[i].GetChild(a).gameObject);
                        Days.Add(newDay);
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
        }*/
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
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;

        int startDay = GetMonthStartDay(year, month);
        int endDay = GetTotalNumberOfDays(year, month);


        if (direction == 1)
        {
            currentDate = currentDate.AddMonths(1);

            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 0; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
            }
        }
        else if (direction == 2)
        {
            currentDate = currentDate.AddMonths(2);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 0; i < 28; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
            }
        }
        else if (direction == 3)
        {
            currentDate = currentDate.AddMonths(3);
            if (Days.Count == 0)
            {
                Day newDay = new Day(31, Color.white, gameObject);

                Days.Add(newDay);
            }
        }
        else if (direction == 4)
        {
            currentDate = currentDate.AddMonths(4);
            if (Days.Count == 0)
            {
                Day newDay = new Day(30, Color.white, gameObject);

                Days.Add(newDay);
            }
        }
        else if (direction == 5)
        {
            currentDate = currentDate.AddMonths(5);
            if (Days.Count == 0)
            {
                Day newDay = new Day(31, Color.white, gameObject);

                Days.Add(newDay);
            }
        }
        else if (direction == 6)
        {
            currentDate = currentDate.AddMonths(6);
            if (Days.Count == 0)
            {
                Day newDay = new Day(30, Color.white, gameObject);

                Days.Add(newDay);
            }
        }
        else if (direction == 7)
        {
            currentDate = currentDate.AddMonths(7);
            if (Days.Count == 0)
            {
                Day newDay = new Day(31, Color.white, gameObject);

                Days.Add(newDay);
            }
        }
        else if (direction == 8)
        {
            currentDate = currentDate.AddMonths(8);
            if (Days.Count == 0)
            {
                Day newDay = new Day(31, Color.white, gameObject);

                Days.Add(newDay);
            }
        }
        else if (direction == 9)
        {
            currentDate = currentDate.AddMonths(9);
            if (Days.Count == 0)
            {
                Day newDay = new Day(30, Color.white, gameObject);

                Days.Add(newDay);
            }
        }
        else if (direction == 10)
        {
            currentDate = currentDate.AddMonths(10);
            if (Days.Count == 0)
            {
                Day newDay = new Day(31, Color.white, gameObject);

                Days.Add(newDay);
            }
        }
        else if (direction == 11)
        {
            currentDate = currentDate.AddMonths(11);
            if (Days.Count == 0)
            {
                Day newDay = new Day(30, Color.white, gameObject);

                Days.Add(newDay);
            }
        }
        else if (direction == 12)
        {
            currentDate = currentDate.AddMonths(12);
            if (Days.Count == 0)
            {
                Day newDay = new Day(31, Color.white, gameObject);

                Days.Add(newDay);
            }
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
        
    }

    public void Helmikuu()
    {
        kuukausi = 2;
        kuukaudenNimi = kuukausi.ToString("Helmikuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(2);
        
    }

    public void Maaliskuu()
    {
        kuukausi = 3;
        kuukaudenNimi = kuukausi.ToString("Maaliskuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(3);
        
    }

    public void Huhtikuu()
    {
        kuukausi = 4;
        kuukaudenNimi = kuukausi.ToString("Huhtikuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(4);
        
    }

    public void Toukokuu()
    {
        kuukausi = 5;
        kuukaudenNimi = kuukausi.ToString("Toukokuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(5);
        
    }

    public void Kesäkuu()
    {
        kuukausi = 6;
        kuukaudenNimi = kuukausi.ToString("Kesäkuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(6);
        
    }

    public void Heinäkuu()
    {
        kuukausi = 7;
        kuukaudenNimi = kuukausi.ToString("Heinäkuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(7);
        
    }

    public void Elokuu()
    {
        kuukausi = 8;
        kuukaudenNimi = kuukausi.ToString("Elokuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(8);
        
    }

    public void Syyskuu()
    {
        kuukausi = 9;
        kuukaudenNimi = kuukausi.ToString("Syyskuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(9);
        
    }

    public void Lokakuu()
    {
        kuukausi = 10;
        kuukaudenNimi = kuukausi.ToString("Lokakuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(10);
        
    }

    public void Marraskuu()
    {
        kuukausi = 11;
        kuukaudenNimi = kuukausi.ToString("Marraskuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(11);
        
    }

    public void Joulukuu()
    {
        kuukausi = 12;
        kuukaudenNimi = kuukausi.ToString("Joulukuu");
        Debug.Log(kuukaudenNimi);
        SwitchMonth(12);
        
    }
}
