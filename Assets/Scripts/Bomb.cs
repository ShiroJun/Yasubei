using UnityEngine;
using System.Collections;

public class Bomb : MonoEX {
    GameObject gameController;
    public GameObject FireworksMix;
    void Start () {
        
        Invoke("BombEX", 4);
    }
    void Update () {

    }
    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            transform.GetComponent<Collider>().isTrigger = false;
        }
    }
    public void BombEX()
    {
        Transform pos = transform;
        Destroy();
        GameObject go = instantiateGameObject("Prefab/FireworksMix"); // 花火を生成　
        go.transform.position = pos.transform.position;               //　花火のpostionをボムの位置にする
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

    public void BombChain()
    {
        gameController = GameObject.Find("GameController");
        int pow = gameController.GetComponent<GameController>().ExPow;
        for (int i = 0; i < pow; i++)
        {
            Instantiate(FireworksMix, new Vector3(transform.position.x + (pow + i), transform.position.y, transform.position.z), transform.rotation);
            Instantiate(FireworksMix, new Vector3(transform.position.x, transform.position.y, transform.position.z + (pow + i)), transform.rotation);
            Instantiate(FireworksMix, new Vector3(transform.position.x - (pow + i), transform.position.y, transform.position.z), transform.rotation);
            Instantiate(FireworksMix, new Vector3(transform.position.x, transform.position.y, transform.position.z - (pow + i)), transform.rotation);
        }
    }
}
