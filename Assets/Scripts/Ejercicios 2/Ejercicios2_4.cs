using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios2_4 : MonoBehaviour
{
    int vidas = 8;

    // Start is called before the first frame update
    void Start()
    {
        int incrementar= vidas*77;
        int decrementar= incrementar/3;
        int cuadriplicar = decrementar*decrementar;
        Debug.Log(incrementar);
        Debug.Log(decrementar);
        Debug.Log(cuadriplicar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
