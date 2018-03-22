﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToAxe : MonoBehaviour
{
    public static float DistanceFromTarget;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            DistanceFromTarget = hit.distance;
        }
    }
}