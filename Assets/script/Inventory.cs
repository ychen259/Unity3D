using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject OurInventory;
    public int InvStatus = 0;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            Debug.Log(Cursor.lockState);
            if (InvStatus == 0)
            {
                InvStatus = 1;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                OurInventory.SetActive(true);
            }
            else
            {
                InvStatus = 0;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                OurInventory.SetActive(false);
            }
        }

    }
}