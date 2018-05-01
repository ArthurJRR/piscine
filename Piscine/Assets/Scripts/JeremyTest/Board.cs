using UnityEngine;
using System.Collections.Generic; // permet d'utilisé les dictionnaire
using System.Collections;

public class Board : MonoBehaviour {

    public int size = 8; // fait actuelement du 9x9
    //public Dictionary<int, Tile> tiles = new Dictionary<int, Tile>();
    public GameObject DirtPrefab;
    public GameObject Water1Prefab;
    public GameObject Water0Prefab;
    public GameObject Water2Prefab;
    public GameObject tile0Prefab;
    public GameObject tile1Prefab;
    public GameObject tile2Prefab;
    public GameObject WaterJeu;
    public GameObject casePrefab;
    //public int [,] Map = Map.map1;
    Map map = new Map();

    // Use this for initialization
    void Start () {
        Instantiate(WaterJeu);
        int id = 0;


        for (int i = 0; i <= size; i++)
        {
            for (int j = 0; j <= size; j++)
            {
                id++;
                int creaTile = map.map1[j, i];
                if (creaTile == 0)
                {
                    GameObject TileObject = (GameObject)Instantiate(DirtPrefab);
                    TileObject.transform.position = new Vector3(i, 0, j);
                }
                if (creaTile == 1)
                {
                    GameObject TileObject = (GameObject)Instantiate(tile0Prefab);
                    float ztile0 = (float)-0.125;
                    TileObject.transform.position = new Vector3(i, ztile0, j);
                }
                if (creaTile == 2)
                {
                    GameObject TileObject = (GameObject)Instantiate(tile1Prefab);
                    float ztile1 = (float)-0.25;
                    TileObject.transform.position = new Vector3(i, ztile1, j);
                }
                if (creaTile == 3)
                {
                    GameObject TileObject = (GameObject)Instantiate(tile2Prefab);
                    float ztile2 = (float)-0.375;
                    TileObject.transform.position = new Vector3(i, ztile2, j);
                }
            }
        }
        for (int i = 0; i <= size; i++)
        {
            for (int j = 0; j <= size; j++)
            {

            }
        }


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
