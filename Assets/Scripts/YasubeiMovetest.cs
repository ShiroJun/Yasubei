﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput; // CrossPlatformInputManager を含む名前空間 CrossPlatforminputManager.csからもってきた

public class YasubeiMovetest : MonoEX
{
    public float speed;
    GameObject gameController;
	private float SPPOW;
	public bool notPass;
    private Animator anim;

    void Start()
    {
        Invoke("Destroy", 100);
        anim = GetComponent<Animator>();
    }
    //private float y = 90;
    // Update is called once per frame
    void Update()
    {
        gameController = GameObject.Find("GameController");
		SPPOW = speed + (gameController.GetComponent<GameController>().SpPow * 0.01f);
    }
    void FixedUpdate()
    {
		PlayerControl ();
		PlayerControl2 ();
    }
	void PlayerControl(){
		float h = CrossPlatformInputManager.GetAxisRaw ("Horizontal");
		float v = CrossPlatformInputManager.GetAxisRaw("Vertical");
		Debug.Log(h);
		if (notPass == true) {
			if (v > 0.4f)
			{
				transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
				transform.position += transform.forward * SPPOW;
				anim.SetBool("Run", true);
				//transform.position += transform.forward * SPPOW;
				//anim.SetBool("Run",true);
			}
			else
			{
				anim.SetBool("Run", false);
			}

			if (h > 0.4f)
			{
				transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
				transform.position += transform.forward * SPPOW;
				anim.SetBool("Run", true);
			}
			if (h < -0.4f)
			{
				transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
				transform.position += transform.forward * SPPOW;
				anim.SetBool("Run", true);
			}
			if (v < -0.4f)
			{
				transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
				transform.position += transform.forward * SPPOW;
				anim.SetBool("Run", true);
			}
		}
	}
	void PlayerControl2(){
		if (notPass == true) {
			if (Input.GetKey("up"))
			{
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
                //transform.position += transform.forward * SPPOW;
                //anim.SetBool("Run",true);
            }
			else
			{
				anim.SetBool("Run", false);
			}

            if (Input.GetKey("right"))
			{
                transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
            }
			if (Input.GetKey("left"))
			{
                transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
            }
            if (Input.GetKey("down"))
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                transform.position += transform.forward * SPPOW;
                anim.SetBool("Run", true);
            }
        }
	}
    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Enemy")
        {
            Application.LoadLevel(Application.loadedLevel);
        }




        if (hit.CompareTag("Item"))
        {
            if (hit.name.IndexOf("ExPow") != -1)
            {
				if(gameController.GetComponent<GameController>().ExPow < 5){
					gameController = GameObject.Find("GameController");
					gameController.GetComponent<GameController>().ExPow += 1;
				}
            }
            else if (hit.name.IndexOf("SpPow") != -1)
            {
				if (gameController.GetComponent<GameController> ().SpPow < 5) {
					gameController = GameObject.Find("GameController");
					gameController.GetComponent<GameController>().SpPow += 1;
				}
            }
            else if (hit.name.IndexOf("Invent") != -1)
            {
				if (gameController.GetComponent<GameController> ().Invent < 5) {
					gameController = GameObject.Find("GameController");
					gameController.GetComponent<GameController>().Invent += 1;
				}
            }
        }
		else if(hit.CompareTag("NotPass")){
			notPass = false;
		}
    }
	void OnTriggerExit(Collider hit) {
		if (hit.CompareTag ("NotPass")){
			notPass = true;
		}
	}
}
