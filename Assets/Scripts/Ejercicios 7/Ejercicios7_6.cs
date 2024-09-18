using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_6 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= num; i++) {

            Debug.Log("Numero: "+i);
        
        }
        int j=0;
        while (j <= num) {

            Debug.Log("Numero: "+j);
            j++;
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
