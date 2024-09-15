using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios3_5 : MonoBehaviour
{
    [SerializeField] int radio;
    double pi = 3.14;
    // Start is called before the first frame update
    void Start()
    {
        AreaLongitud();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AreaLongitud() {
        double longitud = 2* pi * radio;
        double area=Math.Pow(pi*radio,2);

        Debug.Log("Longitud "+longitud+" "+"Area " +area);
    
    }
}
