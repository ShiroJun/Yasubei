using UnityEngine;
using System.Collections;

public class GameStartButtonScript : MonoBehaviour {

	// Update is called once per frame
	public void ToStage1() {
		Application.LoadLevel ("Stage1");
	}

}
