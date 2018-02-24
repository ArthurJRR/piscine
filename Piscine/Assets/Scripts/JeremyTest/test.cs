using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    public Board board;
	// Use this for initialization
	void Start () {
	    GameObject boardobject = new GameObject("Board");
        boardobject.transform.parent = transform; //le parent du boardobject  est le transform sur 
        //lequ'elle est appliquer le scripte ici jeu
        board = boardobject.AddComponent<Board>(); // ceci ajoute au board (boardobjet) le script Board
        board.DirtPrefab = (GameObject) Resources.Load("Tile"); //mais le préfab néccéssaire au scripte Boards
        // dans le gameobject board
        board.Water1Prefab = (GameObject)Resources.Load("Water1");
        board.Water0Prefab = (GameObject)Resources.Load("Water0");
        board.Water2Prefab = (GameObject)Resources.Load("Water2");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
