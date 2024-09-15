using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios3_7 : MonoBehaviour
{
    [SerializeField] int bse;
    [SerializeField] int altura;
    // Start is called before the first frame update
    void Start()
    {
        Area();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Area() {
        double cArea = ((bse*altura)/2);

        Debug.Log("El Area es=  "+cArea);
        
    }
}
