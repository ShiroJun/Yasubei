using UnityEngine;
using System.Collections;

public class MatColor : MonoBehaviour {

	private float ti = 0f;
	private bool nan = false;
	public float R;
	public float B;
	public float G;

	private Vector3		move = Vector3.zero;	// キャラ移動量.
	private float		rotationSpeed = 180.0f;	// プレイヤーの回転速度
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ColorTime ();
		GetComponent<Renderer>().sharedMaterial.color = new Color(R, B, G, ti);
	}

	void ColorTime(){
		if (nan == false) {
			ti += Time.deltaTime;
			if (ti > 1) {
				nan = true;
			}
		}
		else if(nan == true){
			ti -= Time.deltaTime;
			if (ti < 0.2f) {
				nan = false;
			}
		}
	}
}
