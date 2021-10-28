using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float Speed;
    public Vector3 initialPosition;
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Player>() != null)
        {
            FindObjectOfType<Score>().addScore();
        }

    }
    void Start()
    {
        transform.position = new Vector2(transform.position.x, Random.Range(-2f, 4f));
        initialPosition = transform.position;
    }

    public void relaunchObject()
    {
        transform.position = initialPosition;
    }
    void Update()
    {
        transform.position -= Vector3.right * Speed * Time.deltaTime;
    }
}
