using UnityEngine;
using System.Collections;

public class PlayerLife : MonoEX {
    public static int life;
    public static int start = 0;
    // Use this for initialization
    void Start () {
        if (start == 0)
        {
            life = 3;
            start++;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
