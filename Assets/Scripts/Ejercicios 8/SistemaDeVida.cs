using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] float vInicial;
    float vActual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float RecibirCura(float cantidad) {

        if (cantidad <0)
        {
            return -1;

        }
        else if (cantidad >= 0 ) {

            vActual = vInicial + cantidad;
        }

        
    
    
        return vActual;
    }

    float RecibirDanho(float danho) { 
    
    
        return danho;
    }
}
