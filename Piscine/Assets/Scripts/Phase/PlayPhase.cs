using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPhase :MonoBehaviour, IPhase
{

    public IPhase getNextPhase()
    {
        return BoardManager.getInstance().getEndPhase();
    }

    void IPhase.doAction()
    {
        Debug.Log("this is the playing phase");
    }

    string IPhase.toString()
    {
        return "play phase";
    }
}
