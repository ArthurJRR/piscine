using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectFactionButton : MonoBehaviour
{

    public Text buttonText;

    private FactionData factionData;

    // Use this for initialization
    void Start()
    {

    }

    public void Setup(FactionData faction)
    {
        this.factionData = faction;
        buttonText.text = faction.factionName;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
