using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap001 : MonoBehaviour {


    public Transform wraptarget;

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "wrap001")
        {
            this.transform.position = wraptarget.position;
        }


    }
}
