using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DeckScrollList : MonoBehaviour {

    public List<PlayableData> playableDataList;
    public Transform factionPannel;
    public Transform generalPannel;
    public Transform adjuvantsPannel;
    public Transform cardsPannel;
    public DeckScrollList otherDeck;
    public SimpleObjectPool buttonObjectPool;

	// Use this for initialization
	void Start () {
        RefreshDisplay();
	}

    public void RefreshDisplay()
    {
        RemoveButtons();
        AddButtons();
    }

    private void AddButtons()
    {
        for ( int i=0; i < playableDataList.Count; i++)
        {
            PlayableData playableData = playableDataList[i];
            GameObject newButton = buttonObjectPool.GetObject();

            switch (playableData.numberOrType)
            {
                case "F":
                    newButton.transform.SetParent(factionPannel);
                    break;
                case "G":
                    newButton.transform.SetParent(generalPannel);
                    break;
                case "A":
                    newButton.transform.SetParent(adjuvantsPannel);
                    break;
                default:
                    newButton.transform.SetParent(cardsPannel);
                    break;
            }

            UnselectButton unselectButton = newButton.GetComponent<UnselectButton>();
            unselectButton.setup(playableData, this);
        }
    }

    private void RemoveButtons()
    {
        while (factionPannel.childCount > 0)
        {
            GameObject toRemove = factionPannel.transform.GetChild(0).gameObject;
            buttonObjectPool.ReturnObject(toRemove);
        }
        while (generalPannel.childCount > 0)
        {
            GameObject toRemove = generalPannel.transform.GetChild(0).gameObject;
            buttonObjectPool.ReturnObject(toRemove);
        }
        while (adjuvantsPannel.childCount > 0)
        {
            GameObject toRemove = adjuvantsPannel.transform.GetChild(0).gameObject;
            buttonObjectPool.ReturnObject(toRemove);
        }
        while (cardsPannel.childCount > 0)
        {
            GameObject toRemove = cardsPannel.transform.GetChild(0).gameObject;
            buttonObjectPool.ReturnObject(toRemove);
        }
    }

    public void TryTranserPlayableDataToOtherDeck(PlayableData playableData)
    {
        AddPlayableData(playableData, otherDeck);
        RemovePlayableData(playableData, this);

        RefreshDisplay();
        otherDeck.RefreshDisplay();
    }

    public void AddPlayableData(PlayableData playableDataToAdd, DeckScrollList deckList)
    {
        deckList.playableDataList.Add(playableDataToAdd);
    }

    private void RemovePlayableData(PlayableData playableDataToRemove, DeckScrollList deckList)
    {
        for (int i= deckList.playableDataList.Count-1; i>=0; i--)
        {
            if (deckList.playableDataList[i] == playableDataToRemove)
            {
                deckList.playableDataList.RemoveAt(i);
            }
        }
    }
}
