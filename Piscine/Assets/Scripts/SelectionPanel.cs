using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SelectionPanel : MonoBehaviour {

    private PlayableDataJSON playableData;
    private string playableDataProjectFilePath = "/Settings/PlayableData.json";

    public SimpleObjectPool disableableButtonObjectPool;
    public Transform playableButtonParent;

    public DeckScrollList deck;

    private void LoadPlayableData()
    {
        string filePath = Application.dataPath + playableDataProjectFilePath;

        if (File.Exists(filePath))
        {
            string dataAsJSON = File.ReadAllText(filePath);
            playableData = JsonUtility.FromJson<PlayableDataJSON>(dataAsJSON);
        }
        else
        {
            Debug.Log("Error, Playable File not found");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void DisplayDisableableButtons(PlayableData[] playableList)
    {
        for (int i = 0; i < playableList.Length; i++)
        {
            Item item = new Item(playableList[i].name, playableList[i].description, playableList[i].image, playableList[i].numberOrType);
            GameObject playableButtonGameObject = disableableButtonObjectPool.GetObject();
            //playableButtonGameObjects.Add(playableButtonGameObject);
            playableButtonGameObject.transform.SetParent(playableButtonParent);

            DisableableButton playableButton = playableButtonGameObject.GetComponent<DisableableButton>();
            playableButton.Setup(playableList[i], this);
        }

    }

    public void RemoveButtons()
    {
        while (playableButtonParent.childCount > 0)
        {
            GameObject toRemove = playableButtonParent.transform.GetChild(0).gameObject;
            toRemove.SetActive(false);
        }
    }

    public void OnDeckClick()
    {
        LoadPlayableData();
        DisplayDisableableButtons(playableData.factions);
    }


    private void ChangePage()
    {

    }

    private void AddPlayableButtons()
    {

    }

    private void RemovePlayableButtons()
    {

    }
    
    private void RefreshDisplay()
    {

    }

    public void TryTransferToDeck(Item item)
    {
        deck.AddItem(item, deck);
        //RemoveItem(item, this);

        //RefreshDisplay();
        deck.RefreshDisplay();
    }
}
