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
        gameOverPanel.SetActive(false);
        Boutton.SetActive(false);
        StartPanel.SetActive(true);
        Time.timeScale = 0;

    }

    public void buttonSmash()
    {
        gameOverPanel.SetActive(false);
        Boutton.SetActive(false);
        StartPanel.SetActive(true);
        FindObjectOfType<GameManager>().relaunchGame();
    }

    // Update is called once per frame
    public void triggerGameOver()
    {
        gameOverPanel.SetActive(true);
        Boutton.SetActive(true);
        Time.timeScale = 0;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && StartPanel.activeSelf)
        {
            StartPanel.SetActive(false);
            FindObjectOfType<GameManager>().player.gameObject.SetActive(true);
            Time.timeScale = 1;
        }
    }
}
