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
	private bool gameFinish;
	private bool gamePause;
	private bool soundOn;
	private GameObject otherObject;
	private MenuScript index;
	private Touches addObj;
	private AI comp;

	void Awake() {
		otherObject = GameObject.Find("otherObject");
		index = (MenuScript)otherObject.GetComponent (typeof(MenuScript));
		addObj = (Touches) otherObject.GetComponent(typeof(Touches));
		comp  = (AI)otherObject.GetComponent(typeof(AI));
	}
	
	void Update () { 
		if (index.PlayerIndex == 1) {
			addObj.Touch (); 
		}
		else {
			comp.ComputerStep ();
		}
	}

	public void SoundOff() {
		GameObject oFigure = GameObject.Find("O");
		GameObject xFigure = GameObject.Find("X");
		GameObject winLine = GameObject.Find("WinLine");
		oFigure.audio.Pause ();
		xFigure.audio.Pause ();
		winLine.audio.Pause ();
	}

	public void BackButton(){
		Application.LoadLevel("menuScene");
	}

}