using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_12 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SumarTodosLosNumeros(1,10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int SumarTodosLosNumeros(int num1,int num2) {
        
        int total=0;

        for (int i = num1; i <= num2; i++)
        {
            total =total+i;
        }
    
        return total;
    }
}

