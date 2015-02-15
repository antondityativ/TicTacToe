using UnityEngine;
using System.Collections.Generic;
using System;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class TicTacToe : MonoBehaviour {

	private int i;
	
	private bool switchStateInfo;
	private bool switchDifficultyStateInfo;
	private string winerName;
	private int xWins;
	private int oWins;
	private int draws;
	private bool gamefinish;
	private bool gamePause;
	private bool soundOn;

	void Update () {
		GameObject otherObject = GameObject.Find("otherObject");
		MenuScript index = (MenuScript)otherObject.GetComponent (typeof(MenuScript));
		if (index.PlayerIndex == 1) {
			Touches addObj = (Touches) otherObject.GetComponent(typeof(Touches));
			addObj.Touch (); 
		}
		else {

		}
	}


	public void SoundOff() {
		GameObject oFigure = GameObject.Find("O");
		GameObject xFigure = GameObject.Find("X");
		GameObject WinLine = GameObject.Find("WinLine");
		oFigure.audio.Pause ();
		xFigure.audio.Pause ();
		WinLine.audio.Pause ();
	}

	public void BackButton(){
		Application.LoadLevel("menuScene");
	}

}