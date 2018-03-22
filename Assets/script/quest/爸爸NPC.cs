using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 爸爸NPC : MonoBehaviour {
    public int TextBoxOnCheck = 0;
    public GameObject MessageBox; //Answer panel
    public GameObject TextBox;  // answer box
    public string TextMessage;


    void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = TextMessage;
        }

        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
            TextMessage = "I am your dad anyway";
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            if (TextBoxOnCheck == 1)
            {
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
                TextMessage = "I am your dad anyway";
            }
        }

        if (Input.GetButtonDown("Cancel"))
        {
            if (TextBoxOnCheck == 1)
            {
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
                TextMessage = "I am your dad anyway";
            }
        }
    }
}