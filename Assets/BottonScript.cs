using UnityEngine;
using System.Collections;

public class BottonScript : MonoBehaviour {

	public void GoTitle() {
		Application.LoadLevel ("Title");
	}
	public void GoRetry1() {
		Application.LoadLevel ("Stage1");
	}
	public void GoNext() {
		if (Application.loadedLevelName == "Stage1") {
			Application.LoadLevel ("Stage2");
		}
		else if (Application.loadedLevelName == "Stage2") {
			Application.LoadLevel ("Stage3");
		}
		else if (Application.loadedLevelName == "Stage3") {
			Application.LoadLevel ("BossStage");
		}
	}

}
