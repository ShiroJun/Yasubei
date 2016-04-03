using UnityEngine;
using System.Collections;

public class RocketCreator : MonoBehaviour {
    public GameObject Rocket;

	void Start () {
	
	}

	void Update () {
        RocketCreat();
	}
    public void RocketCreat()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(Rocket, new Vector3(transform.position.x, 1f, transform.position.z), transform.rotation);

        }
    }
}
