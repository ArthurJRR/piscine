using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[System.Serializable]
public class Item
{
    public string itemName;
    public Image itemImage;
    public string numberOrType;
}

public class DeckScrollList : MonoBehaviour {

    public List<Item> itemList;
    public Transform contentPanel;
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
            newButton.transform.SetParent(contentPanel);

            UnselectButton unselectButton = newButton.GetComponent<UnselectButton>();
            unselectButton.setup(item, this);
        }
    }

    private void RemoveButtons()
    {
        while (contentPanel.childCount > 0)
        {
            GameObject toRemove = transform.GetChild(0).gameObject;
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

    private void AddItem(Item itemToAdd, DeckScrollList deckList)
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
