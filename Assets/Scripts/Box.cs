using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour
{
    public GameObject taruRed;
    void OnTriggerStay(Collider c)
    {
        if (c.tag == "Bakufu")
        {

            Destroy(c.gameObject);
            Destroy(gameObject);
            Transform pos = c.transform;
            Instantiate(taruRed, pos.transform.position, pos.transform.rotation);
            // go.transform.position = pos.transform.position;
        }


            }
}
