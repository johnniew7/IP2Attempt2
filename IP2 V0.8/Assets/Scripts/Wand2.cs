using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand2 : MonoBehaviour
{
    public Transform spellLP;
    public GameObject spellprefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            StartCoroutine(Timer());
            IEnumerator Timer()
            {
                yield return new WaitForSeconds(0.8f);
            }
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(spellprefab, spellLP.position, spellLP.rotation);
    }
}
