using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios2_2 : MonoBehaviour
{

    int vidas=100;
    float exp=50;
    char carac='M';
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vidas "+ vidas);
        Debug.Log("Exp " + exp);
        float resultadoSuma=vidas+exp;
        float resultadoResta = exp - vidas;
        Debug.Log(resultadoSuma);
        Debug.Log(resultadoResta);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
