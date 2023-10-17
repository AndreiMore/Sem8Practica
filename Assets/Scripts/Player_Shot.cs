using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shot : MonoBehaviour
{
    Transform target;
    [SerializeField] GameObject bulletPrfb;

    [SerializeField] float timerdelay;
    float shootTimer;

    private void Update()
    {
        timer();
        shoot();
    }

    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space) && shootTimer >= timerdelay)
        {
            GameObject Obj = Instantiate(bulletPrfb);
            Obj.transform.position = transform.position;
            shootTimer = 0;
        }
    }

    void timer()
    {
        shootTimer += Time.deltaTime;
    }
}
