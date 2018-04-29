using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseInteraction : MonoBehaviour {

    public List<CaseInteraction> listNeighbour;

    public List<CaseInteraction> getListNeighbour()
    {
        return listNeighbour;
    }


    private void OnMouseOver()
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = true;
    }

    private void OnMouseExit()
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {   
            r.enabled = false;
            Color color1 = new Color32(189, 177, 79,255);
            r.material.color = color1;
        }
        GetComponent<Renderer>().enabled = true;
        /*foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.material.color = Color.green;*/
    }

    private void OnMouseDown()
    {
        int x = (int) this.gameObject.transform.position.x;
        int z = (int) this.gameObject.transform.position.z;
        Debug.Log("Click");
        Debug.Log("x = " + this.gameObject.transform.position.x + "y = " + this.gameObject.transform.position.z);

        BoardManager.getInstance().UnitClicked(x, z);
        movementPrevison();
    }

    public void movementPrevison()
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.material.color = Color.red;
    }
}
