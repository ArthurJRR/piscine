using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{

    public GameObject CardMiniaturePrefab;
    public GameObject CardPrefab;

    public void pickCard()
    {
        Debug.Log("picked");
        GameObject card = (GameObject)Instantiate(CardMiniaturePrefab);
        card.transform.parent = GameObject.Find("Hand").transform;       
    }
}
