using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedInventory : MonoBehaviour
{
    public static bool RedInventoryIsActive = false;

    public GameObject redInventoryUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (RedInventoryIsActive)
            {
                ResumePlay();
            }
            else
            {
                RedInventoryOpen();
            }
        }
    }


    void ResumePlay()
    {
        redInventoryUI.SetActive(false);
        RedInventoryIsActive = false;
    }

    void RedInventoryOpen()
    {
        redInventoryUI.SetActive(true);
        RedInventoryIsActive = true;
    }

    void Weapon1()
    {

    }

    void Weapon2()
    {

    }

    void Weapon3()
    {

    }

    void Weapon4()
    {

    }

    void Weapon5()
    {

    }

    void Weapon6()
    {

    }

    void Bottle1()
    {

    }

    void Bottle2()
    {

    }
    //Inventory inventory;

    //void Start()
    //{
    //inventory = Inventory.instance;
    //inventory.onItemChangedCallback += UpdateUI;
    //}

    //void Update()
    //{

    //}

    //void UpdateUI()
    //{
    //Debug.Log("UPDATING UI");
    //}
}