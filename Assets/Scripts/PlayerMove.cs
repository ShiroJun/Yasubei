using UnityEngine;
using System.Collections;

public class PlayerMove : MonoEX {
    public float speed;
	GameObject gameController;
	private float SPPOW;
	private Vector3		move = Vector3.zero;	// キャラ移動量.
	private float		rotationSpeed = 180.0f;	// プレイヤーの回転速度
    void Start()
    {
        Invoke("Destroy", 100);
    }
    //private float y = 90;
    // Update is called once per frame
	void Update() {
		gameController = GameObject.Find ("GameController");
		SPPOW = speed *gameController.GetComponent<GameController> ().SpPow;
	}
    void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");




		float y = move.y;
		move = new Vector3(x , 0.0f , z);		// 左右上下のキー入力を取得し、移動量に代入.
		Vector3 playerDir = move;	// 移動方向を取得.
		Debug.Log(playerDir);
		// ▼▼▼プレイヤーの向き変更▼▼▼
		if(playerDir.magnitude > 0.1f){
			Quaternion q = Quaternion.LookRotation(playerDir);			// 向きたい方角をQuaternionn型に直す .
			transform.rotation = Quaternion.RotateTowards(transform.rotation , q , rotationSpeed * Time.deltaTime);	// 向きを q に向けてじわ～っと変化させる.
		}
		transform.Translate(x * SPPOW, 0, z * SPPOW);

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(0, -90, 0);
        //    //transform.position = new Vector3(0f, transform.position.y + 0.1f, 0f);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(0, 90, 0);
        //}
    }
	void OnTriggerEnter (Collider hit){
		if (hit.CompareTag ("Item")) {
			if (hit.name.IndexOf ("ExPow") != -1) {
				gameController = GameObject.Find ("GameController");
				gameController.GetComponent<GameController> ().ExPow += 1;
				Debug.Log ("EX" + gameController.GetComponent<GameController> ().ExPow);
			}
			else if (hit.name.IndexOf ("SpPow") != -1) {
				gameController = GameObject.Find ("GameController");
				gameController.GetComponent<GameController> ().SpPow += 1;
				Debug.Log ("SP" + gameController.GetComponent<GameController> ().SpPow);
			}
			else if (hit.name.IndexOf ("Invent") != -1) {
				gameController = GameObject.Find ("GameController");
				gameController.GetComponent<GameController> ().Invent += 1;
				Debug.Log ("In" + gameController.GetComponent<GameController> ().Invent);
			}
		}
	}
}
