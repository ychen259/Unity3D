﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRotate : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0.5f , 0, Space.World);
	}
}
