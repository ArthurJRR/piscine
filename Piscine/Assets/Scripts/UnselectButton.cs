using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnselectButton : IDeckBuildingButton {

    private DeckScrollList scrollList;

	// Use this for initialization
	void Start () {
        button.onClick.AddListener(HandleClick);
	}

    public void setup(Item currentItem, DeckScrollList currentScrollList)
    {
        item = currentItem;
        buttonText.text = item.name;
        image = item.image;
        numberOrType.text = item.numberOrType;

        scrollList = currentScrollList;
    }

    public void HandleClick()
    {
        scrollList.TryTranserItemToOtherDeck(item);
    }
}
