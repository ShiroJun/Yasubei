using UnityEngine;
using System.Collections;

public class StageCreator : MonoBehaviour {
    public int x = 8;
    public int z = 8;
    public GameObject tile;
    public GameObject BombCenterTile;
    // Use this for initialization
    void Start () {
        TileSet();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void TileSet()
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < z; j++)
            {
                Instantiate(tile, new Vector3(i, 0, j),Quaternion.identity);
                Instantiate(BombCenterTile, new Vector3(i, 1, j), Quaternion.identity);
            }
        }
    }
}
