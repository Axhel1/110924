using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_6 : MonoBehaviour
{
    [SerializeField] int nivel;
    // Start is called before the first frame update
    void Start()
    {
        if (nivel%10 == 0)
        {
            Debug.Log("Es multiplo de 10");
        }
        else {

            Debug.Log("No es multiplo de 10");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
