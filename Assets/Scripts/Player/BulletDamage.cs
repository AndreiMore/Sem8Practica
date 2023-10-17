using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField] int damage;

    public int getDamage
    {
        get
        {
            return damage;
        }
    }
}
