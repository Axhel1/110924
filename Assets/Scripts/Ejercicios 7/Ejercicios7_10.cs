using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_10 : MonoBehaviour
{
    [SerializeField]int num1;
    [SerializeField]int num2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = num1; i <= num2; i++)
        {

            if (i % 2 == 0 && i >=0)
            {
                Debug.Log(i + " Par Positivo");
            }
            else if (i % 2 == 1 && i >= 0) 
            {
                Debug.Log(i + " Impar Positivo");
            }
            else if (i % 2 == 0 && i < 0)
            {
                Debug.Log(i + " Par Negativo");
            }
            else if (i % 2 == -1 && i < 0)
            {
                Debug.Log(i + " Impar Negativo");
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
