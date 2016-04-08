using UnityEngine;
using System.Collections;

public class NinjaCounts : MonoBehaviour {
    public static int ninjaCount;
    GameObject[] ninja;
    public bool flag;
    // Use this for initialization
    void Start () {
	    ninja = GameObject.FindGameObjectsWithTag("Enemy");
        ninjaCount = ninja.Length;
        Debug.Log(ninjaCount);
        flag = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (ninjaCount <= 0 && flag.Equals(true))
        {
            GameObject go = gameObject.transform.parent.gameObject;
            go.transform.GetComponent<BoxCollider>().enabled = true;
            gameObject.transform.GetComponent<MeshRenderer>().enabled = true;
            flag = false;
        }
	}
}
