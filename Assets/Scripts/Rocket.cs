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
        Invoke("RocketDestory",3f);
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
            Instantiate(roketFireWoks,c.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
        }
        if (c.tag == "Wall")
        {
            Instantiate(roketFireWoks, c.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
    public void RocketDestory()
    {
        Destroy(gameObject);
    }
}
