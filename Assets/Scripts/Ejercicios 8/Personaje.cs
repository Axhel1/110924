using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    private string nombre;
    private int vida;
    private float experiencia;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float CalcularNivel(float exp) {
        float lvl;
        lvl = exp / 1000;
        
        return lvl; 
    }
}
