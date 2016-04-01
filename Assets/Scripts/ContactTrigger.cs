using UnityEngine;
using System.Collections;

public class ContactTrigger : MonoBehaviour {

	public bool Trigger00 = false;
	public bool Trigger01 = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider hit)
	{
		
		if (hit.name.IndexOf ("Trigger00") != -1) {
			Trigger00 = true;
		}
		else if (hit.CompareTag ("Item")) {
			Trigger01 = true;
		}
	}
}
