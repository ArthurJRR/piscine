using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager {
    private static BoardManager boardInstance = null;
    private List<Unit> listUnits;
    private List<CaseInteraction> listTile;

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
        listTile = new List<CaseInteraction>();
    }

    public List<Unit> getListUnits()
    {
        return listUnits;
    }

    public List<CaseInteraction> getListTile()
    {
        return listTile;
    }


    public void displayUnitList()
    {
        foreach(Unit u in listUnits)
        {
            Debug.Log(u.name);
        }
    }

    public Unit UnitClicked(int x, int z)
    {
        foreach(Unit u in listUnits)
        {
            GameObject unitObject = u.gameObject;
            if(unitObject.transform.position.x == x && unitObject.transform.position.z == z)
            {
                Debug.Log(u.name + " has been clicked !");
                return u;
            }

        }
        Debug.Log("Nobody Here");
        return null;
    }
    
    
}
