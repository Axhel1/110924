using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios2_7 : MonoBehaviour
{
    int oro = 7;
    int segundos;

    // Start is called before the first frame update
    void Start()
    {
       segundos = 4;
        int oroFarmeado = oro * segundos;
        Debug.Log(oroFarmeado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
