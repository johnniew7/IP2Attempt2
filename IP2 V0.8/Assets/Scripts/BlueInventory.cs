using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueInventory : MonoBehaviour
{
    public static bool BlueInventoryIsActive = false;

    public GameObject blueInventoryUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (BlueInventoryIsActive)
            {
                ResumePlay();
            }
            else
            {
                BlueInventoryOpen();
            }
        }
    }

    void ResumePlay()
    {
        blueInventoryUI.SetActive(false);
        BlueInventoryIsActive = false;
    }

    void BlueInventoryOpen()
    {
        blueInventoryUI.SetActive(true);
        BlueInventoryIsActive = true;
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
