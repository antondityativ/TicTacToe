using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public int PlayerIndex = 0;

	public void NewGameButton() {
		Application.LoadLevel ("gameScene");
		PlayerIndex = 1;
	}

	public void VSComputer(){
		Application.LoadLevel ("gameScene");
		PlayerIndex = 2;
	}

	public void QuitButton() {
		Application.Quit ();
	}
}
