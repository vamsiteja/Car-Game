﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {
	
	public Button[] buttons;
//	public Text scoreText;


	int score;


	// Use this for initialization
	void Start () {
	/*	gameOver = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);
		*/


	}
	
	// Update is called once per frame
	void Update () {
		/*if(gameOver==false)
		scoreText.text = "Score: " + score; */


	}

/*	void scoreUpdate(){
		if (gameOver == false) {
			score += 1;
		}
	}
*/


	public void Play(){
		Application.LoadLevel ("carpic");
	}
	public void replay(){
		Application.LoadLevel ("carpic");
	}
	public void Pause(){

		if (Time.timeScale == 1) {
			Time.timeScale = 0;

		}
		else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}
	
	public void Menu(){

	//	Application.LoadLevel ("menu");
	}
	public void Exit(){
		Application.Quit ();
	}



}
