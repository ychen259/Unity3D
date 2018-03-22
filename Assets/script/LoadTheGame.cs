using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class LoadTheGame : MonoBehaviour {
    
    public GameObject ThePlayer;
    public GameObject StartScript;
    public float PlayerX = 252.2176f; //input player co-ordinates
    public float PlayerY = 26.9f; //input player co-ordinates
    public float PlayerZ = 200.7f; //input player co-ordinates
    public string LoadedCode;

    void Start()
    {
        LoadedCode = GameButton.GlobalLoad;
        if (LoadedCode == "savingTheGame")
        {
            Console.WriteLine("I am in Load THe Game");
            ThePlayer.transform.position = new Vector3(PlayerX, PlayerY, PlayerZ);
            StartScript.SetActive(false);
        }
    }
}
