using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_7 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = num1; i <= num2; i++) { 
        
                Debug.Log(i);
        
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
