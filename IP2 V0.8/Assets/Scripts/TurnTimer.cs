using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TurnTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 5f;

    [SerializeField] Text timerText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString ("0");

        if (currentTime <= 2)
        {
            timerText.color = Color.red;
        }
        if (currentTime >= 5)
        {
            timerText.color = Color.white;
        }
        
        if (currentTime <= 0)
        {
            currentTime = 5;
        }
    }
}
