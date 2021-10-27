using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int myScore;
    public void addScore()
    {
        myScore++;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();
    }

    public void resetScore()
    {
        myScore = 0;
        GetComponent<TextMeshProUGUI>().text = myScore.ToString();
    }
}
