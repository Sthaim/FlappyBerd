using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject StartPanel;
    public GameObject Boutton;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
        Boutton.gameObject.SetActive(false);
        StartPanel.gameObject.SetActive(true);
        Time.timeScale = 0;

    }

    public void buttonSmash()
    {
        Debug.Log("button");
        gameOverPanel.gameObject.SetActive(false);
        Boutton.gameObject.SetActive(false);
        StartPanel.gameObject.SetActive(true);
        FindObjectOfType<GameManager>().relaunchGame();
    }

    // Update is called once per frame
    public void triggerGameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
        Boutton.gameObject.SetActive(true);
        Time.timeScale = 0;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && StartPanel.activeSelf)
        {
            Debug.Log("oui");
            StartPanel.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
        Debug.Log(StartPanel.activeSelf);
    }
}
