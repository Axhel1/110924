using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_11 : MonoBehaviour
{
    [SerializeField]int num;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tabla del: " + num);
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(num + " X " + i + " = "+ (num*i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
