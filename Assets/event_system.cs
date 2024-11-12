using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class event_system : MonoBehaviour
{
    public TMP_InputField input_text1, input_text2;
    public TMP_Text sum;

    private int tal1, tal2, summa;
    private string test;

    // Start is called before the first frame update
    void Start()
    {
        //H�r letar jag upp objektet jag vill h�mta text fr�n. Detta var felet i din kod.
        //Jag valde att h�mta komponeten som styr inputv�rdet (TMP_InputField) ist�llet
        //f�r sj�lva TMP_Text.
        input_text1 = GameObject.Find("Printed_text1").GetComponent<TMP_InputField>();
        input_text2 = GameObject.Find("Printed_text2").GetComponent<TMP_InputField>();
        
        //Summan ska jag bara �ndra textf�ltet (inte inputf�ltet) s� d�r kan jag
        //anv�nda TMP_Text
        sum = GameObject.Find("Summa").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //H�r vill jag att den h�mtar information fr�n "Printed_text1 & 2" och
        //sparar det i tal1 och tal2. Detta ska h�nda n�r jag h�gerclickar.
        //Jag anv�nder TryParse f�r att kunna s�ga v�lja att inte g�ra detta om 
        //Printed_text inneh�ller symboler ist�llet f�r siffror.
        //Det g�r att g�ra detta med convert ocks�, men d� f�rs�ker den g�ra det
        //oavsett om den kan eller inte.
        if (Input.GetButtonDown("Fire2") && int.TryParse(input_text1.text, out tal1) && int.TryParse(input_text2.text, out tal2))
        {
            //tal1 = Convert.ToInt32(input_text1.text);
            //tal2 = Convert.ToInt32(input_text2.text);
            summa = tal1 + tal2;
            sum.text = summa.ToString();
        }
    }

}
