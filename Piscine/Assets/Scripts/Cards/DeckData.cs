using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DeckData  { //A deck represent a group of cards
    public string deckName;
    public CardData[] deckCards;
    public bool isPlayable; //If this boolean is set to true then the deck can be used by a player in a match
}
