using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIInteractionMessage;
    public bool canInteract;
    public deteccionDeColisiones colisiones;
    public scoreManager scoreManager;
    public int points;

    void Start()
    {
        UIInteractionMessage.SetActive(false);
        scoreManager = FindObjectOfType<scoreManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract) 
            {
                Destroy(colisiones.gameObject);
                scoreManager.AddScore(points);
                EndInteraction();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
       // Debug.Log(other.gameObject.name);
        colisiones = other.GetComponent<deteccionDeColisiones>();
        if (colisiones)
        {
            UIInteractionMessage.SetActive(true);
            canInteract = true;
        }
       
    }

    void OnTriggerExit(Collider other)
    {
        EndInteraction();
        
    }

    void EndInteraction()
    {
        UIInteractionMessage.SetActive(false);
        colisiones = null;
        canInteract = false;
    }
}
