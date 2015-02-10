using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public void NewGameButton() {
		Application.LoadLevel ("gameScene");
	}

	public void VSComputer(){
		//TicTacToe.AI ();
	}

	public void QuitButton() {
		Application.Quit ();
	}
}
