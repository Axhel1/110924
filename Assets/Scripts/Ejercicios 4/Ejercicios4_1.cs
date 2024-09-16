using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double calculoCirculo =  Circulo(5);
        double calculoTriangulo = Triangulo(5,6);
        double calculoCuadrado= Cuadrado(4);

        Debug.Log("El area del ciruclo es " + calculoCirculo);
        Debug.Log("El area del triangulo es " + calculoTriangulo);
        Debug.Log("El area del cuadrado es " + calculoCuadrado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    double Circulo(double radio){

        double calculoArea = Math.Pow(radio,2)/2;

        return calculoArea;
    }
    double Triangulo(double bas,double altura){ 

        double calculoArea = (bas*altura)/2;
    
        return calculoArea;
    }
    double Cuadrado(double lado){

        double calculoArea = lado*lado;

        return calculoArea;
    
    }
    
}
