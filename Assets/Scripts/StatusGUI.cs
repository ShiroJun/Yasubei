using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatusGUI : MonoBehaviour {


	GameObject gameController;
	public Text ExText;
	public Text SpText;
	public Text InvText;

	void Start () {
		
	}
	
	void Update() {
		ItemPow ();

	}

	void ItemPow(){
		gameController = GameObject.Find ("GameController");									//クラスの指名
		int I1 = gameController.GetComponent<GameController> ().ExPow;
		int I2 = gameController.GetComponent<GameController> ().SpPow;
		int I3 = gameController.GetComponent<GameController> ().Invent; 

		switch (I1){
		case 1:
			ExText.text = "壱";
			break;
		case 2:
			ExText.text = "弐";
			break;
		case 3:
			ExText.text = "参";
			break;
		case 4:
			ExText.text = "四";
			break;
		case 5:
			ExText.text = "最大";
			break;
		default:;
			break;
		}
		switch (I2){
		case 1:
			SpText.text = "壱";
			break;
		case 2:
			SpText.text = "弐";
			break;
		case 3:
			SpText.text = "参";
			break;
		case 4:
			SpText.text = "四";
			break;
		case 5:
			SpText.text = "最大";
			break;
		default:;
			break;
		}
		switch (I3){
		case 1:
			InvText.text = "壱";
			break;
		case 2:
			InvText.text = "弐";
			break;
		case 3:
			InvText.text = "参";
			break;
		case 4:
			InvText.text = "四";
			break;
		case 5:
			InvText.text = "最大";
			break;
		default:;
			break;
		}
	}
}
