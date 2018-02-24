using UnityEngine;
using System.Collections.Generic; // permet d'utilisé les dictionnaire
using System.Collections;

public class Board : MonoBehaviour {

    public int size = 8; // fait actuelement du 9x9
    public Dictionary<int, Tile> tiles = new Dictionary<int, Tile>();
    public GameObject DirtPrefab;
    public GameObject Water1Prefab;
    public GameObject Water0Prefab;
    public GameObject Water2Prefab;
    //public int [,] Map = Map.map1;
    Map map = new Map();
    

    // Use this for initialization
    void Start () {
        int id = 0;

        for (int i = 0; i <= size; i++)
        {
            for (int j = 0; j <= size; j++)
            {
                id++;
                int creaTile = Random.Range(0, 4);
                creaTile = map.map1[j, i];
                if (creaTile == 0)
                {
                    GameObject TileObject = (GameObject)Instantiate(DirtPrefab);
                    Tile tile = TileObject.AddComponent<Tile>();
                    Tile.coordinate = new Vector2(i, j); // utilité qui reste a prouver
                    TileObject.transform.position = new Vector3(i, 0, j);
                }
                if (creaTile == 1)
                {
                    GameObject TileObject = (GameObject)Instantiate (Water0Prefab);
                    Tile tile = TileObject.AddComponent<Tile>();
                    Tile.coordinate = new Vector2(i, j); // utilité qui reste a prouver
                    TileObject.transform.position = new Vector3(i, 0, j);
                }
                if (creaTile == 2)
                {
                    GameObject TileObject = (GameObject)Instantiate(Water1Prefab);
                    Tile tile = TileObject.AddComponent<Tile>();
                    Tile.coordinate = new Vector2(i, j); // utilité qui reste a prouver
                    TileObject.transform.position = new Vector3(i, 0, j);
                }
                if (creaTile == 3)
                {
                    GameObject TileObject = (GameObject)Instantiate(Water2Prefab);
                    Tile tile = TileObject.AddComponent<Tile>();
                    Tile.coordinate = new Vector2(i, j); // utilité qui reste a prouver
                    TileObject.transform.position = new Vector3(i, 0, j);
                }
                
                
                


            }
        }


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
