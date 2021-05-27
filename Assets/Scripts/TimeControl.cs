using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    private static int kuukausi;
    private static string kuukaudenNimi;

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

    private static List<Day> Days = new List<Day>();

    private List<Minute> Minutes = new List<Minute>();

    public Transform Minuutit;

    public Transform[] weeks;

    public Transform DAYS;

    public GameObject Day29;
    public GameObject Day30;
    public GameObject Day31;

    public Text yearText;
    public Text monthText;
    public Text dayText;
    public Text clockText;

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

        TextCallFunction();
    }

    void TextCallFunction()
    {
        yearText.text = "Year: " + CalculatedYear;
        monthText.text = "Month: " + CalculatedMonth;
        dayText.text = "Day: " + CalculatedDay;
        clockText.text = string.Format("Time: " + "{0:00}:{1:00}", CalculatedHour, CalculatedMin);

        if (CalculatedYear < 0)
        {
            yearText.text = "Year: ----";
        }
        if (CalculatedMonth < 0)
        {
            monthText.text = "Month: --";
        }
        if (CalculatedDay < 0)
        {
            dayText.text = "Day: --";
        }
        if (CalculatedHour < 0 && CalculatedMin > 0)
        {
            CalculatedHour = 00;
            clockText.text = string.Format("Time: " + "{0:00}:{1:00}", CalculatedHour, CalculatedMin);
        }
        if (CalculatedHour > 0 && CalculatedMin < 0)
        {
            CalculatedMin = 00;
            clockText.text = string.Format("Time: " + "{0:00}:{1:00}", CalculatedHour, CalculatedMin);
        }
        if (CalculatedHour < 0 && CalculatedMin < 0)
        {
            clockText.text = "Time: " + "--:--";
        }
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
    public static int ConvertedMin;
    public static int CalculatedMin;

    public static int ConvertedHour;
    public static int CalculatedHour;

    public static int ConvertedDay;
    public static int CalculatedDay;

    public static int ConvertedMonth;
    public static int CalculatedMonth;

    public static int ConvertedYear;
    public static int CalculatedYear;

    public static int NegativeYear = 0;
    public static int NegativeMonth = 0;
    public static int NegativeDay = 0;
    public static int NegativeHour = 0;
    public static int NegativeMin = 0;

    public static int kolme = -3;

    //public static int startingNumber = -1;
    //public static int endingNumbeer = -2030;

    //public static var numbers = Enumerable.Range(-0, -2030).Cast<float>().ToList();

    private void Update()
    {
        CalculateTime();
        //Debug.Log("Vuodet: " + year + " Kuukaudet: " + month + " Päivät: " + day + " Tunnit: " + hour + " Minuutit: " + minute);

        ConvertedMin = (int)minute;
        CalculatedMin = MinNum - ConvertedMin;

        ConvertedHour = (int)hour;
        CalculatedHour = hourNum - ConvertedHour;

        ConvertedDay = (int)day;
        CalculatedDay = PaivaNum - ConvertedDay;

        ConvertedMonth = (int)month;
        CalculatedMonth = kuukausi - ConvertedMonth;

        ConvertedYear = (int)year;
        CalculatedYear = YearValue - ConvertedYear;

        /*for (int i = startingNumber; i <= endingNumbeer; i++)
        {
            i = NegativeYear;
            Debug.Log(NegativeYear);
        }*/

        if (CalculatedYear < NegativeYear)
        {
            CalculatedYear = 0;
        }
        else if (CalculatedMonth < NegativeMonth)
        {
            CalculatedMonth = 0;

            //CalculatedMonth = ConvertedMonth - CalculatedMonth;
            /*if (CalculatedMonth == 0)
            {
                CalculatedMonth = ConvertedMonth;
                Debug.Log(CalculatedMonth);
            }*/
        }
        else if (CalculatedDay < NegativeDay)
        {
            CalculatedDay = CalculatedDay;
        }
        else if (CalculatedHour < NegativeHour)
        {
            CalculatedHour = 0;
        }
        else if (CalculatedMin < NegativeMin)
        {
            CalculatedMin = 0;
        }

        if (YearValue == ConvertedYear && kuukausi < ConvertedMonth)
        {
            CalculatedMonth = 0;
        }
        else if (YearValue == ConvertedYear && kuukausi > ConvertedMonth)
        {
            CalculatedMonth = kuukausi - ConvertedMonth;
        }

        if (kuukausi == ConvertedMonth && PaivaNum < ConvertedDay)
        {
            CalculatedDay = 0;
        }
        else if (kuukausi == ConvertedMonth && PaivaNum > ConvertedDay)
        {
            CalculatedDay = PaivaNum - ConvertedDay;
        }

        if (PaivaNum == ConvertedDay && hourNum < ConvertedHour)
        {
            CalculatedHour = 0;
        }
        else if (PaivaNum == ConvertedDay && hourNum > ConvertedHour)
        {
            CalculatedHour = hourNum - ConvertedHour;
        }

        if (hourNum == ConvertedHour && minuteNum < ConvertedMin)
        {
            CalculatedMin = 0;
        }
        else if (hourNum == ConvertedHour && minuteNum > ConvertedMin)
        {
            CalculatedMin = minuteNum - ConvertedMin;
        }
        /*if (CalculatedYear > 0)
        {
            CalculatedMonth = kuukausi - ConvertedMonth;

            CalculatedMonth = System.Math.Abs(CalculatedMonth);

            Debug.Log(CalculatedMonth);
        }*/

        TextCallFunction();

        //Debug.Log("Vuodet: " + CalculatedYear + " Kuukaudet: " + CalculatedMonth + " Päivät: " + CalculatedDay + " Tunnit: " + CalculatedHour + " Minuutit: " + CalculatedMin);
    }

    public void Hour01()
    {
        HourMachine(1);
    }
    public void Hour02()
    {
        HourMachine(2);
    }
    public void Hour03()
    {
        HourMachine(3);
    }
    public void Hour04()
    {
        HourMachine(4);
    }
    public void Hour05()
    {
        HourMachine(5);
    }
    public void Hour06()
    {
        HourMachine(6);
    }
    public void Hour07()
    {
        HourMachine(7);
    }
    public void Hour08()
    {
        HourMachine(8);
    }
    public void Hour09()
    {
        HourMachine(9);
    }
    public void Hour10()
    {
        HourMachine(10);
    }
    public void Hour11()
    {
        HourMachine(11);
    }
    public void Hour12()
    {
        HourMachine(12);
    }
    public void Hour13()
    {
        HourMachine(13);
    }
    public void Hour14()
    {
        HourMachine(14);
    }
    public void Hour15()
    {
        HourMachine(15);
    }
    public void Hour16()
    {
        HourMachine(16);
    }
    public void Hour17()
    {
        HourMachine(17);
    }
    public void Hour18()
    {
        HourMachine(18);
    }
    public void Hour19()
    {
        HourMachine(19);
    }
    public void Hour20()
    {
        HourMachine(20);
    }
    public void Hour21()
    {
        HourMachine(21);
    }
    public void Hour22()
    {
        HourMachine(22);
    }
    public void Hour23()
    {
        HourMachine(23);
    }
    public void Hour00()
    {
        HourMachine(24);
    }

    private static int hourNum;

    void HourMachine(int tunti)
    {

        if (tunti == 1)
        {
            hourNum = 01;
        }
        else if (tunti == 2)
        {
            hourNum = 02;
        }
        else if (tunti == 3)
        {
            hourNum = 03;
        }
        else if (tunti == 4)
        {
            hourNum = 04;
        }
        else if (tunti == 5)
        {
            hourNum = 05;
        }
        else if (tunti == 6)
        {
            hourNum = 06;
        }
        else if (tunti == 7)
        {
            hourNum = 07;
        }
        else if (tunti == 8)
        {
            hourNum = 08;
        }
        else if (tunti == 9)
        {
            hourNum = 09;
        }
        else if (tunti == 10)
        {
            hourNum = 10;
        }
        else if (tunti == 11)
        {
            hourNum = 11;
        }
        else if (tunti == 12)
        {
            hourNum = 12;
        }
        else if (tunti == 13)
        {
            hourNum = 13;
        }
        else if (tunti == 14)
        {
            hourNum = 14;
        }
        else if (tunti == 15)
        {
            hourNum = 15;
        }
        else if (tunti == 16)
        {
            hourNum = 16;
        }
        else if (tunti == 17)
        {
            hourNum = 17;
        }
        else if (tunti == 18)
        {
            hourNum = 18;
        }
        else if (tunti == 19)
        {
            hourNum = 19;
        }
        else if (tunti == 20)
        {
            hourNum = 20;
        }
        else if (tunti == 21)
        {
            hourNum = 21;
        }
        else if (tunti == 22)
        {
            hourNum = 22;
        }
        else if (tunti == 23)
        {
            hourNum = 23;
        }
        else if (tunti == 24)
        {
            hourNum = 00;
        }
    }

    public void Minute01()
    {
        MinuteMachine(1);
    }
    public void Minute02()
    {
        MinuteMachine(2);
    }
    public void Minute03()
    {
        MinuteMachine(3);
    }
    public void Minute04()
    {
        MinuteMachine(4);
    }
    public void Minute05()
    {
        MinuteMachine(5);
    }
    public void Minute06()
    {
        MinuteMachine(6);
    }
    public void Minute07()
    {
        MinuteMachine(7);
    }
    public void Minute08()
    {
        MinuteMachine(8);
    }
    public void Minute09()
    {
        MinuteMachine(9);
    }
    public void Minute10()
    {
        MinuteMachine(10);
    }
    public void Minute11()
    {
        MinuteMachine(11);
    }
    public void Minute12()
    {
        MinuteMachine(12);
    }
    public void Minute13()
    {
        MinuteMachine(13);
    }
    public void Minute14()
    {
        MinuteMachine(14);
    }
    public void Minute15()
    {
        MinuteMachine(15);
    }
    public void Minute16()
    {
        MinuteMachine(16);
    }
    public void Minute17()
    {
        MinuteMachine(17);
    }
    public void Minute18()
    {
        MinuteMachine(18);
    }
    public void Minute19()
    {
        MinuteMachine(19);
    }
    public void Minute20()
    {
        MinuteMachine(20);
    }
    public void Minute21()
    {
        MinuteMachine(21);
    }
    public void Minute22()
    {
        MinuteMachine(22);
    }
    public void Minute23()
    {
        MinuteMachine(23);
    }
    public void Minute24()
    {
        MinuteMachine(24);
    }
    public void Minute25()
    {
        MinuteMachine(25);
    }
    public void Minute26()
    {
        MinuteMachine(26);
    }
    public void Minute27()
    {
        MinuteMachine(27);
    }
    public void Minute28()
    {
        MinuteMachine(28);
    }
    public void Minute29()
    {
        MinuteMachine(29);
    }
    public void Minute30()
    {
        MinuteMachine(30);
    }
    public void Minute31()
    {
        MinuteMachine(31);
    }
    public void Minute32()
    {
        MinuteMachine(32);
    }
    public void Minute33()
    {
        MinuteMachine(33);
    }
    public void Minute34()
    {
        MinuteMachine(34);
    }
    public void Minute35()
    {
        MinuteMachine(35);
    }
    public void Minute36()
    {
        MinuteMachine(36);
    }
    public void Minute37()
    {
        MinuteMachine(37);
    }
    public void Minute38()
    {
        MinuteMachine(38);
    }
    public void Minute39()
    {
        MinuteMachine(39);
    }
    public void Minute40()
    {
        MinuteMachine(40);
    }
    public void Minute41()
    {
        MinuteMachine(41);
    }
    public void Minute42()
    {
        MinuteMachine(42);
    }
    public void Minute43()
    {
        MinuteMachine(43);
    }
    public void Minute44()
    {
        MinuteMachine(44);
    }
    public void Minute45()
    {
        MinuteMachine(45);
    }
    public void Minute46()
    {
        MinuteMachine(46);
    }
    public void Minute47()
    {
        MinuteMachine(47);
    }
    public void Minute48()
    {
        MinuteMachine(48);
    }
    public void Minute49()
    {
        MinuteMachine(49);
    }
    public void Minute50()
    {
        MinuteMachine(50);
    }
    public void Minute51()
    {
        MinuteMachine(51);
    }
    public void Minute52()
    {
        MinuteMachine(52);
    }
    public void Minute53()
    {
        MinuteMachine(53);
    }
    public void Minute54()
    {
        MinuteMachine(54);
    }
    public void Minute55()
    {
        MinuteMachine(55);
    }
    public void Minute56()
    {
        MinuteMachine(56);
    }
    public void Minute057()
    {
        MinuteMachine(57);
    }
    public void Minute58()
    {
        MinuteMachine(58);
    }
    public void Minute59()
    {
        MinuteMachine(59);
    }
    public void Minute00()
    {
        MinuteMachine(60);
    }

    private static int MinNum;

    void MinuteMachine(int min)
    {

        if (min == 1)
        {
            MinNum = 01;
        }
        else if (min == 2)
        {
            MinNum = 02;
        }
        else if (min == 3)
        {
            MinNum = 03;
        }
        else if (min == 4)
        {
            MinNum = 04;
        }
        else if (min == 5)
        {
            MinNum = 05;
        }
        else if (min == 6)
        {
            MinNum = 06;
        }
        else if (min == 7)
        {
            MinNum = 07;
        }
        else if (min == 8)
        {
            MinNum = 08;
        }
        else if (min == 9)
        {
            MinNum = 09;
        }
        else if (min == 10)
        {
            MinNum = 10;
        }
        else if (min == 11)
        {
            MinNum = 11;
        }
        else if (min == 12)
        {
            MinNum = 12;
        }
        else if (min == 13)
        {
            MinNum = 13;
        }
        else if (min == 14)
        {
            MinNum = 14;
        }
        else if (min == 15)
        {
            MinNum = 15;
        }
        else if (min == 16)
        {
            MinNum = 16;
        }
        else if (min == 17)
        {
            MinNum = 17;
        }
        else if (min == 18)
        {
            MinNum = 18;
        }
        else if (min == 19)
        {
            MinNum = 19;
        }
        else if (min == 20)
        {
            MinNum = 20;
        }
        else if (min == 21)
        {
            MinNum = 21;
        }
        else if (min == 22)
        {
            MinNum = 22;
        }
        else if (min == 23)
        {
            MinNum = 23;
        }
        else if (min == 24)
        {
            MinNum = 24;
        }
        else if (min == 25)
        {
            MinNum = 25;
        }
        else if (min == 26)
        {
            MinNum = 26;
        }
        else if (min == 27)
        {
            MinNum = 27;
        }
        else if (min == 28)
        {
            MinNum = 28;
        }
        else if (min == 29)
        {
            MinNum = 29;
        }
        else if (min == 30)
        {
            MinNum = 30;
        }
        else if (min == 31)
        {
            MinNum = 31;
        }
        else if (min == 32)
        {
            MinNum = 32;
        }
        else if (min == 33)
        {
            MinNum = 33;
        }
        else if (min == 34)
        {
            MinNum = 34;
        }
        else if (min == 35)
        {
            MinNum = 35;
        }
        else if (min == 36)
        {
            MinNum = 36;
        }
        else if (min == 37)
        {
            MinNum = 37;
        }
        else if (min == 38)
        {
            MinNum = 38;
        }
        else if (min == 39)
        {
            MinNum = 39;
        }
        else if (min == 40)
        {
            MinNum = 40;
        }
        else if (min == 41)
        {
            MinNum = 41;
        }
        else if (min == 42)
        {
            MinNum = 42;
        }
        else if (min == 43)
        {
            MinNum = 43;
        }
        else if (min == 44)
        {
            MinNum = 44;
        }
        else if (min == 45)
        {
            MinNum = 45;
        }
        else if (min == 46)
        {
            MinNum = 46;
        }
        else if (min == 47)
        {
            MinNum = 47;
        }
        else if (min == 48)
        {
            MinNum = 48;
        }
        else if (min == 49)
        {
            MinNum = 49;
        }
        else if (min == 50)
        {
            MinNum = 50;
        }
        else if (min == 51)
        {
            MinNum = 51;
        }
        else if (min == 52)
        {
            MinNum = 52;
        }
        else if (min == 53)
        {
            MinNum = 53;
        }
        else if (min == 54)
        {
            MinNum = 54;
        }
        else if (min == 55)
        {
            MinNum = 55;
        }
        else if (min == 56)
        {
            MinNum = 56;
        }
        else if (min == 57)
        {
            MinNum = 57;
        }
        else if (min == 58)
        {
            MinNum = 58;
        }
        else if (min == 59)
        {
            MinNum = 59;
        }
        else if (min == 60)
        {
            MinNum = 00;
        }
    }

    public void Day01()
    {
        DayMachine(1);
    }
    public void Day02()
    {
        DayMachine(2);
    }
    public void Day03()
    {
        DayMachine(3);
    }
    public void Day04()
    {
        DayMachine(4);
    }
    public void Day05()
    {
        DayMachine(5);
    }
    public void Day06()
    {
        DayMachine(6);
    }
    public void Day07()
    {
        DayMachine(7);
    }
    public void Day08()
    {
        DayMachine(8);
    }
    public void Day09()
    {
        DayMachine(9);
    }
    public void Day10()
    {
        DayMachine(10);
    }
    public void Day11()
    {
        DayMachine(11);
    }
    public void Day12()
    {
        DayMachine(12);
    }
    public void Day13()
    {
        DayMachine(13);
    }
    public void Day14()
    {
        DayMachine(14);
    }
    public void Day15()
    {
        DayMachine(15);
    }
    public void Day16()
    {
        DayMachine(16);
    }
    public void Day17()
    {
        DayMachine(17);
    }
    public void Day18()
    {
        DayMachine(18);
    }
    public void Day19()
    {
        DayMachine(19);
    }
    public void Day20()
    {
        DayMachine(20);
    }
    public void Day21()
    {
        DayMachine(21);
    }
    public void Day22()
    {
        DayMachine(22);
    }
    public void Day23()
    {
        DayMachine(23);
    }
    public void Day24()
    {
        DayMachine(24);
    }
    public void Day25()
    {
        DayMachine(25);
    }
    public void Day26()
    {
        DayMachine(26);
    }
    public void Day27()
    {
        DayMachine(27);
    }
    public void Day28()
    {
        DayMachine(28);
    }
    public void day29()
    {
        DayMachine(29);
    }
    public void day30()
    {
        DayMachine(30);
    }
    public void day31()
    {
        DayMachine(31);
    }

    public static int PaivaNum;

    void DayMachine(int day)
    {
        if (day == 1)
        {
            PaivaNum = 01;
        }
        else if (day == 2)
        {
            PaivaNum = 02;
        }
        else if (day == 3)
        {
            PaivaNum = 03;
        }
        else if (day == 4)
        {
            PaivaNum = 04;
        }
        else if (day == 5)
        {
            PaivaNum = 05;
        }
        else if (day == 6)
        {
            PaivaNum = 06;
        }
        else if (day == 7)
        {
            PaivaNum = 07;
        }
        else if (day == 8)
        {
            PaivaNum = 08;
        }
        else if (day == 9)
        {
            PaivaNum = 09;
        }
        else if (day == 10)
        {
            PaivaNum = 10;
        }
        else if (day == 11)
        {
            PaivaNum = 11;
        }
        else if (day == 12)
        {
            PaivaNum = 12;
        }
        else if (day == 13)
        {
            PaivaNum = 13;
        }
        else if (day == 14)
        {
            PaivaNum = 14;
        }
        else if (day == 15)
        {
            PaivaNum = 15;
        }
        else if (day == 16)
        {
            PaivaNum = 16;
        }
        else if (day == 17)
        {
            PaivaNum = 17;
        }
        else if (day == 18)
        {
            PaivaNum = 18;
        }
        else if (day == 19)
        {
            PaivaNum = 19;
        }
        else if (day == 20)
        {
            PaivaNum = 20;
        }
        else if (day == 21)
        {
            PaivaNum = 21;
        }
        else if (day == 22)
        {
            PaivaNum = 22;
        }
        else if (day == 23)
        {
            PaivaNum = 23;
        }
        else if (day == 24)
        {
            PaivaNum = 24;
        }
        else if (day == 25)
        {
            PaivaNum = 25;
        }
        else if (day == 26)
        {
            PaivaNum = 26;
        }
        else if (day == 27)
        {
            PaivaNum = 27;
        }
        else if (day == 28)
        {
            PaivaNum = 28;
        }
        else if (day == 29)
        {
            PaivaNum = 29;
        }
        else if (day == 30)
        {
            PaivaNum = 30;
        }
        else if (day == 31)
        {
            PaivaNum = 31;
        }
    }


    void UpdateCalendar(int year, int month)
    {
        DateTime date = new DateTime(year, month, day: 22);

        currentDate = date;
        int startDay = GetMonthStartDay(year, month);
        int endDay = GetTotalNumberOfDays(year, month);

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


    private static int YearValue;
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

    private static int minuteNum;

    public void MinuteFactory(int a)
    {
        if (a == 1)
        {
            if (Minutes.Count == 0)
            {
                minuteNum = -01;

                for (int i = 0; i < 59; i++)
                {
                    minuteNum++;
                    Minute newMinute = new Minute(minuteNum, Color.white, Minuutit.GetChild(i).gameObject);
                    Minutes.Add(newMinute);
                }
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

                Debug.Log("DaysCount: " + Days.Capacity);

                if (DAYS.childCount > 28)
                {
                    YearControll();

                    //Day29.SetActive(false);
                    Day30.SetActive(false);
                    Day31.SetActive(false);
                    //Days.RemoveAt(30);
                    //Days.RemoveAt(31);
                    //return;
                }

                /*for (int i = 0; i < 2; ++i)
                {
                    Destroy(DAYS.GetChild(i));
                }*/


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
