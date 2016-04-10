using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MiniGameRocketCreatorFree : MonoBehaviour {
    public GameObject Rocket;
    MiniGamePlayerMoveFree p;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        RocketCreat();
    }
    public void RocketCreat()
    {

        if (Input.GetKeyDown(KeyCode.R) || CrossPlatformInputManager.GetButton("Rocket"))
        {
            p = GetComponent<MiniGamePlayerMoveFree>();
            if (p.damage == false)
            {
                Instantiate(Rocket, new Vector3(transform.position.x, 1f, transform.position.z), transform.rotation);
            }
        }
    }
}
