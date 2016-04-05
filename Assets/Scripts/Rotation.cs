using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	private float Rot;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		Rot += (Time.deltaTime * 40);
		this.transform.rotation = Quaternion.Euler(0,Rot,0);
	}
}
