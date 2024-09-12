using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicios2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
       float producto = vidas*exp;
       float cociente = vidas/exp;
       float resto = vidas%exp;
       float doble = vidas*2;
       float triple = exp*3;
       Debug.Log(producto);
       Debug.Log(cociente);
       Debug.Log(resto);
       Debug.Log(doble);
       Debug.Log(triple);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
