using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios2_8 : MonoBehaviour
{

    int puntos = 120;
    int veneno = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        int porcentaje = ((puntos / 100) * veneno);
        Debug.Log(puntos-porcentaje);
        veneno = veneno + 3;

        //Debug.Log("vida " + puntos);

    }
    
}
