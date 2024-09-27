using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_3 : MonoBehaviour
{
    [SerializeField] int vida1;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 >= 0 && vida1 < 10)
        {
            Debug.Log("Numero comprendido 0 y 9");
        }
        else
        {

            Debug.Log("Numero de 10 a delante");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
