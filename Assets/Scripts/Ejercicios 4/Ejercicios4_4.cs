using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Conversion(60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Conversion(float velocidad)
    {
        double ms = velocidad / 3.6;

        Debug.Log("La velocidad en m/s es=" + ms);

    }
}
