using UnityEngine;
using System.Collections;

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


	public void ComputerStep() {
		p = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));
		if (step == 0) {			
			if (Input.GetMouseButtonDown (0)) {
				if (p.x <= 0.32f && p.x >= -0.11f && p.y >= -0.85f && p.y <= 1.14f && matrix [1, 1] == 0) {
					if (i % 2 == 0) {
						Instantiate(xFigure, p, Quaternion.identity);
						matrix [1, 1] = 1;

					}
				}
				step = 1;
				i+=1;
			}
		}
	
		if (step == 1) {
			print("Ход компьютера");
			if (matrix [1, 1] == 0) {
				if (i % 2 == 1) {
					Instantiate(oFigure, new Vector3 (0.11f, -0.147f, 0), Quaternion.identity);
					matrix[1,1] = 2;
				} else {
					Instantiate (xFigure, new Vector3 (0.11f, -0.147f, 0), Quaternion.identity);
					matrix[1,1] = 2;
				}
			}
			if (matrix [1, 1] == 1 || matrix [1, 1] == 2) {
				if (i % 2 == 1) {
					Instantiate(oFigure, new Vector3 (2.0f, 1.45f, 0), Quaternion.identity);
				} else {
					Instantiate(xFigure, new Vector3 (2.0f, 1.45f, 0), Quaternion.identity);
				}
			}
			i += 1;
			step = 0;
		}
	}
}
