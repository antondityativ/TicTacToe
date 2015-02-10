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

	void Start() {
		//NewGame ();
	}

	void Update () {
		GameObject otherObject = GameObject.Find("otherObject");
		Touches addObj = (Touches) otherObject.GetComponent(typeof(Touches));
		addObj.Touch (); 
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

//	public void AI(){
//				Application.LoadLevel ("Untitled");
//				Debug.Log ("Игра НАЧАЛАСЬ");
//				p = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));
//				if (Input.GetMouseButtonDown (0)) {
//						if (p.x <= -1.48f && p.x >= -1.85f && p.y >= 1.29f && p.y <= 1.45f && matrix [1, 1] == 0) {
//				
//								if (i % 2 == 1) {
//										Instantiate (oFigure, p, Quaternion.identity);
//										matrix [1, 1] = 2;
//						} 
//								
//						}
//		}
//						if (matrix [1, 1] == 0) {
//								if(i%2==0){
//								Instantiate (oFigure,new Vector3 (0.11f, -0.147f, 0), Quaternion.identity);
//						} else if (matrix [1, 1] == 2) {
//								
//					Debug.Log ("Другое место!");//Instantiate (oFigure,Random.Range(Vector3(),Vector3()));
//				}
//			i += 1;
//
//			}
//		
				

//}
	}