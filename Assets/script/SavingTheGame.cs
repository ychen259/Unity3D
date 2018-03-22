using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SavingTheGame : MonoBehaviour
{

    string FileName = "savegame.data";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            var OurFile = File.CreateText(FileName);
            OurFile.WriteLine("savingTheGame");
            OurFile.Close();
        }
    }
}