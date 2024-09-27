using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejericios5_10 : MonoBehaviour
{
    [SerializeField] int Temperatura;

    // Start is called before the first frame update
    void Start()
    {
        if (Temperatura <= 10) {
            Debug.Log("El clima es: Frio");
        }
        else if (Temperatura > 10 && Temperatura <= 20)
        {
            Debug.Log("El clima es: Nublado");

        }
        else if (Temperatura > 20 && Temperatura <= 30)
        {
            Debug.Log("El clima es: Caluroso");

        }
        else if (Temperatura > 30)
        {
            Debug.Log("El clima es: Tropical");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
