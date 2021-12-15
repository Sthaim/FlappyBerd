using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }
    void Start()
    {
        player.gameObject.SetActive(false);
    }
    public void relaunchGame()
    {
        player.relaunchObject();
        Pipe[] _pipe = FindObjectsOfType<Pipe>();
        foreach (Pipe boi in _pipe)
        {
            boi.relaunchObject();
        }
        FindObjectOfType<Score>().resetScore();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
