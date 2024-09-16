using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios6_1 : MonoBehaviour
{

    bool x = true;
    bool y = false;
    bool z = true; 

    // Start is called before the first frame update
    void Start()
    {
        if (x && y)
        {

            Debug.Log("True");

        }
        else {

            Debug.Log("Falso");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
