using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Ejercicios3_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        Calculo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Calculo() {
        int doble=numero*2;
        int triple=numero*3;

        Debug.Log("Doble= "+doble+" "+"Triple= "+triple);

    }
}
