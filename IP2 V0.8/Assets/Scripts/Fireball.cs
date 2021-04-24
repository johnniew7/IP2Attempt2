using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public int damage = 20;

    public ParticleSystem Attackfire;

    void Start()
    {
        Attackfire = GetComponent<ParticleSystem>();
    }

    public void OnParticleCollision(GameObject other)
    {
        Player2 Player2 = other.GetComponent<Player2>();
        if (Player2 != null)
        {
            Player2.TakeDamage(damage);
        }
        Player1 player1 = other.GetComponent<Player1>();
        if (player1 != null)
        {
            player1.TakeDamage(damage);
        }
    }
}