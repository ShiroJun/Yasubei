using UnityEngine;
using System.Collections;

public class RocketCreator : MonoBehaviour {
    public GameObject Rocket;
    public int RocketCount = 1;
    void Start () {
	
	}

	void Update () {
        RocketCreat();
	}
    public void RocketCreat()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (RocketCount == 1)
            {
                Instantiate(Rocket, new Vector3(transform.position.x, 1f, transform.position.z), transform.rotation);
                RocketCount--;
            }


        }
    }
}
