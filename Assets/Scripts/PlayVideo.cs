using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(AudioSource))]

public class PlayVideo : MonoBehaviour {

    public MovieTexture movie;
    private AudioSource audio;

	void Start () {

        #if UNITY_STANDALONE_WIN
            GetComponent<RawImage>().texture = movie as MovieTexture;
            audio = GetComponent<AudioSource>();
            audio.clip = movie.audioClip;
            movie.Play();
            audio.Play();
        #endif
    }

    void Update () {
        if (!movie.isPlaying)
        {
            SceneManager.LoadScene("Title");
        }
	}
}
