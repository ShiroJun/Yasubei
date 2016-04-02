using UnityEngine;
using System.Collections;

public class MatColor : MonoBehaviour {

	private float ti = 0f;
	private bool nan = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ColorTime ();
		GetComponent<Renderer>().sharedMaterial.color = new Color(0.0f, 0.8f, 0.5f, ti);
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
			if (ti < 0) {
				nan = false;
			}
		}
	}
}
