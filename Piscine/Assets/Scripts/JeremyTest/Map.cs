using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

    public int[,] map1 = new int[9, 9] { { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                         { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                                         { 2, 2, 2, 1, 1, 1, 2, 2, 2 },
                                         { 2, 2, 2, 2, 1, 2, 2, 2, 2 },
                                         { 3, 2, 2, 2, 2, 2, 2, 2, 3 },
                                         { 2, 2, 2, 2, 1, 2, 2, 2, 2 },
                                         { 2, 2, 2, 1, 1, 1, 2, 2, 2 },
                                         { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                                         { 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
