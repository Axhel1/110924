using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] float danhoMinimo;
    [SerializeField] float danhoM�ximo;
    [SerializeField] float total;
    [SerializeField] bool esAutom�tica;
    float muncionActual;

    // Start is called before the first frame update
    void Start()
    {
     muncionActual=total;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UtilizarArma() {

       
    }
}
