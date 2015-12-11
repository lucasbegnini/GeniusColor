﻿using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	[SerializeField]
	private string Scene;
	void Start(){
		Time.timeScale = 1.0f;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(Scene.Equals("Quit"))
			{
				Application.Quit();
			}else{
				Application.LoadLevelAsync(Scene);
			}
		}
	}
}