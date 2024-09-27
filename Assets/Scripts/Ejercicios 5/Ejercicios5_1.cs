using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_1 : MonoBehaviour
{
    [SerializeField]int vida1;
    [SerializeField]int vida2;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log("Son Iguales");
        }
        else
        {

            Debug.Log("Son Distintos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
