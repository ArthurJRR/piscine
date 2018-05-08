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
        //fait que la case que l'on cible devien jaune
            foreach (Renderer r in GetComponentsInChildren<Renderer>())
                r.enabled = true;
    }

    private void OnMouseExit()
    {
        //la case qu'on l'on cible redevient normal quand on la quitte
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.enabled = false;
        }
            GetComponent<Renderer>().enabled = true;
        /*foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.material.color = Color.green;*/
    }

    private void OnMouseUp()
    {
        //quand on a fini de cliquer les cases adjacente devienne normal
        movementCancellation(2,1);

    }

    private void OnMouseDown()
    {
        //quand on clique le debug nous dis la position de la tile
        int x = (int) this.gameObject.transform.position.x;
        int z = (int) this.gameObject.transform.position.z;
        Debug.Log("Click");
        Debug.Log("x = " + this.gameObject.transform.position.x + "y = " + this.gameObject.transform.position.z);
        //on voit l'unité cliqué
        BoardManager.getInstance().UnitClicked(x, z);
        //code pour voir les case adjacente en rouge
        movementPrevison(2,1);
    }

    public void movementPrevison(int pm,int depth)
    {
        // quand on clique les case adjacente devienne rouge en fonction du nombre de pm
        if(pm > 0)
        {
            if (depth == pm)
            {
                foreach (CaseInteraction c in getListNeighbour())
                {
                    foreach (Renderer r in c.GetComponentsInChildren<Renderer>())
                    {
                        r.material.color = Color.red;
                        r.enabled = true;
                    }
                }
            }
            else
            {
                foreach (CaseInteraction c in getListNeighbour())
                {
                    foreach (Renderer r in c.GetComponentsInChildren<Renderer>())
                    {
                        r.material.color = Color.red;
                        r.enabled = true;
                    }
                    c.movementPrevison(pm, depth + 1);
                }
            }

        }
        
    }

    public void movementCancellation(int pm, int depth)
    {
        if(pm > 0)
        {
            if(depth == pm)
            {
                foreach (CaseInteraction c in getListNeighbour())
                {
                    foreach (Renderer r in c.GetComponentsInChildren<Renderer>())
                    {
                        r.enabled = false;
                        Color color1 = new Color32(189, 177, 79, 255);
                        r.material.color = color1;
                    }
                    c.GetComponent<Renderer>().enabled = true;
                }
            }
            else
            {
                foreach (CaseInteraction c in getListNeighbour())
                {
                    foreach (Renderer r in c.GetComponentsInChildren<Renderer>())
                    {
                        r.enabled = false;
                        Color color1 = new Color32(189, 177, 79, 255);
                        r.material.color = color1;
                    }
                    c.GetComponent<Renderer>().enabled = true;
                    c.movementCancellation(pm, depth + 1);
                }
            }


        }
    }
}
