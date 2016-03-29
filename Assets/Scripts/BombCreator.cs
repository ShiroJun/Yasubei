using UnityEngine;
using System.Collections;

public class BombCreator : MonoEX
{
    public GameObject pos;


    void Update()
    {
        BombCreat();
    }


    public void BombCreat()
    {
        if (Input.GetMouseButtonDown(0)|| Input.GetKeyDown("space"))
        {
            GameObject go = instantiateGameObject("Prefab/Bomb");
            go.transform.position = pos.transform.position;
        }
    }

}
