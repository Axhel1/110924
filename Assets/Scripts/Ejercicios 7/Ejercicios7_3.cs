using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_3 : MonoBehaviour
{
    int numero = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (numero > 0)
        {

            Debug.Log(numero);
            numero--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
