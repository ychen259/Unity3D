using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCScriptActive : MonoBehaviour {

    public int TextBoxOnCheck = 0;
    public GameObject MessageBox; //Answer panel
    public GameObject TextBox;  // answer box
    public string TextMessage;
    public GameObject QuestBox;  // question panel
    public GameObject QuestText; // anwer box

    public GameObject BagToShow;

    void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = TextMessage;
            QuestText.GetComponent<Text>().text = "帮我找下背包，好像在房子里面？";
            QuestBox.SetActive(true);

            BagToShow.SetActive(true);
     }

        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
            TextMessage = "我的背包在房子里面";
      }
    }

    void Update()
    {
         if (Input.GetButtonDown("Submit")){
            if (TextBoxOnCheck == 1){
               MessageBox.SetActive(false);
               TextBoxOnCheck = 0;
               TextMessage = "我的背包在房子里面";
            }
         }

        if (Input.GetButtonDown("Cancel")){
             if (TextBoxOnCheck == 1){
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
                TextMessage = "我的背包在房子里面";
             }
        }
    }﻿
}
