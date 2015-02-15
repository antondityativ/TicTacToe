using UnityEngine;
using System.Collections.Generic;
using System;
public class NewObject: MonoBehaviour {

	public GameObject xFigure;
	public GameObject oFigure;
	public GameObject WinLine;
	private int i;
	private int [,] matrix = new int[3,3];
	private Vector3 p;
	private string winerName;
	private int xWins;
	private int oWins;
	private int draws;
	private bool gamePause;
	private bool gamefinish;
	private int number = 0;


	public void AddObject() {
	
	p = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));
	if (p.x <= -1.48f && p.x >= -1.85f && p.y >= 1.29f && p.y <= 1.45f && matrix [0, 0] == 0) {
		
		if (i % 2 == 1) {
			Instantiate (oFigure, p, Quaternion.identity);
			matrix [0, 0] = 2;
			
		} else {
			Instantiate (xFigure, p, Quaternion.identity);
			matrix [0, 0] = 1;
			
		}
		i += 1;
		number ++;
		WhoWin ();
	}
	if (p.x <= 0.32f && p.x >= -0.11f && p.y >= 1.29f && p.y <= 1.45f && matrix [0, 1] == 0) {
		if (i % 2 == 1) {
			Instantiate (oFigure, p, Quaternion.identity);
			matrix [0, 1] = 2;
			
		} else {
			Instantiate (xFigure, p, Quaternion.identity);
			matrix [0, 1] = 1;
			
		}
		i += 1;
		number ++;
		WhoWin ();
	}
	if (p.x <= 2.0f && p.x >= 1.7f && p.y >= 1.29f && p.y <= 1.45f && matrix [0, 2] == 0) {
		if (i % 2 == 1) {
			Instantiate (oFigure, p, Quaternion.identity);
			matrix [0, 2] = 2;
			
		} else {
			Instantiate (xFigure, p, Quaternion.identity);
			matrix [0, 2] = 1;
			
		}
		i += 1;
		number ++;
		WhoWin ();
	}
	if (p.x <= -1.48f && p.x >= -1.85f && p.y >= -0.85f && p.y <= 1.14f && matrix [1, 0] == 0) {
		if (i % 2 == 1) {
			Instantiate (oFigure, p, Quaternion.identity);
			matrix [1, 0] = 2;
			
		} else {
			Instantiate (xFigure, p, Quaternion.identity);
			matrix [1, 0] = 1;
			
		}
		i += 1;
		number ++;
		WhoWin ();
	}
	if (p.x <= 0.32f && p.x >= -0.11f && p.y >= -0.85f && p.y <= 1.14f && matrix [1, 1] == 0) {
		if (i % 2 == 1) {
			Instantiate (oFigure, p, Quaternion.identity);
			matrix [1, 1] = 2;
			
		} else {
			Instantiate (xFigure, p, Quaternion.identity);
			matrix [1, 1] = 1;
			
		}
		i += 1;
		number ++;
		WhoWin ();
		
	}
	if (p.x <= 2.0f && p.x >= 1.7f && p.y >= -0.85f && p.y <= 1.14f && matrix [1, 2] == 0) {
		if (i % 2 == 1) {
			Instantiate (oFigure, p, Quaternion.identity);
			matrix [1, 2] = 2;
			
		} else {
			Instantiate (xFigure, p, Quaternion.identity);
			matrix [1, 2] = 1;
			
		}
		i += 1;
		number ++;
		WhoWin ();
	}
	if (p.x <= -1.2f && p.x >= -2.47f && p.y >= -2.01f && p.y <= -1.06f && matrix [2, 0] == 0) {
		if (i % 2 == 1) {
			Instantiate (oFigure, p, Quaternion.identity);
			matrix [2, 0] = 2;
			
		} else {
			Instantiate (xFigure, p, Quaternion.identity);
			matrix [2, 0] = 1;
			
		}
		i += 1;	
		number ++;
		WhoWin ();
	}
	if (p.x <= 0.5f && p.x >= -0.5f && p.y >= -2.01f && p.y <= -1.06f && matrix [2, 1] == 0) {
		if (i % 2 == 1) {		
			Instantiate (oFigure, p, Quaternion.identity);
			matrix [2, 1] = 2;
			
		} else {
			Instantiate (xFigure, p, Quaternion.identity);
			matrix [2, 1] = 1;
			
		}
		i += 1;
		number ++;
		WhoWin ();
	}
	if (p.x <= 2.2f && p.x >= 1.2f && p.y >= -2.01f && p.y <= -1.06f && matrix [2, 2] == 0) {
		if (i % 2 == 1) {		
			Instantiate (oFigure, p, Quaternion.identity);
			matrix [2, 2] = 2;
			
		} else {
			Instantiate (xFigure, p, Quaternion.identity);
			matrix [2, 2] = 1;
			
		}
		i += 1;
		number ++;
		WhoWin ();
	}
}
	private void WhoWin() {
		for (int i=1; i<=2; i++) {
			if(matrix[0,0]==i && matrix[0,1]==i && matrix[0,2]==i) {
				Instantiate(WinLine,new Vector3(0.38f, 1.3f, -1f),new Quaternion(0,0,90,90));
				EndGame(i);
			}
			else if(matrix[0,0]==i && matrix[1,0]==i && matrix[2,0] == i) {
				Instantiate(WinLine,new Vector3(-1.52f, 0f, -1f),new Quaternion(0,0,0,90));
				EndGame(i);
			}
			else if(matrix[0,0]==i && matrix[1,1]==i && matrix[2,2]==i) {
				Instantiate(WinLine,new Vector3(0f, 0f, -1f),new Quaternion(0,0,45,90));
				EndGame(i);
			}
			else if(matrix[0,1]==i && matrix[1,1]==i && matrix[2,1]==i) {
				Instantiate(WinLine,new Vector3(0f, 0f, -1f),new Quaternion(0,0,0,90));
				EndGame(i);
			}
			else if(matrix[0,2]==i && matrix[1,2]==i && matrix[2,2]==i) {
				Instantiate(WinLine,new Vector3(1.92f, 0f, -1f),new Quaternion(0,0,0,90));
				EndGame(i);
			}
			else if(matrix[0,2]==i && matrix[1,1]==i && matrix[2,0]==i) {
				Instantiate(WinLine,new Vector3(0.1f, -0.13f, -1f),new Quaternion(0,0,-45,90));
				EndGame(i);
			}
			else if(matrix[2,0]==i && matrix[2,1]==i && matrix[2,2]==i) {
				Instantiate(WinLine,new Vector3(0.14f, -1.7f, -1f),new Quaternion(0,0,90,90));
				EndGame(i);
			}
			else if(matrix[1,0]==i && matrix[1,1]==i && matrix[1,2]==i) {
				Instantiate(WinLine,new Vector3(0.14f, -0.25f, -1f),new Quaternion(0,0,90,90));
				EndGame(i);
			}
		    if(number == 9) {
				EndGame(2);
			}
		}
	}
	private void EndGame(int winerIndex) {
		if (winerIndex == 1)
		{
			winerName = "X Won!";
			xWins++;
		}
		else if (winerIndex == 0)
		{
			winerName = "0 Won!";
			oWins++;
		}
		else
		{
			winerName = "It's a draw!";
			draws++;
		}
		gamefinish = true;
		
	}

	private void GuiGroup() {	
		if (gamefinish) {
			GUI.Window(0, new Rect(Screen.width / 2f - 100f, Screen.height / 2f - 35f, 200, 70), GameFinishWindow, "Result");
			if (GUI.Button (new Rect (Screen.width / 2f - 100f, Screen.height / 2f + 50f, 200, 70), "Restart")) {
				Application.LoadLevel ("gameScene");
			}
		}
		
		GUI.Box(new Rect(Screen.width / 2f - 50, Screen.height - 50f, 100, 150), "Score");
		GUI.Label(new Rect(Screen.width / 2f - 90, Screen.height - 30f, 180, 40), String.Format("{0} {3}; {1} {4}; {2} {5}", "X Wins:", "O Wins", "Draws:", xWins, oWins, draws));
	}
	
	void GameFinishWindow(int windowId) {
		GUI.Label(new Rect(30, 20, 200, 80), "<size=30>" + winerName + "</size>");
	}

	void OnGUI() {
		GuiGroup();
	}
}