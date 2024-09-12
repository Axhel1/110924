using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios2_5 : MonoBehaviour
{
    int vidasPlayer1=5;
    int vidasPlayer2=4;
    int vidasPlayer3=7;
    int vidasPlayer4=8;

    // Start is called before the first frame update
    void Start()
    {
        
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vidasPlayer2;

        int nVida2 = vidasPlayer2;
        int nVida3 = vidasPlayer3;
        int nVida1 = vidasPlayer1;
        int nVida4 = vidasPlayer4;
        Debug.Log(nVida2);
        Debug.Log(nVida3);
        Debug.Log(nVida1);
        Debug.Log(nVida4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
