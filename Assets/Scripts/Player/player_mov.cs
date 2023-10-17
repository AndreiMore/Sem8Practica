using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player_mov : MonoBehaviour
{
    Rigidbody2D rgb;

    [SerializeField]
    float speed;

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
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rgb.velocity = new Vector2(horizontal, vertical) * speed;
    }
}
