using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Ejercicios7_13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Es PRIMO?: "+ Primo(25));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool Primo(int num) {

        
        for (int i = 2; i <num; i++)
        {
            if (num%i == 0) {
                return false;
            }
        }


        return true;
    }

}
