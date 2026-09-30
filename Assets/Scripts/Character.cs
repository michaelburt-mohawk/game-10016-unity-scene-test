using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D _rigidbody;

    void Awake()
    {
        _rigidbody= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        _rigidbody.velocity = new Vector2(input * moveSpeed, _rigidbody.velocity.y);
    }
}
