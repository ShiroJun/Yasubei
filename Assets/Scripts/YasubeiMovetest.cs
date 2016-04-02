using UnityEngine;
using System.Collections;

public class YasubeiMovetest : MonoEX
{
    public float speed;
    GameObject gameController;
    private float SPPOW;
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
        SPPOW = speed * gameController.GetComponent<GameController>().SpPow;
    }
    void FixedUpdate()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * SPPOW;
            anim.SetBool("Run",true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
        
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 10, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -10, 0);
        }
    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Item"))
        {
            if (hit.name.IndexOf("ExPow") != -1)
            {
                gameController = GameObject.Find("GameController");
                gameController.GetComponent<GameController>().ExPow += 1;
                Debug.Log("EX" + gameController.GetComponent<GameController>().ExPow);
            }
            else if (hit.name.IndexOf("SpPow") != -1)
            {
                gameController = GameObject.Find("GameController");
                gameController.GetComponent<GameController>().SpPow += 1;
                Debug.Log("SP" + gameController.GetComponent<GameController>().SpPow);
            }
            else if (hit.name.IndexOf("Invent") != -1)
            {
                gameController = GameObject.Find("GameController");
                gameController.GetComponent<GameController>().Invent += 1;
                Debug.Log("In" + gameController.GetComponent<GameController>().Invent);
            }
        }
    }
}
