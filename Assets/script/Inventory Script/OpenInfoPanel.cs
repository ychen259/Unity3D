using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInfoPanel : MonoBehaviour
{

    public GameObject infoPanel;

    public void OpenPanel()
    {
        infoPanel.SetActive(true);
    }
}
