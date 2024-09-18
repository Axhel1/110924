using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_5 : MonoBehaviour
{
    int numero = 1;
    [SerializeField] int numero2;
    // Start is called before the first frame update
    void Start()
    {
        while (numero <= numero2)
        {

            Debug.Log(numero);
            numero++;
        }
    }

    // Update is called once per frame
    void Update()
    {
  
      

    }
}
