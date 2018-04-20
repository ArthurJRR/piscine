﻿using UnityEngine;
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
        GameObject waterObject = (GameObject)Instantiate(WaterJeu);
        int id = 0;

        /*for (int i = 0; i <= size; i++)
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
                }*/

        for (int i = 0; i <= size; i++)
        {
            for (int j = 0; j <= size; j++)
            {
                id++;
                int creaTile = map.map1[j, i];
                if (creaTile == 0)
                {
                    GameObject TileObject = (GameObject)Instantiate(DirtPrefab);
                    Tile tile = TileObject.AddComponent<Tile>();
                    Tile.coordinate = new Vector2(i, j); // utilité qui reste a prouver
                    TileObject.transform.position = new Vector3(i, 0, j);
                    GameObject caseGrille = (GameObject)Instantiate(casePrefab);
                    caseGrille.transform.position = new Vector3(i,(float) 0.51, j);
                }
                if (creaTile == 1)
                {
                    GameObject TileObject = (GameObject)Instantiate(tile0Prefab);
                    Tile tile = TileObject.AddComponent<Tile>();
                    Tile.coordinate = new Vector2(i, j); // utilité qui reste a prouver
                    float ztile0 = (float)-0.125;
                    TileObject.transform.position = new Vector3(i, ztile0, j);
                    GameObject caseGrille = (GameObject)Instantiate(casePrefab);
                    caseGrille.transform.position = new Vector3(i, (float)0.26, j);
                }
                if (creaTile == 2)
                {
                    GameObject TileObject = (GameObject)Instantiate(tile1Prefab);
                    Tile tile = TileObject.AddComponent<Tile>();
                    Tile.coordinate = new Vector2(i, j); // utilité qui reste a prouver
                    float ztile1 = (float)-0.25;
                    TileObject.transform.position = new Vector3(i, ztile1, j);
                    GameObject caseGrille = (GameObject)Instantiate(casePrefab);
                    caseGrille.transform.position = new Vector3(i, (float)0.012, j);
                }
                if (creaTile == 3)
                {
                    GameObject TileObject = (GameObject)Instantiate(tile2Prefab);
                    Tile tile = TileObject.AddComponent<Tile>();
                    Tile.coordinate = new Vector2(i, j); // utilité qui reste a prouver
                    float ztile2 = (float)-0.375;
                    TileObject.transform.position = new Vector3(i, ztile2, j);
                    GameObject caseGrille = (GameObject)Instantiate(casePrefab);
                    caseGrille.transform.position = new Vector3(i,(float) -0.23, j);
                }





            }
        }


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
