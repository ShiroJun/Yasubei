using UnityEngine;
using System.Collections;

public class Bomb : MonoEX {

    void Start () {
        Invoke("BombEX", 5);
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
    void BombEX()
    {
        Transform pos = transform;
        Destroy();
        GameObject go = instantiateGameObject("Prefab/BakufuP");
        go.transform.position = pos.transform.position;
    }

    //IEnumerator Delay(float t1,float t2)
    //{
    //    yield return new WaitForSeconds(t1);
    //    BombEX();
    //    yield return new WaitForSeconds(t2);
    //    Destroy();
    //}
}
