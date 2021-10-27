using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Player>() != null)
        {
            p_collision.gameObject.SetActive(false);
            p_collision.transform.position = new Vector2(100f, 100f);
            FindObjectOfType<UIManager>().triggerGameOver();
            p_collision.gameObject.SetActive(true);
        }
        
          

    }
}
