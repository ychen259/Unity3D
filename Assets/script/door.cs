using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {

     void OpenTheDoor()
    {
        Debug.Log("Hit the door");
        GetComponent<Animation>().Play("openDoor");

        GetComponent<AudioSource>().Play();
    }
}
