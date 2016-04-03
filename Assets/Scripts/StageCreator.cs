using UnityEngine;
using System.Collections;

public class StageCreator : MonoBehaviour {
    public int x = 8;
    public int z = 8;
    public GameObject tile;
    public GameObject BombCenterTile;
    private GameObject floors;
    private GameObject bombs;
    // Use this for initialization
    void Start () {
        floors = GameObject.Find("Floors");
        bombs = GameObject.Find("BombCenterTiles");
        TileSet();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void TileSet()
    {
        if (tile != null)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    GameObject go = (GameObject)Instantiate(tile, new Vector3(i, 0, j), Quaternion.identity);
                    go.transform.parent = floors.transform;
                    GameObject go2 = (GameObject)Instantiate(BombCenterTile, new Vector3(i, 1, j), Quaternion.identity);
                    go2.transform.parent = bombs.transform;
                }
            }
        }
        if (tile == null)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    GameObject go2 = (GameObject)Instantiate(BombCenterTile, new Vector3(i, 1, j), Quaternion.identity);
                    go2.transform.parent = bombs.transform;
                }
            }
        }

    }
}
