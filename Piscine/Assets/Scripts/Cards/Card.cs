using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Card : MonoBehaviour
{

    public GameObject CardMiniaturePrefab;
    public GameObject CardPrefab;
    public string title;
    public string description;
    public string image;

    public Card(GameObject cardMiniaturePrefab, GameObject cardPrefab, string title, string image, string description)
    {
        CardMiniaturePrefab = cardMiniaturePrefab;
        CardMiniaturePrefab.GetComponentsInChildren<Text>()[0].text = title;
        CardMiniaturePrefab.GetComponentsInChildren<Text>()[1].text = description;

        CardPrefab = cardPrefab;
        CardPrefab.GetComponentsInChildren<Text>()[0].text = title;
        CardPrefab.GetComponentsInChildren<Text>()[1].text = description;

        this.title = title;
        this.image = image;
        this.description = description;
    }

    public void pickCard()
    {
        Debug.Log("picked");

        string filePath = Path.Combine(Application.dataPath, "Settings/cardsData.json");
        string dataAsJson = File.ReadAllText(filePath);
        Debug.Log(dataAsJson);
        //GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);

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
        Vector3 untranslated = new Vector3(269,151,0); //Initial position of the CardUI interface
        Debug.Log(cardUI.transform.position);
        if (cardUI.transform.position == untranslated)
        {
            cardUI.transform.Translate(new Vector3(0,-80));
        }
        else
        {
            cardUI.transform.Translate(new Vector3(0, +80));
        }
        slideButton.transform.Rotate(new Vector3(0, 0, 180));
        
    }

    public void zoomOnMouseOver()
    {
        
    }
}
