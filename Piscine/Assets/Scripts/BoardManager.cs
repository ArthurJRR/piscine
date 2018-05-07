using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager {

    private static BoardManager boardInstance = null;
    private List<Unit> listUnits;
    private List<CaseInteraction> listTile;

    //Phases
    private DrawPhase drawPhase = new DrawPhase();
    private PlayPhase playPhase = new PlayPhase();
    private EndPhase endPhase = new EndPhase();
    private IPhase activePhase;

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
        activePhase = drawPhase;
    }

    public List<Unit> getListUnits()
    {
        return listUnits;
    }

    public List<CaseInteraction> getListTile()
    {
        return listTile;
    }

    // Phases

    public IPhase getActivePhase()
    {
        return activePhase;
    }

    public void changeActivePhase()
    {
        this.activePhase = activePhase.getNextPhase();
    }

    public IPhase getDrawPhase()
    {
        return drawPhase;
    }

    public IPhase getPlayPhase()
    {
        return playPhase;
    }

    public IPhase getEndPhase()
    {
        return endPhase;
    }

    //Methods

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
