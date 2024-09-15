using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios3_1 : MonoBehaviour
{
    [SerializeField]int numero1;
    [SerializeField]int numero2;
    // Start is called before the first frame update
    void Start()
    {
        valores();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void valores(){

        

        Debug.Log(numero1+"  "+numero2);
    } 
}
