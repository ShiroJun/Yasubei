using UnityEngine;
using System.Collections;

public class PlayerSound : MonoBehaviour {

    public AudioClip audioclip;
    AudioSource audiosource;

	// Use this for initialization
	void Start () {
        audiosource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            audiosource.PlayOneShot(audioclip);
        }
    }
}
