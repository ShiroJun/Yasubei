using UnityEngine;
using System.Collections;
using System;

public class BombCreator : GameController
{
    public GameObject pos;
    public GameObject bomb;
    int x;
    int z;
    GameObject gameController;
    GameObject player;
    int bombCount;
    GameObject[] bombObjects;
    public GameObject[] FirewrksMixs = new GameObject[3];

    void Update()
    {
        BombCreat();
    }
    public void BombCreat()
    {
        if (Input.GetKeyDown("space"))
        {
            gameController = GameObject.Find("GameController");
            int invent = Invent;
            bombObjects = GameObject.FindGameObjectsWithTag("BombAfter");
            bombCount = bombObjects.Length;


            if (bombCount < invent)
            {

                GameObject.Find("GameController");
                x = Mathf.RoundToInt(pos.transform.position.x);
                z = Mathf.RoundToInt(pos.transform.position.z);
                Instantiate(bomb, new Vector3(x,bomb.transform.position.y,z),bomb.transform.rotation);
            }
        }
    }
	public void BombCreat2()
	{
			gameController = GameObject.Find("GameController");
			int invent = Invent;
			bombObjects = GameObject.FindGameObjectsWithTag("BombAfter");
			bombCount = bombObjects.Length;


			if (bombCount < invent)
			{

				GameObject.Find("GameController");
				x = Mathf.RoundToInt(pos.transform.position.x);
				z = Mathf.RoundToInt(pos.transform.position.z);
				Instantiate(bomb, new Vector3(x,bomb.transform.position.y,z),bomb.transform.rotation);
			}

	}
}
