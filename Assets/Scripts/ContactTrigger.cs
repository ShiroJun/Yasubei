using UnityEngine;
using System.Collections;

public class ContactTrigger : MonoBehaviour {

	private Animator anim;
	public static bool Trigger00 = false;
	public static bool Trigger01  = false;
	public static bool Trigger02  = false;
	public static bool Trigger03  = false;
	public static bool ItemTrigger1 = false;
	public static bool ItemTrigger2 = false;
	public static bool ItemTrigger3 = false;
	public static bool EnemyTrigger1 = false;
	public static bool GoalArea = false;
	void Start () {
		anim = GetComponent<Animator>();
		GoalArea = false;
		EnemyTrigger1 = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider hit)
	{
		
		if (hit.name.IndexOf ("Trigger00") != -1) {
			Trigger00 = true;
		} else if (hit.name.IndexOf ("Trigger01") != -1) {
			Trigger01 = true;
		} else if (hit.name.IndexOf ("Trigger02") != -1) {
			Trigger02 = true;
		} else if (hit.name.IndexOf ("Trigger03") != -1) {
			Trigger03 = true;
		} else if (hit.name.IndexOf ("Tegata") != -1) {
			GoalArea = true;
			anim.SetBool ("Victory", true);
		} else if (hit.CompareTag ("Enemy")) {
			//PlayerLife.life--;
			EnemyTrigger1 = true;
		}else if (hit.CompareTag ("Bakufu")) {
			//PlayerLife.life--;
			EnemyTrigger1 = true;
		}
		else if (hit.CompareTag ("Item")) {
			if (Application.loadedLevelName == "Stage1") {
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

		}

	}
}
