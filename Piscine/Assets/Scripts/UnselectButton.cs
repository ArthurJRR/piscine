using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnselectButton : MonoBehaviour {

    public Button button;
    public Text nameLabel;
    public Image iconImage;
    public Text numberOrType;

    private Item item;
    private DeckScrollList scrollList;

	// Use this for initialization
	void Start () {
        button.onClick.AddListener(HandleClick);
	}

    public void setup(Item currentItem, DeckScrollList currentScrollList)
    {
        item = currentItem;
        nameLabel.text = item.itemName;
        iconImage = item.itemImage;
        numberOrType.text = item.numberOrType;

        scrollList = currentScrollList;
    }

    public void HandleClick()
    {
        scrollList.TryTranserItemToOtherDeck(item);
    }
}
