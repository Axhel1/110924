using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Ejercicios3_4 : MonoBehaviour
{
    [SerializeField] int exp;
    int lvl;
    // Start is called before the first frame update
    void Start()
    {
        Level();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Level() {

        lvl = 32 + (9 * exp / 5);
        Debug.Log("Tu nivel es "+lvl);
    }
}
