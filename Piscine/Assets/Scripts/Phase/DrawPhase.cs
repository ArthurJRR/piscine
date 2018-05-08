using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPhase : MonoBehaviour, IPhase
{
    public IPhase getNextPhase()
    {
        return BoardManager.getInstance().getPlayPhase();
    }

    //Override interface IPhase
    public void doAction()
    {
        Debug.Log("This is the draw Phase");
    }

    //Override interface IPhase
    public string toString()
    {
        return "Draw Phase";
    }
}
