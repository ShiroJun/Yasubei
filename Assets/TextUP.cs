using UnityEngine;
using System.Collections;

public class TextUP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= 260 )
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.67f, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Title");
        }
       
	}
}
