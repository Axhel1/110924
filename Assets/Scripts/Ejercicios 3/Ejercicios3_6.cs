using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios3_6 : MonoBehaviour
{
    [SerializeField] int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        Conversion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Conversion() { 
       double ms=velocidad/3.6;

        Debug.Log("La velocidad en m/s es="+ ms);
    
    }
}
