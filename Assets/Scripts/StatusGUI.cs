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
		ExText.text = "Pow : " + I1.ToString();
		SpText.text = "SP   : " + I2.ToString();
		InvText.text = "Num : " + I3.ToString();
	}

	void CountDown(){
		if (timer > 0) {
			timer -= 1f * Time.deltaTime;
			timerText.text = "残り時間 : " + ((int)timer).ToString ();
		}
	}
}
