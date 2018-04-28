using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableableButton : IDeckBuildingButton
{
    private int pushNb; //Number of push before the button get disabled
    private IPlayableData data;

    private SelectionPanel selectionPanel;

    // Use this for initialization
    void Start()
    {

    }

    public void Setup(IPlayableData data, SelectionPanel panel)
    {
        this.data = data;
        buttonText.text = data.name;
        this.pushNb = 1;

        selectionPanel = panel;
    }
    public void Setup(IPlayableData data, SelectionPanel panel, int pushNb)
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
        pushNb--;
        selectionPanel.TryTransferToDeck(item);
        if (pushNb == 0)
        {
            //button.interactable = false;
        }
    }
}
