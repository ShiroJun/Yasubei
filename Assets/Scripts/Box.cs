using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour
{
    bool flag = true;
    public GameObject taruRed;
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Bakufu")
        {
            if (flag == true)
            {

                Destroy(gameObject);
                Instantiate(taruRed, transform.position, transform.rotation);
                flag = false;
            }
            else
            {
                Destroy(c.gameObject);
            }
        }
     }
    void TaruRed()
    {


    }
}
