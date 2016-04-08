using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(AudioSource))]

public class PlayVideo : MonoBehaviour {

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN

    public MovieTexture movie;
    private AudioSource audio;
#endif
    void Start () {
#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
        GetComponent<RawImage>().texture = movie as MovieTexture;
                audio = GetComponent<AudioSource>();
                audio.clip = movie.audioClip;
                movie.Play();
                audio.Play();
                           

        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            GetComponent<RawImage>().texture = movie as MovieTexture;
            audio = GetComponent<AudioSource>();
            audio.clip = movie.audioClip;
            movie.Play();
            audio.Play();
        }
#endif
#if  UNITY_ANDROID
       // SceneManager.LoadScene("Title");
#endif
    }
#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
    void Update () {
        if (!movie.isPlaying)
        {
            SceneManager.LoadScene("Title");
        }

	}
#endif

}
