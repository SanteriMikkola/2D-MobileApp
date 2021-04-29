using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    private int kuukausi;
    private string kuukaudenNimi;

    public class Day
    {
        public int DayNum;
        public GameObject Obj;
        public Color dayColor;

        public Day(int DayNum, Color dayColor, GameObject Obj)
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
    public class Minute
    {
        public int MinuteNum;
        public GameObject Object;
        public Color MinuteColor;

        public Minute(int MinuteNum, Color MinuteColor, GameObject Object)
        {
            this.MinuteNum = MinuteNum;
            this.Object = Object;
            UpdateMinuteColor(MinuteColor);
            UpdateMinute(MinuteNum);
        }

        public void UpdateMinuteColor(Color newColor)
        {
            Object.GetComponent<Image>().color = newColor;
            MinuteColor = newColor;
        }

        public void UpdateMinute(int newMinuteNum)
        {
            this.MinuteNum = newMinuteNum;
            if (MinuteColor == Color.white)
            {
                Object.GetComponentInChildren<Text>().text = string.Format("{0:00}", MinuteNum + 1);
            }
            else
            {
                Object.GetComponentInChildren<Text>().text = "";
            }
        }

    }

    private readonly List<Day> Days = new List<Day>();

    private List<Minute> Minutes = new List<Minute>();

    public Transform Minuutit;

    public Transform[] weeks;

    public Transform DAYS;

    public GameObject Day29;
    public GameObject Day30;
    public GameObject Day31;

    private const int TIMESCALE = 1;

    public static double second, minute, hour, day, month, year;

    public DateTime currentDate = DateTime.Now;

    void Start()
    {
        UpdateCalendar(DateTime.Now.Year, DateTime.Now.Month);

        second = DateTime.Now.Second;
        minute = DateTime.Now.Minute;
        hour = DateTime.Now.Hour;
        day = DateTime.Now.Day;
        month = DateTime.Now.Month;
        year = DateTime.Now.Year;

    }

    void CalculateMonth()
    {
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if (day >= 32)
            {
                month++;
                day = 1;
            }
        }

        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day >= 31)
            {
                month++;
                day = 1;
            }
        }
        if (month == 2)
        {
            month++;
            day = 1;
        }
    }

    void CalculateTime()
    {
        second += Time.deltaTime * TIMESCALE;

        if (second >= 60)
        {
            minute++;
            second = 0;
        }
        else if (minute >= 60)
        {
            hour++;
            minute = 0;
        }
        else if (hour >= 24)
        {
            day++;
            hour = 0;
        }
        else if (day >= 28)
        {
            CalculateMonth();
        }
        else if (month >12)
        {
            month = 1;
            year++;
        }

    }

    private void Update()
    {
        CalculateTime();
        //Debug.Log("Vuodet: " + year + " Kuukaudet: " + month + " Päivät: " + day + " Tunnit: " + hour + " Minuutit: " + minute);

    }

    void UpdateCalendar(int year, int month)
    {
        DateTime date = new DateTime(year, month, day: 22);


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
    public void Year2021()
    {
        YearChooser(1);
    }
    public void Year2022()
    {
        YearChooser(2);
    }
    public void Year2023()
    {
        YearChooser(3);
    }
    public void Year2024()
    {
        YearChooser(4);
    }
    public void Year2025()
    {
        YearChooser(5);
    }
    public void Year2026()
    {
        YearChooser(6);
    }
    public void Year2027()
    {
        YearChooser(7);
    }
    public void Year2028()
    {
        YearChooser(8);
    }
    public void Year2029()
    {
        YearChooser(9);
    }
    public void Year2030()
    {
        YearChooser(10);
    }
    public void Year2031()
    {
        YearChooser(11);
    }
    public void Year2032()
    {
        YearChooser(12);
    }
    public void Year2033()
    {
        YearChooser(13);
    }
    public void Year2034()
    {
        YearChooser(14);
    }
    public void Year2035()
    {
        YearChooser(15);
    }
    public void Year2036()
    {
        YearChooser(16);
    }
    public void Year2037()
    {
        YearChooser(17);
    }
    public void Year2038()
    {
        YearChooser(18);
    }
    public void Year2039()
    {
        YearChooser(19);
    }
    public void Year2040()
    {
        YearChooser(20);
    }
    public void Year2041()
    {
        YearChooser(21);
    }


    private static double YearValue;
    private static double casevalue;

    public void YearChooser(int value)
    {

        if (value == 1)
        {
            casevalue = 1;
            YearValue = 2021;
        }
        else if (value == 2)
        {
            casevalue = 1;
            YearValue = 2022;
        }
        else if (value == 3)
        {
            casevalue = 1;
            YearValue = 2023;
        }
        else if (value == 4)
        {
            casevalue = 1;
            YearValue = 2024;
        }
        else if (value == 5)
        {
            casevalue = 1;
            YearValue = 2025;
        }
        else if (value == 6)
        {
            casevalue = 1;
            YearValue = 2026;
        }
        else if (value == 7)
        {
            casevalue = 1;
            YearValue = 2027;
        }
        else if (value == 8)
        {
            casevalue = 1;
            YearValue = 2028;
        }
        else if (value == 9)
        {
            casevalue = 1;
            YearValue = 2029;
        }
        else if (value == 10)
        {
            casevalue = 1;
            YearValue = 2030;
        }
        else if (value == 11)
        {
            casevalue = 1;
            YearValue = 2031;
        }
        else if (value == 12)
        {
            casevalue = 1;
            YearValue = 2032;
        }
        else if (value == 13)
        {
            casevalue = 1;
            YearValue = 2033;
        }
        else if (value == 14)
        {
            casevalue = 1;
            YearValue = 2034;
        }
        else if (value == 15)
        {
            casevalue = 1;
            YearValue = 2035;
        }
        else if (value == 16)
        {
            casevalue = 1;
            YearValue = 2036;
        }
        else if (value == 17)
        {
            casevalue = 1;
            YearValue = 2037;
        }
        else if (value == 18)
        {
            casevalue = 1;
            YearValue = 2038;
        }
        else if (value == 19)
        {
            casevalue = 1;
            YearValue = 2039;
        }
        else if (value == 20)
        {
            casevalue = 1;
            YearValue = 2040;
        }
        else if (value == 21)
        {
            casevalue = 1;
            YearValue = 2041;
        }
        //return;
    }

    public void YearControll()
    {
        

        int CaseValue = 1;
        Debug.Log("Mikä vuosi: " + YearValue);

        if (CaseValue == casevalue)
        {
            if (YearValue == 2024 || YearValue == 2028 || YearValue == 2032 || YearValue == 2036 || YearValue == 2040)
            {
                Day29.SetActive(true);
                
            }
            else if (YearValue == 2021 || YearValue == 2022 || YearValue == 2023 || YearValue == 2025 || YearValue == 2026 || YearValue == 2027 || YearValue == 2029 || YearValue == 2030 || YearValue == 2031 || YearValue == 2033 || YearValue == 2034 || YearValue == 2035 || YearValue == 2037 || YearValue == 2038 || YearValue == 2039 || YearValue == 2041)
            {
                Day29.SetActive(false);
                
            }
            
        }
    }

    public void MinuteFactory(int a)
    {
        if (a == 1)
        {
            if (Minutes.Count == 0)
            {
                int minuteNum = -01;

                for (int i = 0; i < 59; i++)
                {
                    minuteNum++;
                    Minute newMinute = new Minute(minuteNum, Color.white, Minuutit.GetChild(i).gameObject);
                    Minutes.Add(newMinute);
                }
                Debug.Log(Minutes.Count);
                return;
            }
            return;
        }
    }

    public void UpdateTime()
    {
        MinuteFactory(1);
    }


    public void SwitchMonth(int direction)
    {


        if (direction == 1)
        {
            Day29.SetActive(true);
            Day30.SetActive(true);
            Day31.SetActive(true);

            currentDate = currentDate.AddMonths(1);

            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
                

                Day29.SetActive(true);
                Day30.SetActive(true);
                Day31.SetActive(true);
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 2)
        {
            currentDate = currentDate.AddMonths(2);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; ++i)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }


                if (DAYS.childCount > 28)
                {
                    YearControll();

                    //Day29.SetActive(false);
                    Day30.SetActive(false);
                    Day31.SetActive(false);
                    //return;
                }


                //DaysTotalNum();

                /*Debug.Log(DAYS.childCount);
                int i = 0;
                foreach (Transform child in DAYS)
                {
                    i += 1;
                    for (int i = 0; i < DAYS.childCount; i++)
                    {
                        Transform child = DAYS.GetChild(i);
                    }
                    Debug.Log(DAYS.childCount);
                }*/
                /*foreach (Transform child in DAYS)
                    child.gameObject.SetActive(false);*/

                //DAYS.gameObject.transform.GetChild(29).GetChild(30).GetChild(31).gameObject.SetActive(false);
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 3)
        {
            Day29.SetActive(true);
            Day30.SetActive(true);
            Day31.SetActive(true);

            currentDate = currentDate.AddMonths(3);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }


                Day29.SetActive(true);
                Day30.SetActive(true);
                Day31.SetActive(true);
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 4)
        {
            currentDate = currentDate.AddMonths(4);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
                

                if (DAYS.childCount > 30)
                {
                    Day29.SetActive(true);
                    Day30.SetActive(true);
                    Day31.SetActive(false);
                    return;
                }
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 5)
        {
            Day29.SetActive(true);
            Day30.SetActive(true);
            Day31.SetActive(true);

            currentDate = currentDate.AddMonths(5);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
                

                Day29.SetActive(true);
                Day30.SetActive(true);
                Day31.SetActive(true);
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 6)
        {
            currentDate = currentDate.AddMonths(6);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
                

                if (DAYS.childCount > 30)
                {
                    Day29.SetActive(true);
                    Day30.SetActive(true);
                    Day31.SetActive(false);

                    return;
                }
                /*Day29.GetComponent<Text>().text = "29";
                Day30.GetComponent<Text>().text = "30";
                Day31.GetComponent<Text>().text = "31";*/

                //DAYS.DetachChildren();
                /*if (direction != 6)
                {
                    foreach (Transform child in DAYS)
                        child.gameObject.SetActive(true);
                    return;
                }*/
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 7)
        {
            Day29.SetActive(true);
            Day30.SetActive(true);
            Day31.SetActive(true);

            currentDate = currentDate.AddMonths(7);
            if (Days.Count == 0)
            {

                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                    
                }
                

                /*Day29.GetComponent<Text>().text = "29";
                Day30.GetComponent<Text>().text = "30";
                Day31.GetComponent<Text>().text = "31";*/

                Day29.SetActive(true);
                Day30.SetActive(true);
                Day31.SetActive(true);

                //DAYS.DetachChildren();
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 8)
        {
            Day29.SetActive(true);
            Day30.SetActive(true);
            Day31.SetActive(true);

            currentDate = currentDate.AddMonths(8);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
                

                Day29.SetActive(true);
                Day30.SetActive(true);
                Day31.SetActive(true);
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 9)
        {
            currentDate = currentDate.AddMonths(9);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
                

                if (DAYS.childCount > 30)
                {
                    Day29.SetActive(true);
                    Day30.SetActive(true);
                    Day31.SetActive(false);
                    return;
                }
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 10)
        {
            Day29.SetActive(true);
            Day30.SetActive(true);
            Day31.SetActive(true);

            currentDate = currentDate.AddMonths(10);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
                

                Day29.SetActive(true);
                Day30.SetActive(true);
                Day31.SetActive(true);
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 11)
        {
            currentDate = currentDate.AddMonths(11);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
                

                if (DAYS.childCount > 30)
                {
                    Day29.SetActive(true);
                    Day30.SetActive(true);
                    Day31.SetActive(false);
                    return;
                }
                return;
            }
            //Days.RemoveAll(Days.Contains);
            return;
        }
        else if (direction == 12)
        {
            Day29.SetActive(true);
            Day30.SetActive(true);
            Day31.SetActive(true);

            currentDate = currentDate.AddMonths(12);
            if (Days.Count == 0)
            {
                int daynum = -1;

                for (int i = 31; i < 31; i++)
                {
                    daynum++;
                    Day newDay = new Day(daynum, Color.white, DAYS.GetChild(i).gameObject);
                    Days.Add(newDay);
                }
                

                Day29.SetActive(true);
                Day30.SetActive(true);
                Day31.SetActive(true);
                return;
            }
            //Days.RemoveAll(Days.Contains);
        }
        else
        {
            Debug.LogError("Unity.exe lakkasi toiminnasta");
        }

        UpdateCalendar(currentDate.Year, currentDate.Month);
        return;
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
