using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System;
using System.IO;

public class GameButton : MonoBehaviour
{
    public string fileName = "savegame.data";
    public string LoadCode;
    public static string GlobalLoad;
    public GameObject NoDataIsFoundMsg;

    void Start()
    {
        System.IO.StreamReader TheSave = new StreamReader(fileName);
        string line = TheSave.ReadLine();
        LoadCode = line;
        while (line != null)
        {
            LoadCode = line;
            line = TheSave.ReadLine();
        }
        TheSave.Close();
    }

    public void LoadGame()
    {
        GlobalLoad = LoadCode;

        if (GlobalLoad == "savingTheGame")
        {
            Application.LoadLevel(1);
        }
        else
        {
            NoDataIsFoundMsg.SetActive(true);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void NewGame()
    {
        GlobalLoad = "";
        Application.LoadLevel(1);
    }
}