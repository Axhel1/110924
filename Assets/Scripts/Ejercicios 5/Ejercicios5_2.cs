using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_2 : MonoBehaviour
{
    [SerializeField] int vida1;
    [SerializeField] int vida2;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 <= 3 && vida2 <=3)
        {
            Debug.Log("Ambos son menores a 3");
        }
        else
        {

            Debug.Log("Alguno es mayor a 3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
