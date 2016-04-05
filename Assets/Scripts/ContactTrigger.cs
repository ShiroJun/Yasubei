using UnityEngine;
using System.Collections;

public class ContactTrigger : MonoBehaviour {

	public bool Trigger00 = false;
	public bool Trigger01  = false;
	public bool Trigger02  = false;
	public bool Trigger03  = false;
	public bool ItemTrigger1 = false;
	public bool ItemTrigger2 = false;
	public bool ItemTrigger3 = false;
	public bool GoalArea = false;
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
		else if (hit.name.IndexOf ("Trigger01") != -1) {
			Trigger01 = true;
		}
		else if (hit.name.IndexOf ("Trigger02") != -1) {
			Trigger02 = true;
		}
		else if (hit.name.IndexOf ("Trigger03") != -1) {
			Trigger03 = true;
		}
		else if (hit.CompareTag ("Item")) {
			if (hit.name.IndexOf ("ExPow") != -1) {
				ItemTrigger1 = true;
			}
			else if (hit.name.IndexOf ("SpPow") != -1) {
				ItemTrigger2 = true;
			}
			else if (hit.name.IndexOf ("Invent") != -1) {
				ItemTrigger3 = true;
			}

		}
		else if (hit.name.IndexOf ("GoalArea") != -1) {
			GoalArea = true;
		}
	}
}
