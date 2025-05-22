using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionDeColisiones : MonoBehaviour
{
    private void OnCollisionEnter(Collision col) // funcion para que suceda algo cuando suceda una colision
    {
        Debug.Log("Contacto");

        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
