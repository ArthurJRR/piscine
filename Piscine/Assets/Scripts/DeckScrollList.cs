using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DeckScrollList : MonoBehaviour {

    public List<Item> itemList;
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
        for ( int i=0; i < itemList.Count; i++)
        {
            Item item = itemList[i];
            GameObject newButton = buttonObjectPool.GetObject();

            switch (item.numberOrType)
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
            unselectButton.setup(item, this);
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

    public void TryTranserItemToOtherDeck(Item item)
    {
        AddItem(item, otherDeck);
        RemoveItem(item, this);

        RefreshDisplay();
        otherDeck.RefreshDisplay();
    }

    public void AddItem(Item itemToAdd, DeckScrollList deckList)
    {
        deckList.itemList.Add(itemToAdd);
    }

    private void RemoveItem (Item itemToRemove, DeckScrollList deckList)
    {
        for (int i= deckList.itemList.Count-1; i>=0; i--)
        {
            if (deckList.itemList[i] == itemToRemove)
            {
                deckList.itemList.RemoveAt(i);
            }
        }
    }
}
