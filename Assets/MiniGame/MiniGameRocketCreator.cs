using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MiniGameRocketCreator : MonoBehaviour {
    public GameObject Rocket;
    MiniGamePlayerMove p;
    // Use this for initialization
    void Start () {
       
	}

    void Update()
    {
        RocketCreat();
    }
    public void RocketCreat()
    {

        if (Input.GetKeyDown(KeyCode.R) || CrossPlatformInputManager.GetButton("Rocket"))
        {
            p = GetComponent<MiniGamePlayerMove>();
            if (p.damage == false)
            {
                Instantiate(Rocket, new Vector3(transform.position.x, 1f, transform.position.z), transform.rotation);
            }
        }
    }
}
