﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracionArea : MonoBehaviour
{
   public GameObject UIInteractionMessage;
    public bool canInteract;
    public MercaderiaScript mercaderia;

    private void Start()
    {
        UIInteractionMessage.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canInteract) 
            {
                Destroy(mercaderia.gameObject);
            }
    }



   private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        mercaderia = other.GetComponent<MercaderiaScript>();
        if (mercaderia)
        {
            UIInteractionMessage.SetActive(true);
            canInteract = true;
        }
       
    }


    private void OnTriggerExit(Collider other)
    {
        UIInteractionMessage.SetActive(false);
        mercaderia = null;
        canInteract= false;
    }
}
}