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
        card.GetComponentsInChildren<Text>()[0].text = "Card Name";
        card.GetComponentsInChildren<Text>()[1].text = "Card Text";
    }

    public void slideCardUI()
    {
        Debug.Log("slided");
        GameObject cardUI = GameObject.Find("CardUI");
        GameObject slideButton = GameObject.Find("SlideButton");
        Vector3 translated = new Vector3(0, -50);
        if (cardUI.transform.position != translated)
        {
            cardUI.transform.Translate(translated);
        }
        else
        {
            cardUI.transform.Translate(new Vector3(0, +50));
        }
        slideButton.transform.Rotate(new Vector3(180, 0));
    }
}
