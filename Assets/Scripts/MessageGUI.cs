using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MessageGUI : MonoBehaviour {
	GameObject player;
	public Text MessageText;		//テキストの中身を変える
	public GameObject MessageObject;//メッセージのオンオフ

	private int t1 = 0;				//スイッチ
	private int t2 = 0;
	private int t3 = 0;



	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mess1 ();
		mess2 ();
	}

	void mess1(){
		player = GameObject.Find ("Player");
		bool tri1 = player.GetComponent<ContactTrigger> ().Trigger00;
		if (tri1 == true && t2 == 0) {
			MessageText.text = "これじゃあ、通れないぜ";
			MessageObject.SetActive (true);
			t2++;
			Invoke("OnMessage", 3f);
			Invoke("messtext", 3f);
		}
	}

	public void messtext(){
		MessageText.text = "そうだ！花火を置こう！";
		MessageObject.SetActive (true);
		Invoke("OnMessage", 3f);

	}

	void mess2(){
		int count = GameObject.FindGameObjectsWithTag ("Box").Length;
		if(count == 7 && t1 == 0){
			MessageText.text = "これで通れるぜ！";
			MessageObject.SetActive (true);
			t1++;
			Invoke("OnMessage", 3f);
		}
	}

	void mess3(){
		player = GameObject.Find ("Player");
		bool tri2 = player.GetComponent<ContactTrigger> ().Trigger01;
		if (tri2 == true && t3 == 0) {
			MessageText.text = "アイテムゲット！";
			MessageObject.SetActive (true);
			t3++;
			Invoke("OnMessage", 3f);
		}
	}

	public void OnMessage(){
		MessageObject.SetActive (false);
	}
}
