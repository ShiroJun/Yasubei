using UnityEngine;
using System.Collections;

public class WoodenCrateRed : MonoEX {
	GameObject gameController;
	void Start () {
		Invoke("Destroy", 1);
		//Invoke(Item(), 1.3);
		Item();

    }
	void Item(){
		int ran = Random.Range (0, 5);			//15分の１の確率でアイテム出現
		switch (ran){
		case 1:
			gameController = GameObject.Find ("GameController");									//クラスの指名
			GameObject go1 = gameController.GetComponent<GameController> ().Items [0] as GameObject; //コンポーネントの指定
			Instantiate (go1, gameObject.transform.position, Quaternion.identity);						//プレハブ出力
			break;
		case 2:
			gameController = GameObject.Find ("GameController");
			GameObject go2 = gameController.GetComponent<GameController> ().Items[1] as GameObject;
			Instantiate(go2,gameObject.transform.position,Quaternion.identity);
			break;
		case 3:
			gameController = GameObject.Find ("GameController");
			GameObject go3 = gameController.GetComponent<GameController> ().Items[2] as GameObject;
			Instantiate(go3,gameObject.transform.position,Quaternion.identity);
			break;
		default:;
			break;
		}
	}

}
