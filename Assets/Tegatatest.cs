using UnityEngine;
using System.Collections;

public class Tegatatest : MonoBehaviour {

    private GameObject tegata;
    private Animator anim;

    // Use this for initialization
    void Start () {
        tegata = GameObject.Find("Tegata");
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Tegata")
        {
            anim.SetBool("Victory",true);
        }
    }
}
