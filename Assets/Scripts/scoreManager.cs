using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public UIManager uIManager;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        score = 0;
   
    }
    public void AddScore()
    {
        score ++;
        uIManager.Updatescore(score);
    }

    public void AddScore(int scorePoints)
    {
        score += scorePoints;
        uIManager.Updatescore(score);
    }

}


