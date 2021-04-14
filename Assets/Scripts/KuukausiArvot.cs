using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KuukausiArvot : MonoBehaviour
{
    private int kuukausi;
    private string kuukaudenNimi;

    private int[] p‰ivienM‰‰r‰;
    
    void Update()
    {
       
    }

    public void Tammikuu()
    {
        kuukausi = 1;
        kuukaudenNimi = kuukausi.ToString("Tammikuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[30];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Helmikuu()
    {
        kuukausi = 2;
        kuukaudenNimi = kuukausi.ToString("Helmikuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[27];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Maaliskuu()
    {
        kuukausi = 3;
        kuukaudenNimi = kuukausi.ToString("Maaliskuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[30];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Huhtikuu()
    {
        kuukausi = 4;
        kuukaudenNimi = kuukausi.ToString("Huhtikuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[29];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Toukokuu()
    {
        kuukausi = 5;
        kuukaudenNimi = kuukausi.ToString("Toukokuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[30];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Kes‰kuu()
    {
        kuukausi = 6;
        kuukaudenNimi = kuukausi.ToString("Kes‰kuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[29];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Hein‰kuu()
    {
        kuukausi = 7;
        kuukaudenNimi = kuukausi.ToString("Hein‰kuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[30];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Elokuu()
    {
        kuukausi = 8;
        kuukaudenNimi = kuukausi.ToString("Elokuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[30];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Syyskuu()
    {
        kuukausi = 9;
        kuukaudenNimi = kuukausi.ToString("Syyskuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[29];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Lokakuu()
    {
        kuukausi = 10;
        kuukaudenNimi = kuukausi.ToString("Lokakuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[30];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Marraskuu()
    {
        kuukausi = 11;
        kuukaudenNimi = kuukausi.ToString("Marraskuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[29];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }

    public void Joulukuu()
    {
        kuukausi = 12;
        kuukaudenNimi = kuukausi.ToString("Joulukuu");
        Debug.Log(kuukaudenNimi);
        p‰ivienM‰‰r‰ = new int[30];
        Debug.Log("P‰ivien m‰‰r‰: " + p‰ivienM‰‰r‰);
    }
}
