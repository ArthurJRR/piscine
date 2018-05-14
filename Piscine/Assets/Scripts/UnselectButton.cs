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

    public void setup(PlayableData currentPlayableData, DeckScrollList currentScrollList)
    {
        playableData = currentPlayableData;
        buttonText.text = playableData.name;
        image = playableData.image;
        numberOrType.text = playableData.numberOrType;

        scrollList = currentScrollList;
    }

    public void HandleClick()
    {
        scrollList.TryTranserPlayableDataToOtherDeck(playableData);
    }
}
