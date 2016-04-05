using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class MessageGUI : MonoBehaviour {
	GameObject player;
	public Text MessageText;		//テキストの中身を変える
	public GameObject MessageObject;//メッセージのオンオフ

	public Text HiTimeText;
	public Text ClearTimeText;		//テキストの中身を変える
	public GameObject ResultObject;//メッセージのオンオフ

	private List<int> intList = new List<int>();    //int型のリスト


	void Start () {
		SwitchList ();
		msee0 ();
	}
	void SwitchList(){
		for(int i = 0;i < 10;i++){
			intList.Add(0);
		}
	}

	void Update () {
		mess1 ();
		mess2 ();
		mess3 ();
		mess4 ();
		mess5 ();
		mess6 ();
		Gooal ();
		ItemMess();
	}

	void msee0(){
		MessageText.text = "おみっちゃんに会いに行くぜ！";
		MessageObject.SetActive (true);
		Invoke("OnMessage", 3f);
	}

	void mess1(){
		player = GameObject.Find ("Player");
		bool tri1 = player.GetComponent<ContactTrigger> ().Trigger00;
		if (tri1 == true && intList[0] == 0) {
			MessageText.text = "あそこにイイ物が落ちてるぜ！";
			MessageObject.SetActive (true);
			intList[0] = 1;
			CancelInvoke ("OnMessage");
			Invoke("OnMessage", 3f);
			Invoke("messtext", 3f);
		}
	}

	public void messtext(){
		MessageText.text = "拾ってみるんだぜ！";
		MessageObject.SetActive (true);
		CancelInvoke ("OnMessage");
		Invoke("OnMessage", 3f);
	}

	void mess2(){
		player = GameObject.Find ("Player");
		bool tri2 = player.GetComponent<ContactTrigger> ().Trigger01;
		if (tri2 == true && intList[1] == 0) {
			MessageText.text = "これじゃあ、通れないぜ";
			MessageObject.SetActive (true);
			intList[1] = 1;
			CancelInvoke ("OnMessage");
			Invoke("OnMessage", 3f);
			Invoke("messtext2", 3f);
		}
	}

	public void messtext2(){
		MessageText.text = "そうだ！花火を置こう！";
		MessageObject.SetActive (true);
		CancelInvoke ("OnMessage");
		Invoke("OnMessage", 3f);
	}

	void mess3(){
		int count = GameObject.FindGameObjectsWithTag ("Box").Length;
		if(count == 7 && intList[2] == 0){
			MessageText.text = "これで通れるぜ！";
			MessageObject.SetActive (true);
			intList[2] = 1;
			CancelInvoke ("OnMessage");
			Invoke("OnMessage", 3f);
			Invoke("messtext3", 3f);
		}
	}

	public void messtext3(){
		MessageText.text = "樽や敵を倒すと稀に道具がでるぜ！";
		MessageObject.SetActive (true);
		CancelInvoke ("OnMessage");
		Invoke("OnMessage", 3f);
	}

	void mess4(){
		player = GameObject.Find ("Player");
		bool tri3 = player.GetComponent<ContactTrigger> ().Trigger02;
		if (tri3 == true && intList[6] == 0) {
			MessageText.text = "道に石を置いてるヤツがいる！";
			MessageObject.SetActive (true);
			intList[6] = 1;
			CancelInvoke ("OnMessage");
			Invoke("OnMessage", 3f);
			Invoke("messtext4", 3f);
		}
	}

	public void messtext4(){
		MessageText.text = "花火でぶっとばそう！";
		MessageObject.SetActive (true);
		CancelInvoke ("OnMessage");
		Invoke("OnMessage", 3f);
	}

	void mess5(){
		player = GameObject.Find ("Player");
		bool tri4 = player.GetComponent<ContactTrigger> ().Trigger03;
		if (tri4 == true && intList[7] == 0) {
			MessageText.text = "手形が落ちてるぜ！";
			MessageObject.SetActive (true);
			intList[7] = 1;
			CancelInvoke ("OnMessage");
			Invoke("messtext5", 3f);
			Invoke("OnMessage", 3f);
		}
	}

	public void messtext5(){
		MessageText.text = "取ると次に行けるんだぜ！";
		MessageObject.SetActive (true);
		CancelInvoke ("OnMessage");
		Invoke("OnMessage", 3f);
	}
		
	void mess6(){
		int count = GameObject.FindGameObjectsWithTag ("Enemy").Length;
		if(count == 0 && intList[9] == 0){
			MessageText.text = "ぶっとばしたぜ！";
			MessageObject.SetActive (true);
			intList[9] = 1;
			CancelInvoke ("OnMessage");
			Invoke("OnMessage", 3f);
		}
	}

	void Gooal(){
		player = GameObject.Find ("Player");
		bool tri4 = player.GetComponent<ContactTrigger> ().GoalArea;
		if (tri4 == true && intList[8] == 0) {
			MessageText.text = "おみっちゃん待っててくれ！";
			MessageObject.SetActive (true);
			intList[8] = 1;
			CancelInvoke ("OnMessage");
			CancelInvoke ("messtext5");
			Invoke("OnMessage", 3f);
			Invoke("OnClear", 3f);
		}
	}
	void OnClear(){
		ResultObject.SetActive (true);
	}

	void ItemMess(){
		player = GameObject.Find ("Player");
		bool tri2 = player.GetComponent<ContactTrigger> ().ItemTrigger1;
		bool tri3 = player.GetComponent<ContactTrigger> ().ItemTrigger2;
		bool tri4 = player.GetComponent<ContactTrigger> ().ItemTrigger3;
		if (tri2 == true && intList[3] == 0) {
			MessageText.text = "火力が強くなった！";
			MessageObject.SetActive (true);
			intList[3] = 1;
			CancelInvoke ("OnMessage");
			CancelInvoke ("messtext");
			Invoke("OnMessage", 3f);
		}
		if (tri3 == true && intList[4] == 0) {
			MessageText.text = "足が速くなった！";
			MessageObject.SetActive (true);
			intList[4] = 1;
			CancelInvoke ("OnMessage");
			CancelInvoke ("messtext");
			Invoke("OnMessage", 3f);
		}
		if (tri4 == true && intList[5] == 0) {
			MessageText.text = "沢山持てるようになった！";
			MessageObject.SetActive (true);
			intList[5] = 1;
			CancelInvoke ("OnMessage");
			CancelInvoke ("messtext");
			Invoke("OnMessage", 3f);
		}
	}
	public void OnMessage(){
			MessageObject.SetActive (false);
	}
}
