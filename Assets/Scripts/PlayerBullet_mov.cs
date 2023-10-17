using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet_mov : MonoBehaviour
{
    Rigidbody2D rgb;

    [SerializeField] float speed;
    [SerializeField] Vector2 direction;
    private void Awake()
    {
        rgb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        movement();
    }

    void movement()
    {
        rgb.velocity = direction * speed;
    }
}
