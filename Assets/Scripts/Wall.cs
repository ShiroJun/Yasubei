using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Bakufu")
        {
            Destroy(c.gameObject);
        }
    }
}
