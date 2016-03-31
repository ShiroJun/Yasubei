using UnityEngine;
using System.Collections;

public class BombCreator : MonoEX
{
    public GameObject pos;
    GameObject gameController;
    int bombCount;
    GameObject[] bombObjects;

    void Update()
    {
        BombCreat();
    }


    public void BombCreat()
    {

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            gameController = GameObject.Find("GameController");
            int Invent = gameController.GetComponent<GameController>().Invent;
            bombObjects = GameObject.FindGameObjectsWithTag("BombAfter");
            bombCount = bombObjects.Length;


            if (bombCount < Invent)
            {
                GameObject.Find("GameController");
                GameObject go = instantiateGameObject("Prefab/Bomb");
                go.transform.position = pos.transform.position;
            }
       
        }
    }

}
