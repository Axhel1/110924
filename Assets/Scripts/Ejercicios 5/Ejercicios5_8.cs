using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_8 : MonoBehaviour
{
    [SerializeField] int H;
    [SerializeField] int M;
    [SerializeField] int S;
    // Start is called before the first frame update
    void Start()
    {
        if ((H >= 0&&H <24) && (M >= 0 && H < 60) && (S >= 0 && S < 60))
        {
            Debug.Log("Son las: " +H+":"+M+":"+S);

        }
        else {
            Debug.Log("La hora es incorrecta");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
