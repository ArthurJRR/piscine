using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableableButton : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    private int pushNb; //Number of push before the button get disabled

    private FactionData faction;
    private CharacterData character;
    private CardData card;

    // Use this for initialization
    void Start()
    {

    }

    public void Setup(FactionData faction)
    {
        this.faction = faction;
        buttonText.text = faction.name;
        this.pushNb = 1;
    }
    public void Setup(CharacterData character)
    {
        this.character = character;
        buttonText.text = character.name;
        this.pushNb = 1;
    }
    public void Setup(CardData card, int pushNb)
    {
        this.card = card;
        buttonText.text = card.title;
        this.pushNb = pushNb;
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(HandleClick);
    }

    void HandleClick()
    {
        pushNb--;
        if (pushNb == 0)
        {
            button.interactable = false;
        }
    }
}
