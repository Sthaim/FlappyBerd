using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void relaunchGame()
    {
        Player _player = FindObjectOfType<Player>();
        _player.relaunchObject();
        Pipe[] _pipe = FindObjectsOfType<Pipe>();
        foreach (Pipe boi in _pipe)
        {
            boi.relaunchObject();
        }
        FindObjectOfType<UIManager>().Start();
        FindObjectOfType<Score>().resetScord();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
