using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class MessageGUI : ContactTrigger {
	GameObject player;
	public Text MessageText;		//テキストの中身を変える
	public GameObject MessageObject;//メッセージのオンオフ

	public Text HiTimeText;
	public Text ClearTimeText;		//テキストの中身を変える
	public GameObject ResultObject;//メッセージのオンオフ

	public GameObject RespawnObject;
	public Text RespawnText;
	public GameObject GameOverObject;

	public float timer;
	private float timer2;
	public Text timerText;
	public Text ButtonText;

	private static List<int> intList = new List<int>();    //int型のリスト
	private bool timerflag = true;

	void Start () {

            SwitchList ();
		msee0 ();
		Awake ();
        if (Application.loadedLevelName == "Stage1")
        {
            intList[8] = 1;
        }
    }

	void Awake () {
		if (Application.loadedLevelName == "Stage1") {
			ButtonText.text = "始めに戻る";
			if (!PlayerPrefs.HasKey ("highScore1")) {
				SetKey ();
			}
		}
		if (Application.loadedLevelName == "Stage2") {
			if (!PlayerPrefs.HasKey ("highScore2")) {
				SetKey ();
			}
		}
		if (Application.loadedLevelName == "Stage3") {
			if (PlayerLife.start == 0) {
				GameController.ExPow = 1;
				GameController.SpPow = 1;
				GameController.Invent = 1;
			}
			if (!PlayerPrefs.HasKey ("highScore3")) {
				SetKey ();
			}
		}
		if (Application.loadedLevelName == "BossStage") {
			if (!PlayerPrefs.HasKey ("highScore4")) {
				SetKey ();
			}
		}
	}
	void SetKey(){
		if (Application.loadedLevelName == "Stage1") {
			PlayerPrefs.SetInt("Stage1", 999); 
		}
		if (Application.loadedLevelName == "Stage2") {
			PlayerPrefs.SetInt("Stage2", 999); 
		}
		if (Application.loadedLevelName == "Stage3") {
			PlayerPrefs.SetInt("Stage3", 999); 
		}
		if (Application.loadedLevelName == "BossStage") {
			PlayerPrefs.SetInt("BossStage", 999); 
		}

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
		Goal ();
		ItemMess();
		CountDown ();
		Respawn ();
		GameOver ();
	}
	void CountDown(){
		if (timer > 0) {
			if(timerflag == true){
				timer -= 1f * Time.deltaTime;
				timer2 += 1f * Time.deltaTime;
				timerText.text = "残り時間 : " + ((int)timer).ToString ();
			}
		}
	}

	void msee0(){
		if (Application.loadedLevelName == "Stage1") {
			MessageText.text = "おみっちゃんに会いに行くぜ！";
			MessageObject.SetActive (true);
			Invoke("OnMessage", 3f);
		}
	}

	void mess1(){
		if (Trigger00 == true && intList[0] == 0) {
			MessageText.text = "あそこにイイ物が落ちてるぜ！";
			MessageObject.SetActive (true);
			intList[0] = 1;
			CancelInvoke ("OnMessage");
			Invoke("OnMessage", 3f);
			Invoke("messtext", 3f);
			Debug.Log (Trigger00);
		}
	}

	public void messtext(){
		MessageText.text = "拾ってみるんだぜ！";
		MessageObject.SetActive (true);
		CancelInvoke ("OnMessage");
		Invoke("OnMessage", 3f);
	}

	void mess2(){
		if (Trigger01 == true && intList[1] == 0) {
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
		int count = 0;
		if (Application.loadedLevelName == "Stage1") {
			count = GameObject.FindGameObjectsWithTag ("Box").Length;
		}
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
		MessageText.text = "樽を壊すとたまに道具がでるぜ！";
		MessageObject.SetActive (true);
		CancelInvoke ("OnMessage");
		Invoke("OnMessage", 3f);
	}

	void mess4(){
		if (Trigger02 == true && intList[6] == 0) {
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
		if (Trigger03 == true && intList[7] == 0) {
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
		int count = 1;
		if (Application.loadedLevelName == "Stage1") {
			count = GameObject.FindGameObjectsWithTag ("Enemy").Length;
		}
		if(count == 0 && intList[9] == 0){
			MessageText.text = "ぶっとばしたぜ！";
			MessageObject.SetActive (true);
			intList[9] = 1;
			CancelInvoke ("OnMessage");
			Invoke("OnMessage", 3f);
		}
	}

	void Gooal(){
		if (GoalArea == true && intList[8] == 1) {

                MessageText.text = "おみっちゃん待っててくれ！";
                intList[8] = 2;
                CancelInvoke("OnMessage");
                CancelInvoke("messtext5");
                Invoke("OnMessage", 3f);
                Invoke("OnClear", 3f);
            
		}
	}
	void Goal(){
		if (GoalArea == true) {
			timerflag = false;
			int ttt = PlayerPrefs.GetInt ("highScore1");
			if (Application.loadedLevelName == "Stage2") {
				ttt = PlayerPrefs.GetInt ("highScore2");
			}
			if (Application.loadedLevelName == "Stage3") {
				ttt = PlayerPrefs.GetInt ("highScore3");
			}
			if (Application.loadedLevelName == "BossStage") {
				ttt = PlayerPrefs.GetInt ("highScore4");
			}
			ClearTimeText.text = "只今の時間 : " + ((int)timer2).ToString ();
			HiTimeText.text = "最短時間 : " + ttt.ToString ();
			Invoke("SaveHighScore", 1f);
			MessageObject.SetActive (true);
			intList[8] = 1;
			Invoke("OnClear", 3f);
		}
	}

	void SaveHighScore(){
		int tim = (int)timer2;
		if (Application.loadedLevelName == "Stage1") {
			int ttt = PlayerPrefs.GetInt ("highScore1");
			if (tim < ttt) {
				PlayerPrefs.SetInt("highScore1", tim);
				PlayerPrefs.Save();//なくてもいけど、あると安心
			}
		}
		if (Application.loadedLevelName == "Stage2") {
			int ttt = PlayerPrefs.GetInt ("highScore2");
			if (tim < ttt) {
				PlayerPrefs.SetInt("highScore2", tim);
				PlayerPrefs.Save();//なくてもいけど、あると安心
			}
		}
		if (Application.loadedLevelName == "Stage3") {
			int ttt = PlayerPrefs.GetInt ("highScore3");
			if (tim < ttt) {
				PlayerPrefs.SetInt("highScore3", tim);
				PlayerPrefs.Save();//なくてもいけど、あると安心
			}
		}
		if (Application.loadedLevelName == "BossStage") {
			int ttt = PlayerPrefs.GetInt ("highScore4");
			if (tim < ttt) {
				PlayerPrefs.SetInt("highScore4", tim);
				PlayerPrefs.Save();//なくてもいけど、あると安心
			}
		}
	}

	void OnClear(){
		ResultObject.SetActive (true);
	}
	void Respawn(){
		int LP = PlayerLife.life;
		if(LP > 0 && EnemyTrigger1 == true){
			RespawnText.text = "鈴木魂 : " + LP;
			Invoke("Resp", 1f);
		}
	}
	void Resp(){
		RespawnObject.SetActive (true);
		EnemyTrigger1 = false;
	}

	void GameOver(){
		int LP = PlayerLife.life;
		if(LP == 0 && EnemyTrigger1 == true){
			Invoke("GaOv", 1f);
		}
	}

	void GaOv(){
		GameOverObject.SetActive (true);
		PlayerLife.start = 0;
	}

	void ItemMess(){
		if (ItemTrigger1 == true && intList[3] == 0) {
			MessageText.text = "火力が強くなった！";
			MessageObject.SetActive (true);
			intList[3] = 1;
			CancelInvoke ("OnMessage");
			CancelInvoke ("messtext");
			Invoke("OnMessage", 3f);
		}
		if (ItemTrigger2 == true && intList[4] == 0) {
			MessageText.text = "足が速くなった！";
			MessageObject.SetActive (true);
			intList[4] = 1;
			CancelInvoke ("OnMessage");
			CancelInvoke ("messtext");
			Invoke("OnMessage", 3f);
		}
		if (ItemTrigger3 == true && intList[5] == 0) {
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
