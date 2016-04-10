using UnityEngine;
using System.Collections;

public class Button3FlagCheck : Akudaikan {
    int button3FlagInt = 0;
    bool button3FlagBool = false;
    public GameObject buttn3;
	// Use this for initialization
	void Start () {
        if (hp <= 0)
        {
            buttn3.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
