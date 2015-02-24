using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using System.Collections.Generic;

public class AI : MonoBehaviour {

	private Vector3 p;

	public GameObject xFigure;
	public GameObject oFigure;
	public GameObject winLine;
	private int i;
	private int [,] matrix = new int[3,3];
	private string winerName;
	private int xWins;
	private int oWins;
	private int draws;
	private bool gamePause;
	private bool gameFinish;
	private int step = 0;
	public GameObject[] arrayGameObject = new GameObject[9];
	public GameObject[] arrayEmptyObjects = new GameObject[9];
	private int number = 0;

	private void AddPlayerObjects() {
		p = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));
		if (p.x <= -1.06f && p.x >= -2.25f && p.y >= 0.67f && p.y <= 1.98f && matrix [0, 0] == 0) {
			if (i % 2 == 0) {
				Instantiate(xFigure, p, Quaternion.identity);
				matrix [0, 0] = 1;
				i += 1;
			}
				number ++;
				WhoWin();
		}
		if (p.x <= 0.88f && p.x >= -0.67f && p.y >= 0.67f && p.y <= 1.98f && matrix [0, 1] == 0) {
			if (i % 2 == 0) {
				Instantiate(xFigure, p, Quaternion.identity);
				matrix [0, 1] = 1;
			}
				i += 1;
				number ++;
				WhoWin();
		}
		if (p.x <= 2.37f && p.x >= 1.27f && p.y >= 0.67f && p.y <= 1.98f && matrix [0, 2] == 0) {	
			if (i % 2 == 0) {
				Instantiate(xFigure, p, Quaternion.identity);
				matrix [0, 2] = 1;			
			}
				i += 1;
				number ++;
				WhoWin();
		}
		if (p.x <= -1.06f && p.x >= -2.25f && p.y >= -0.74f && p.y <= 0.3f && matrix [1, 0] == 0) {
			if (i % 2 == 0) {
				Instantiate(xFigure, p, Quaternion.identity);
				matrix [1, 0] = 1;			
			}
				i += 1;
				number ++;
				WhoWin();
		}
		if (p.x <= 0.82f && p.x >= -0.58f && p.y >= -0.74f && p.y <= 0.3f && matrix [1, 1] == 0) {
			if (i % 2 == 0) {
				Instantiate(xFigure, p, Quaternion.identity);
				matrix [1, 1] = 1;
			}
				i += 1;
				number ++;
				WhoWin();
		}
		if (p.x <= 2.36f && p.x >= 1.28f && p.y >= -0.74f && p.y <= 0.3f && matrix [1, 2] == 0) {
			if (i % 2 == 0) {
				Instantiate(xFigure, p, Quaternion.identity);
				matrix [1, 2] = 1;
			}
				i += 1;
				number ++;
				WhoWin();
		}
		if (p.x <= -1.2f && p.x >= -2.47f && p.y >= -2.01f && p.y <= -1.06f && matrix [2, 0] == 0) {
			if (i % 2 == 0) {
				Instantiate(xFigure, p, Quaternion.identity);
				matrix [2, 0] = 1;			
			}
				i += 1;	
				number ++;
				WhoWin();
		}
		if (p.x <= 0.5f && p.x >= -0.5f && p.y >= -2.01f && p.y <= -1.06f && matrix [2, 1] == 0) {
			if (i % 2 == 0) {
				Instantiate(xFigure, p, Quaternion.identity);
				matrix [2, 1] = 1;			
			}
				i += 1;
				number ++;
				WhoWin();
		}
		if (p.x <= 2.2f && p.x >= 1.2f && p.y >= -2.01f && p.y <= -1.06f && matrix [2, 2] == 0) {
			if (i % 2 == 0) {
				Instantiate(xFigure, p, Quaternion.identity);
				matrix [2, 2] = 1;			
			}
				i += 1;
				number ++;
				WhoWin();
		}

	}

	private void WhoWin() {

	}

	public void ComputerStep() {
		if (step == 0) {
			if(Input.GetMouseButtonDown(0)) {	
				AddPlayerObjects();
				step = 1;
			}
		}
		if (step == 1) {
			if (matrix [1, 1] == 0) {
				if (i % 2 == 1) {
					Instantiate (arrayGameObject [4], new Vector3 (0.11f, -0.147f, 0), Quaternion.identity);
					matrix [1, 1] = 2;
					print(matrix[1,1]);
				} 
				step = 0;
				i++;
			}
			else {
				if (i % 2 == 1) {
					Instantiate (arrayGameObject [Random.Range (1, 9)], arrayGameObject [Random.Range (1, 9)].transform.position, Quaternion.identity);
				}
				step = 0;
				i++;
			}
		}

	}
}