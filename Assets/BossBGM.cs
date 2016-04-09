using UnityEngine;
using System.Collections;

public class BossBGM : MonoBehaviour {

    public GameObject gamecon;
    private AudioSource audio;

	void Start () {
        //gamecon = GameObject.Find("GameController");
        audio = gamecon.GetComponent<AudioSource>();
        audio.mute = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
