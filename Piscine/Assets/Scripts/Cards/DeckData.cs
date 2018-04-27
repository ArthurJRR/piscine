using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DeckData  { //A deck represent a group of cards
    private bool isPlayable; //If this boolean is set to true then the deck can be used by a player in a match
    private string deckName;

    public CardData[] cards;
}
