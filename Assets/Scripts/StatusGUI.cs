using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatusGUI : MonoBehaviour {
	
	GameObject gameController;
	public float timer;
	public Text timerText;
	public Text ExText;
	public Text SpText;
	public Text InvText;

	void Start () {
	
	}
	
	void Update() {
		CountDown ();
		ItemPow ();
	}

	void ItemPow(){
		gameController = GameObject.Find ("GameController");									//クラスの指名
		int I1 = gameController.GetComponent<GameController> ().ExPow;
		int I2 = gameController.GetComponent<GameController> ().SpPow;
		int I3 = gameController.GetComponent<GameController> ().Invent; 

		if (I1 <= 4) {
			ExText.text = "Pow : " + I1.ToString ();
		} else if (I1 == 5) {
			ExText.text = "Pow : MAX";
			Debug.Log (I1);
		}

		if (I2 <= 4) {
			SpText.text = "SP   : " + I2.ToString();
		} else if (I2 == 5) {
			SpText.text = "SP   : MAX";
		}

		if (I3 <= 4) {
			InvText.text = "Num : " + I3.ToString();
		} else if (I3 == 5) {
			InvText.text = "Num : MAX";
		}

	}

	void CountDown(){
		if (timer > 0) {
			timer -= 1f * Time.deltaTime;
			timerText.text = "残り時間 : " + ((int)timer).ToString ();
		}
	}
}
