using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_8 : MonoBehaviour
{

    [SerializeField]int num1;
    [SerializeField]int num2;   
    // Start is called before the first frame update
    void Start()
    {
        for (int i=num1;i <=num2 ;i++ ) {

            if (i%2==0) {

                Debug.Log(i);
            
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
