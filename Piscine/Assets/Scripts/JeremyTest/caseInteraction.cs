using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caseInteraction : MonoBehaviour {

    

    private void OnMouseOver()
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = true;

    }

    private void OnMouseExit()
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = false;
        GetComponent<Renderer>().enabled = true;
    }

    private void OnMouseDown()
    {
        int x = (int) this.gameObject.transform.position.x;
        int z = (int) this.gameObject.transform.position.z;
        Debug.Log("Click");
        Debug.Log("x = " + this.gameObject.transform.position.x + "y = " + this.gameObject.transform.position.z);

        BoardManager.getInstance().UnitClicked(x, z);
    }
}
