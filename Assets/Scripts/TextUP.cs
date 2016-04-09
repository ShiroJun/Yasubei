using UnityEngine;
using System.Collections;

public class TextUP : MonoBehaviour {
    public GameObject pos;
	// Use this for initialization
	void Start () {
        Invoke("ToTitle",60f);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= pos.transform.position.y)
        {
            transform.position = new Vector3(pos.transform.position.x, transform.position.y + 1.2f, pos.transform.position.z);
        }

        if (Input.GetMouseButtonDown(0))
        {
            ToTitle();
        }
       
	}
    void ToTitle()
    {
        Application.LoadLevel("Title");
    }
}
