using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public void NewGameButton() {
		Application.LoadLevel ("gameScene");
	}

	public void VSComputer(){
		Application.LoadLevel ("RPSScene");
	}

	public void QuitButton() {
		Application.Quit ();
	}
}
