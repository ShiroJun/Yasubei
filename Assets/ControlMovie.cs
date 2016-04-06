using UnityEngine;
using System.Collections;

//public class mov : MonoBehaviour {

	//public MovieTexture movTexture;

	// Use this for initialization
	//void Start() {
		//GetComponent<Renderer>().material.mainTexture = movTexture;
		//movTexture.Play();
//	}
	


	public class ControlMovie : MonoBehaviour
	{
		public MovieTexture movieTexture;

		void Start()
		{
		GetComponent<GUITexture>().texture = movieTexture;
			movieTexture.Play();
		}
}
