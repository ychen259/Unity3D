using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startScript : MonoBehaviour {
    public GameObject questBox;
    public GameObject questUpdate;
    public GameObject playertext;
    public GameObject textBox;

	// Use this for initialization
	void Start () {
        questBox.SetActive(true);
        questUpdate.GetComponent<Text>().text = "Active Quest: Take a look the map!";
        StartCoroutine(WaitForSeconds1());

	}
	
    IEnumerator WaitForSeconds1()
    {
        yield return new WaitForSeconds(3);
        textBox.SetActive(true);
        playertext.GetComponent<Text>().text = "Hello 金鱼陈！欢迎来到我的世界！";
        StartCoroutine(WaitForSeconds2());
    }

    IEnumerator WaitForSeconds2()
    {
        yield return new WaitForSeconds(1);
        playertext.GetComponent<Text>().text = "大傻瓜金鱼佬！";
        StartCoroutine(WaitForSeconds3());
    }

    IEnumerator WaitForSeconds3()
    {
        yield return new WaitForSeconds(2);
        questBox.SetActive(false);
        playertext.GetComponent<Text>().text = "";
        textBox.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
