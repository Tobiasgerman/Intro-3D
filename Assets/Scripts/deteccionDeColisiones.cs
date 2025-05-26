using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class deteccionDeColisiones : MonoBehaviour
{
    public scoreManager scoreManager;
  

    void Start()
    {
        scoreManager = FindObjectOfType<scoreManager>(); // devuelve primer componente que encuentre de ese tipo
        
    }
    private void OnCollisionEnter(Collision col) // funcion para que suceda algo cuando suceda una colision
    {
        Debug.Log("Contacto");

        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            scoreManager.AddScore();
        }
    }
}
