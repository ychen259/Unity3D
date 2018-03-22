using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour {

    public static int CoinsCollected = 0;

    public void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(20, 10, 90, 20), "Score : " + CoinsCollected);
        GUI.Box(new Rect(20, 50, 100, 50), "Health of\n Enemy: " + EnemyScript.health);
        GUI.Button(new Rect(10, 110, 70, 30), "A button");
    }
}
