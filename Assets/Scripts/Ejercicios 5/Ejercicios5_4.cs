using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_4 : MonoBehaviour
{
    [SerializeField] int vida1;
    [SerializeField] int vida2;
    // Start is called before the first frame update
    void Start()
    {
        
        if (vida2 == 0)
        {
            Debug.Log("No se puede realizar la division");
        }
        else {

            Debug.Log("El resultado es: "+ (vida1/vida2));
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
