using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Pipe>() != null)
        {
            p_collision.transform.position = new Vector2(8.5f , Random.Range(-2f, 4f));
            Debug.Log("bitch");

        }
        Debug.Log("bitch");



    }
}
