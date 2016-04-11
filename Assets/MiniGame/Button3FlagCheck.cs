using UnityEngine;
using System.Collections;

public class Button3FlagCheck : Akudaikan {
    int button3FlagInt = 0;
    public static bool button3FlagBool = false;
    public GameObject buttn3;
	// Use this for initialization
	void Start () {
        if (hp <= 0)
        {
            button3FlagBool = true;
        }
        hp = 3;
        if (button3FlagBool == true)
        {
            buttn3.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
