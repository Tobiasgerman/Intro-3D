using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject cubePrefab; // referenciando

    // Start is called before the first frame update
    void Start()
    {
        ClonarCubo(); // llamando la funcion 
    }

    public void ClonarCubo() // creando funcion
    {
        Instantiate(cubePrefab);
    }
}
