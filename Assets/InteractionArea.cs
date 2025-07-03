using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIInteractionMessage;

    private void Start()
    {
        UIInteractionMessage.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        UIInteractionMessage.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        UIInteractionMessage.SetActive(false);
    }
}
