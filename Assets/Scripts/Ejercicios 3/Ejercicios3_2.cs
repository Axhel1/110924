using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios3_2 : MonoBehaviour
{

    [SerializeField]string nombre;
    // Start is called before the first frame update
    void Start()
    {
        metNombre();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void metNombre(){
        Debug.Log("Bienvenido de nuevo "+ nombre);
    
    }
}
