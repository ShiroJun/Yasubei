using UnityEngine;
using System.Collections;

public class RocketDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Des",5f);
	}
	
    void Des()
    {
        Destroy(gameObject);
    }
}
