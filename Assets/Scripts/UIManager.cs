using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtHealt;
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    public void Updatescore(int score)
    {
        txtScore.text = score.ToString(); 
    }
    public void Updatehealt(int healt)
    {
        txtHealt.text = healt.ToString();
    }
}
