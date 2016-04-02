using UnityEngine;
using System.Collections;

public class BombCenter : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Bomb")
        {
            c.transform.position = gameObject.transform.position;
            c.tag = ("BombAfter");
        }
    }
    void OnTriggerStay(Collider c)
    {
        if (c.tag == "BombAfter")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Invoke("ColliderCheck", 3.8f);
        }
    }

    void ColliderCheck()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
