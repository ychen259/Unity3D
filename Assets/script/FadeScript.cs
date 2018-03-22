using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour {
    public GameObject FullBlack;
    public GameObject FadeBlack;

	// Use this for initialization
	void Start () {
        StartCoroutine(WaitFullBlack(1));
        StartCoroutine(WaitFadeBlack(0.8F));
    }

    IEnumerator WaitFullBlack(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        FadeBlack.GetComponent<Animator>().enabled = true;
        FullBlack.SetActive(false);
    }

    IEnumerator WaitFadeBlack(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        FadeBlack.GetComponent<Animator>().enabled = false;
        FadeBlack.SetActive(false);
    }
}
