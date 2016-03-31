using UnityEngine;
using System.Collections;

public class GameTutorialButtonScript : MonoBehaviour {

	public void ToTutorial() {
		Application.LoadLevel ("Tutorial");
	}

}
