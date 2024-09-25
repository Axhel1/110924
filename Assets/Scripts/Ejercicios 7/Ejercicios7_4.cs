using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_4 : MonoBehaviour
{
    int numero = 1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 100; i >= numero; i--)
        {

            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
