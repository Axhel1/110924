using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Ejercicios4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Convertir(1,"€");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Convertir(float cantidad,string moneda)
    {

        if (moneda == "$")
        {
            float dolar = cantidad * 1.11f;
            Debug.Log("Su cantidad de Euros "+cantidad+" son "+dolar+" Dolares");


        }
        else if (moneda == "€"){

            float euro = cantidad * 0.90f;
            Debug.Log("Su cantidad de Dolares " + cantidad + " son " + euro + " Euros");

        }
    }
}
