using UnityEngine;
using System.Collections;

public class Bomb : MonoEX {
    GameObject gameController;
    public GameObject FireworksMix;
    public GameObject[] FirewrksMixs = new GameObject[3];
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
        Destroy(gameObject);
        //GameObject go = instantiateGameObject("Prefab/FireworksMix"); // 花火を生成　
        //go.transform.position = pos.transform.position;               //　花火のpostionをボムの位置にする
        gameController = GameObject.Find("GameController");             
        int pow = gameController.GetComponent<GameController>().ExPow;

        Instantiate(FirewrksMixs[pow-1], pos.transform.position, pos.transform.rotation);




        //for (int i = 1; i <= pow; i++)
        //{
        //    FirewrksMixs[i-0] = (GameObject)Instantiate(FireworksMix, new Vector3(go.transform.position.x + (i), go.transform.position.y, pos.transform.position.z), go.transform.rotation);
        //    FirewrksMixs[i-0].transform.SetParent(go.transform);
        //    Instantiate(FireworksMix, new Vector3(go.transform.position.x, go.transform.position.y, pos.transform.position.z + (i)), go.transform.rotation);
        //    Instantiate(FireworksMix, new Vector3(go.transform.position.x - (i), go.transform.position.y, pos.transform.position.z), go.transform.rotation);
        //    Instantiate(FireworksMix, new Vector3(go.transform.position.x, go.transform.position.y, pos.transform.position.z - (i)), go.transform.rotation);
        //    for (int j = 0; j < i; j++)
        //    {
        //        if (go.transform.childCount <= )
        //        {

        //        }
        //        FirewrksMixs[j].transform.SetParent(go.transform);
        //    }
        //}                  
    }
}
