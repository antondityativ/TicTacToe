using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public int playerIndex = 0;

	public void NewGameButton() {
		Application.LoadLevel("gameScene");
		playerIndex = 1;
	}

	public void VSComputer(){
		Application.LoadLevel("gameScene");
		playerIndex = 2;
	}

	public void QuitButton() {
		Application.Quit();
	}
}
