using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;

public class GameManager : MonoBehaviour
{
    [SerializeField]Personaje axel;
    [SerializeField]Personaje joan;
    int contador = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (contador < 2)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                PrepararPersonajes(axel, "axel", 100, 1000.5f);
            }
            contador++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrepararPersonajes(Personaje Pcrear,string nom,int hp,float exp) {

        Pcrear.Nombre = nom;
        Pcrear.Vida = hp;
        Pcrear.Experiencia= exp;

        Debug.Log(Pcrear.CalcularNivel(exp));

    }
}
