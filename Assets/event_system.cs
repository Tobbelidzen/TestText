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
        //Här letar jag upp objektet jag vill hämta text från. Detta var felet i din kod.
        //Jag valde att hämta komponeten som styr inputvärdet (TMP_InputField) istället
        //för själva TMP_Text.
        input_text1 = GameObject.Find("Printed_text1").GetComponent<TMP_InputField>();
        input_text2 = GameObject.Find("Printed_text2").GetComponent<TMP_InputField>();
        
        //Summan ska jag bara ändra textfältet (inte inputfältet) så där kan jag
        //använda TMP_Text
        sum = GameObject.Find("Summa").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Här vill jag att den hämtar information från "Printed_text1 & 2" och
        //sparar det i tal1 och tal2. Detta ska hända när jag högerclickar.
        //Jag använder TryParse för att kunna säga välja att inte göra detta om 
        //Printed_text innehåller symboler istället för siffror.
        //Det går att göra detta med convert också, men då försöker den göra det
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
