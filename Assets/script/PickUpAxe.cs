using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpAxe : MonoBehaviour
{
    public float TheDistance = DistanceToAxe.DistanceFromTarget;
    public GameObject TextBox;
    public GameObject TextDisplay;
    public GameObject RealAxe;
    public GameObject inventorybutton;

    void Update()
    {
        TheDistance = DistanceToAxe.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 5)
        {
            TextBox.SetActive(true);
            TextDisplay.GetComponent<Text>().text = "Take Axe";
        }
    }

    void OnMouseExit()
    {
        TextBox.SetActive(false);
        TextDisplay.GetComponent<Text>().text = "";
    }

    void OnMouseDown()
    {
        if (TheDistance <= 5)
        {
            TextBox.SetActive(false);
            transform.position = new Vector3(0, -1000, 0);
            inventorybutton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}