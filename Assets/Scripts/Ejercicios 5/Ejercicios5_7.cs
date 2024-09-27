using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_7 : MonoBehaviour
{
    [SerializeField]int vJudaor1;   
    [SerializeField]int vJudaor2;                                   
    [SerializeField]int vJudaor3;
    // Start is called before the first frame update
    void Start()
    {
        if (vJudaor1 >= vJudaor2 && vJudaor1 >= vJudaor3)
        {
            Debug.Log("Jugador 1 es mas rapido");
        }
        else if (vJudaor2 >= vJudaor1 && vJudaor2 >= vJudaor3)
        {
            Debug.Log("Jugador 2 es mas rapido");
        }
        else if (vJudaor3 >= vJudaor1 && vJudaor3 >= vJudaor2)
        {
            Debug.Log("Jugador 3 es mas rapido");
        }
        else {
            Debug.Log("Tienen la misma velicidad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
