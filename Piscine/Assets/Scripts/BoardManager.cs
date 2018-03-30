using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager {
    private static BoardManager boardInstance = null;
    private List<Unit> listUnits;

    public static BoardManager getInstance()
    {
        if(boardInstance == null)
        {
            boardInstance = new BoardManager();
        }
        return boardInstance;
    }

    private BoardManager()
    {
        listUnits = new List<Unit>();
    }

    public List<Unit> getListUnits()
    {
        return listUnits;
    }

    public void displayUnitList()
    {
        foreach(Unit u in listUnits)
        {
            Debug.Log(u.name);
        }
    }
    
    
}
