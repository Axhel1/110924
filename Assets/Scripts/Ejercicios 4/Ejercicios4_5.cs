using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios4_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Convertir(Circulo(5), "€");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    double Circulo(double radio)
    {

        double calculoArea = Math.Pow(radio, 2) / 2;

        return calculoArea;
    }
    double Triangulo(double bas, double altura)
    {

        double calculoArea = (bas * altura) / 2;

        return calculoArea;
    }
    double Cuadrado(double lado)
    {

        double calculoArea = lado * lado;

        return calculoArea;

    }

    void Convertir(double cantidad, string moneda)
    {

        if (moneda == "$")
        {
            double dolar = cantidad * 1.11f;
            Debug.Log("Su cantidad de Euros " + cantidad + " son " + dolar + " Dolares");


        }
        else if (moneda == "€")
        {

            double euro = cantidad * 0.90f;
            Debug.Log("Su cantidad de Dolares " + cantidad + " son " + euro + " Euros");

        }
    }
}
