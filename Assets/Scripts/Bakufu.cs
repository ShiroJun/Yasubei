using UnityEngine;
using System.Collections;

public class Bakufu : Bomb
{
    GameObject gameController;
    void Start()
    {
        Invoke("Destroy", 0.9f);
    }

    void Update()
    {

    }

    void OnTriggerStay(Collider c)
    {
        {

            if (c.tag == "Player")
            {
                //Destroy(c.gameObject);
                Application.LoadLevel(Application.loadedLevel);
            }
            if (c.tag == "Item")
            {
                Destroy(c.gameObject);
            }
            if (c.tag == "BombAfter")
            {
                Transform pos = c.transform;
                Destroy(c.gameObject);
                //GameObject go = instantiateGameObject("Prefab/FireworksMix");
                //go.transform.position = pos.transform.position;

                gameController = GameObject.Find("GameController");
                int pow = gameController.GetComponent<GameController>().ExPow;
                if (pow >= 6)
                {
                    pow = 5;
                }
                GameObject[] bomb = gameController.GetComponent<BombCreator>().FirewrksMixs;
                Instantiate(bomb[pow - 1], pos.transform.position, pos.transform.rotation);

            }
        }
    }
}
