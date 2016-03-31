using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	
	public GameObject[] Items;
	public int ExPow;
	public int SpPow;
	public int Invent;

	public float timer;
	public Text timerText;
	public Text ExText;
	public Text SpText;
	public Text InvText;

	void Start(){
	}

	void Update() {
		CountDown ();
		ItemPow ();
	}

	void ItemPow(){
		ExText.text = "Pow : " + ExPow.ToString();
		SpText.text = "SP   : " + SpPow.ToString();
		InvText.text = "Num : " + Invent.ToString();
	}

	void CountDown(){
		if (timer > 0) {
			timer -= 1f * Time.deltaTime;
			timerText.text = "残り時間 : " + ((int)timer).ToString ();
		}
	}
}
