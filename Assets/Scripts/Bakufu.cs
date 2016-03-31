using UnityEngine;
using System.Collections;

public class Bakufu : MonoEX {
    GameObject gameController;
    public GameObject FireworksMix;
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
		if (c.tag == "Item")
		{
			Destroy(c.gameObject);
		}

        if (c.tag == "BombAfter")
        {        
            Transform pos = c.transform;
            Destroy(c.gameObject);
            GameObject go = instantiateGameObject("Prefab/FireworksMix");
            go.transform.position = pos.transform.position;

            gameController = GameObject.Find("GameController");
            int pow = gameController.GetComponent<GameController>().ExPow;

            for (int i = 1; i <= pow; i++)
            {
                Instantiate(FireworksMix, new Vector3(go.transform.position.x + (i), go.transform.position.y, pos.transform.position.z), go.transform.rotation);
                Instantiate(FireworksMix, new Vector3(go.transform.position.x, go.transform.position.y, pos.transform.position.z + (i)), go.transform.rotation);
                Instantiate(FireworksMix, new Vector3(go.transform.position.x - (i), go.transform.position.y, pos.transform.position.z), go.transform.rotation);
                Instantiate(FireworksMix, new Vector3(go.transform.position.x, go.transform.position.y, pos.transform.position.z - (i)), go.transform.rotation);
            }

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
