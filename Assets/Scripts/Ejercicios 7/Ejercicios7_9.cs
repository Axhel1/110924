using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_9 : MonoBehaviour
{
    [SerializeField]int num;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= num; i++) {

            if (i % 2 == 0){
                Debug.Log(i + " Par");
            }
            

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
