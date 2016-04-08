using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatusGUI : GameController {
	public Text ExText;
	public Text SpText;
	public Text InvText;

	void Start () {
	}
	
	void Update() {
		ItemPow ();
	}

	void ItemPow(){
		switch (ExPow){
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
		switch (SpPow){
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
		switch (Invent){
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
