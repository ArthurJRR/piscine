using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPhase : MonoBehaviour, IPhase
{

    public IPhase getNextPhase()
    {
        return BoardManager.getInstance().getDrawPhase();
    }

    public void doAction()
    {
        Debug.Log("This is the end phase");
    }

    public string toString()
    {
        return "End Phase";
    }
}
