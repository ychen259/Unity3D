using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    void Update()
    {
        /*J button or left click the mouse*/
        if (Input.GetButtonDown("Attack") || Input.GetMouseButtonDown(0))
        {
            GetComponent<Animation>().Play("AttackAnimation");
        }
    }

}
