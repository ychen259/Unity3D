using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCScriptEnd : MonoBehaviour
{

    public int TextBoxOnCheck = 0;
    public GameObject MessageBox; //Answer panel
    public GameObject TextBox;  // answer box
    public string TextMessage;
    public GameObject QuestBox;  // question panel
    public GameObject QuestText; // anwer box

    void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text  = TextMessage;
            QuestBox.SetActive(false);
        }

        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
            TextMessage = "谢谢傻瓜";
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
                TextMessage = "谢谢傻瓜";
            }
        }

        if (Input.GetButtonDown("Cancel"))
        {
            if (TextBoxOnCheck == 1)
            {
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
                TextMessage = "谢谢傻瓜";
            }
        }
    }
}
