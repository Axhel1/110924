using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    private string nombre;
    private int vida;
    private float experiencia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float CalcularNivel() {
        float lvl;
        lvl = experiencia / 1000;
        
        return lvl; 
    }
}
