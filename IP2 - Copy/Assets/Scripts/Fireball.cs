using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public int damage = 10;
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player2 Player2 = hitInfo.GetComponent<Player2>();
        if (Player2 != null)
        {
            Player2.TakeDamage(damage);
        }
    }
}
