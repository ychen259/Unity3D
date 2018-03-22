using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public float totarget;
    public float range = 2;
    public GameObject door;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
             RaycastHit hit;
             if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
             {
                 totarget = hit.distance;
                 if (totarget < range)
                 {
                    hit.transform.SendMessage("OpenTheDoor", SendMessageOptions.DontRequireReceiver);
                }
             }
        }
    }
}
