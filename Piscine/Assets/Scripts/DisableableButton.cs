using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableableButton : IDeckBuildingButton
{
    private int pushNb; //Number of push before the button get disabled
    private PlayableData data;

    private SelectionPanel selectionPanel;

    // Use this for initialization
    void Start()
    {

    }

    public void Setup(PlayableData data, SelectionPanel panel)
    {
        this.data = data;
        buttonText.text = data.name;
        this.pushNb = 1;

        selectionPanel = panel;
    }
    public void Setup(PlayableData data, SelectionPanel panel, int pushNb)
    {
        this.data = data;
        buttonText.text = data.name;
        this.pushNb = pushNb;

        selectionPanel = panel;
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(HandleClick);
    }

    void HandleClick()
    {
        if (pushNb > 0)
        {
            selectionPanel.TryTransferToDeck(playableData);
        }
        else
        {
            button.interactable = false;
        }
        pushNb--;
    }
}
