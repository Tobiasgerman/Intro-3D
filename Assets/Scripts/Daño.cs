using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    public HealtManager healtManager;
    void Start()
    {
        healtManager = FindObjectOfType<HealtManager>();

    }

    private void OnCollisionEnter(Collision col) // funcion para que suceda algo cuando suceda una colision
    {
        Debug.Log("Contacto");

        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            healtManager.Takedamage(10);
        }
    }

}
