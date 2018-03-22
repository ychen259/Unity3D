using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagScript : MonoBehaviour {
    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public GameObject TextBox; //message
    public GameObject TaskText; // task message -- finish assignment and ask for NPC
    public GameObject QuestItemToClose; // quest start to close
    public GameObject QuestItemToShow; // quest end to active

    void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = "你找到背包了.";
            StartCoroutine(CarryOn());
        }
    }

    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        MessageBox.SetActive(false);
        QuestItemToClose.SetActive(false);
        QuestItemToShow.SetActive(true);
        TaskText.GetComponent<Text>().text = "回去告诉NPC";
    }
}
