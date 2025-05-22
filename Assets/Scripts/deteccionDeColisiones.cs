using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionDeColisiones : MonoBehaviour
{
    private void OnCollisionEnter() // funcion para que suceda algo cuando suceda una colision
    {
        Debug.Log("Contacto");
        Destroy(gameObject); // destroy hace que desaparezca
    }
}
