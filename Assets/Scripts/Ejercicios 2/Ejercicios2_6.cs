using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios2_6 : MonoBehaviour
{
    int puntaje1 = 45;
    int puntaje2 = 58;
    int puntaje3 = 41;

    // Start is called before the first frame update
    void Start()
    {
        int media = (puntaje1 + puntaje2 + puntaje3) / 3;
        Debug.Log(media); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
