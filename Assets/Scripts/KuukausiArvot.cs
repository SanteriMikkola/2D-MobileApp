using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KuukausiArvot : MonoBehaviour
{
    private int kuukausi;
    private string kuukaudenNimi;

    /*public class Day
    {
        public int DayNum;
        public GameObject Obj;

        public Day (int DayNum, GameObject Obj)
        {
            this.DayNum = DayNum;
            this.Obj = Obj;
            UpdateDay(DayNum);
        }

        public void UpdateDay(int newDayNum)
        {
            this.DayNum = newDayNum;

            Obj.GetComponentInChildren<Text>().text = (DayNum + 1).ToString();
        }
        
    }

    private List<int> Days = new List<int>();

    public int[] weeks = new int[5];

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
            for (int i = 0; 0 < 6; i++)
            {
                for (int a = 0, 0 < 7; a++)
                {
                    Day newDay;

                    int currDay = (i * 7) + i;

                    if (currDay < startDay || currDay - startDay >= endDay)
                    {
                        newDay = new Day(currDay - startDay, weeks[a].GetChild(i));
                    }
                    else
                    {
                        newDay = new Day(currDay - startDay, weeks[a].GetChild(i));
                    }

                    Days.Add(newDay);
                }
            }
        }
    }*/

    public void Tammikuu()
    {
        kuukausi = 1;
        kuukaudenNimi = kuukausi.ToString("Tammikuu");
        Debug.Log(kuukaudenNimi);
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
