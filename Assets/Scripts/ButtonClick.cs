using UnityEngine;
using System.Collections;

public class ButtonClick : MonoBehaviour {

    AudioSource audio;
    GameObject soundcon;

	void Awake () {

        soundcon = GameObject.Find("SoundController");
        audio = soundcon.GetComponent<AudioSource>();
	}
	

    public void  ButtonAudio()
    {
        audio.Play();
    }
}
