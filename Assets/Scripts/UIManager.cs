using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject buttonRestart;
    // Start is called before the first frame update
    public void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
        buttonRestart.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void triggerGameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
        buttonRestart.gameObject.SetActive(true);
    }
    void Update()
    {
        
    }
}
