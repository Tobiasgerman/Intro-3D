using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitNsegundos : MonoBehaviour
{
    public float timeToWait;
    float timeElapsed;
    public Transform cuboTr;
   
    void Start()
    {
        InvokeRepeating(nameof(ElevateCube),0, timeToWait); // llamar a una funcion por su tiempo
        StartCoroutine(WaitUntilElevate());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time); // tiempo desde que se ejecuto el juego
        Debug.Log(Time.timeSinceLevelLoad); // tiempo desde que se cargo la escena
       Debug.Log(Time.deltaTime); // duracion del ultimo frame
       
        if (timeElapsed > timeToWait)
        {
            Debug.Log("tiempo cumplido");
            ElevateCube();
            timeElapsed = 0;
        }
        else
        {
            Debug.Log(timeElapsed += Time.deltaTime);
        }
    }

    IEnumerator WaitUntilElevate()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToWait); // esta linea pone una demora para la siguiente linea
            ElevateCube();
        }
    }

    void ElevateCube()
    {
        cuboTr.position += Vector3.up * 2; // vector referencia a uno de los 3 ejes X Y Z
    }
}
