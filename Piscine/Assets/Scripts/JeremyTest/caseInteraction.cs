using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caseInteraction : MonoBehaviour {

    

    private void OnMouseOver()
    {
        GetComponent<Renderer>().enabled = false;
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = true;

    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().enabled = true;
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = false;
    }
}
