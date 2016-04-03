using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
    GameObject player;
    Rigidbody rb;
    public float speed;
    public GameObject roketFireWoks;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }
    void Update()
    {
        rb.AddForce(transform.forward * speed);
    }
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Enemy")
        {
            Destroy(c.gameObject);
        }
        if (c.tag == "Box")
        {
            Instantiate(roketFireWoks,transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
        }
        if (c.tag == "Wall")
        {
            Instantiate(roketFireWoks, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
    public void RocketCreat()
    {

        if (Input.GetKeyDown("r"))
        {


            //int RocketInvent = gameController.GetComponent<Rocket>().RocketInvent;
            //dir = player.transform.forward;
        }
    }
}
