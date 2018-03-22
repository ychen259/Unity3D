using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingEnemy : MonoBehaviour {

    public int hitpoints = 10;
    public float totarget;
    public float range = 2;
    void Update()
    {
        /*Keyboard down and attack the rat*/
        if ((Input.GetButtonDown("Attack") && AxeInfoPanel.hasAxe) || (Input.GetMouseButtonDown(0)&& AxeInfoPanel.hasAxe))
        {

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                totarget = hit.distance;
                if (totarget < range)
                {
                        
                    hit.transform.SendMessage("DeductPoints", hitpoints, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
