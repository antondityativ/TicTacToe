﻿using UnityEngine;
using System.Collections;

public class Touches : MonoBehaviour {

	public void Touch() {
	GameObject otherObject = GameObject.Find("otherObject");
	NewObject NewObject = (NewObject) otherObject.GetComponent(typeof(NewObject));
		if (Input.GetMouseButtonDown (0)) {
			NewObject.AddObject();
		}
	}
}