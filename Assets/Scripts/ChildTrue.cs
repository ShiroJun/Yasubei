using UnityEngine;
using System.Collections;

public class ChildTrue : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("TrueCheck",0.05f);
	}
	void TrueCheck()
    {
            transform.GetChild(1).gameObject.SetActive(true);
    }
}
