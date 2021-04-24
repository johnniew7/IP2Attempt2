using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand : MonoBehaviour
{
    public Transform spellLP;
    public GameObject spellprefab;
    public int fireballshots = 1;
    bool fireballcanshoot = true;
    public Animator animator;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && fireballcanshoot)
        {
            animator.SetBool("Fire", true);
            StartCoroutine(Timer());
            IEnumerator Timer()
            {
                yield return new WaitForSeconds(0.8f);
                animator.SetBool("Fire", false);
            }
            Shoot();
            FireballAmmo();
        }
        if (fireballshots <= 0)
        {
            fireballcanshoot = false;
            fireballshots = 1;
            StartCoroutine(Timer());
            IEnumerator Timer()
            {
                yield return new WaitForSeconds(5);
                fireballcanshoot = true;
            }
        }
    }

    void Shoot()
    {
        Instantiate(spellprefab, spellLP.position, spellLP.rotation);
    }
    public void FireballAmmo()
    {
        fireballshots -= 1;

    }
}
