using UnityEngine;
using System.Collections;

public class BakufuCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("BakufuScriptCheck", 0.1f);
    }

    void BakufuScriptCheck()
    {
        gameObject.AddComponent<Bakufu>();
    }
}
