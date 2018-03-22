using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeInfoPanel : MonoBehaviour {

    public GameObject realAxe;
    public static bool hasAxe = false;
    public GameObject cursor;

    public void itemEquip()
    {
        realAxe.SetActive(true);
        cursor.SetActive(true);
        hasAxe = true;
        gameObject.SetActive(false);
    }
	
	public void itemCancel() {
        hasAxe = false;
        gameObject.SetActive(false);
    }
}
