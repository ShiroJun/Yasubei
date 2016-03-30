using UnityEngine;
using System.Collections;

public class Bakufu : MonoEX {

	void Start () {
        Invoke("Destroy", 1);
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Box")
        {
            Transform pos = c.transform;
            Destroy(c.gameObject);
            GameObject go = instantiateGameObject("Prefab/WoodenCrateRed");
            go.transform.position = pos.transform.position;
        }

        if (c.tag == "Player")
        {
            Destroy(c.gameObject);
        }

        if (c.tag == "Bomb")
        {        
            Transform pos = c.transform;
            Destroy(c.gameObject);
            GameObject go = instantiateGameObject("Prefab/BakufuP");
            go.transform.position = pos.transform.position;           
        }
    }
    IEnumerator DelayBox(float t1, GameObject go)
    {
        yield return new WaitForSeconds(t1);
        Destroy(go);
    }
    void DelayLog()
    {
        Debug.Log("Invorke");
    }

}
