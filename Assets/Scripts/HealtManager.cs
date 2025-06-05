using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealtManager : MonoBehaviour
{
    public UIManager Manager;
    public int healthPoints;
    public int maxhealthPoints;
    // Start is called before the first frame update
    void Start()
    {
        Manager = FindObjectOfType<UIManager>();
        healthPoints = maxhealthPoints;

    }
    public void Takedamage(int damagePoints)
    {
        if (healthPoints <= damagePoints)
        {
            return;
        }
        healthPoints -= damagePoints;
        Manager.Updatehealt(healthPoints);
        }
}