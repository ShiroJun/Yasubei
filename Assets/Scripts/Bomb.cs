using UnityEngine;
using System.Collections;

public class Bomb : MonoEX
{
    GameObject gameController;
    public GameObject FireworksMix;
    public GameObject[] FirewrksMixs = new GameObject[4];
    void Start()
    {
        Invoke("BombEX", 4);
    }
    void Update()
    {

    }
    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            transform.GetComponent<Collider>().isTrigger = false;
        }
        if (c.tag == "Bomb")
        {
            Destroy(c.gameObject);
        }
    }
    public void BombEX()
    {
        Transform pos = transform;
        Destroy(gameObject);
        //GameObject go = instantiateGameObject("Prefab/FireworksMix"); // 花火を生成　
        //go.transform.position = pos.transform.position;               //　花火のpostionをボムの位置にする
        gameController = GameObject.Find("GameController");
        int pow = gameController.GetComponent<GameController>().ExPow;

        Instantiate(FirewrksMixs[pow - 1], pos.transform.position, pos.transform.rotation);
    }
}
