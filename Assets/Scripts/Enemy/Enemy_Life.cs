using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy_Life : MonoBehaviour
{
    [SerializeField] int life;

    

    void changeLife(int value)
    {
        life += value;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BulletPlayer"))
        {
            changeLife(-collision.gameObject.GetComponent<BulletDamage>().getDamage);
            Destroy(collision.gameObject);
        }
    }

}
