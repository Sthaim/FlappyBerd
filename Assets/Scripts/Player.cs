using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public float maxSpeedYUp;

    public float maxSpeedYDown;

    public float jumpForce;

    public float rotSpeed;

    public Vector3 initialPosition;
    // Update is called once per frame

    void Start()
    {
        initialPosition = transform.position;
    }
    void Update()
    {
        Rigidbody2D _rigid = GetComponent<Rigidbody2D>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);

        }
        if (_rigid.velocity.y > maxSpeedYUp)
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedYUp);
        }

        if (_rigid.velocity.y < maxSpeedYDown)
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, maxSpeedYDown);
        }
        transform.rotation = Quaternion.Euler(0,0, _rigid.velocity.y * rotSpeed);
        

    }
    public void relaunchObject()
    {
        transform.position = initialPosition;
        gameObject.SetActive(true);
    }
}
