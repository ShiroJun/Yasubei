using UnityEngine;
using System.Collections;

public class NinjaCounts : MonoBehaviour {
    public static int ninjaCount;
    GameObject[] ninja;
	// Use this for initialization
	void Start () {
	    ninja = GameObject.FindGameObjectsWithTag("Enemy");
        ninjaCount = ninja.Length;
        Debug.Log(ninjaCount);
    }
	
	// Update is called once per frame
	void Update () {
        if (ninjaCount == 0)
        {
            gameObject.transform.parent.GetComponent<BoxCollider>().enabled = true;
            gameObject.transform.GetComponent<MeshRenderer>().enabled = true;
        }
	}
}
