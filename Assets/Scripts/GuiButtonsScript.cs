﻿using UnityEngine;
using System.Collections;

public class GuiButtonsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (GUI.Button (new Rect (10, 10, 50, 30), "restart"))
			Application.LoadLevel ("game");		
		if (GUI.Button (new Rect (Screen.width-10-50, 10, 50, 30), "Menu"))
			Application.LoadLevel ("menu");		
	}
}
