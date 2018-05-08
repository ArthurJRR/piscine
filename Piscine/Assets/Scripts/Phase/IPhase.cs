using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPhase{

    IPhase getNextPhase();
    void doAction();
    string toString();
}
