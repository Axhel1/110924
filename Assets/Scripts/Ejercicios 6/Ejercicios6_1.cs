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
        //a) (X && Y) || (X && Z)
        //Respuesta=True

        //b) (X || !Y)&& (!X || Z)
        //Respuesta=True

        //c) X || Y && Z
        //Respuesta=True

        //d) !(X || Y) && Z
        //Respuesta=False

        //e) X || Y || X && !Z && !Y
        //Respuesta=True

        //f) !X || Y || Z && X && !Y
        //Respuesta=True
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
