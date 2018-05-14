using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayableData {

    public string name;
    public string description;
    public string image;
    public string numberOrType;

    public PlayableData(string name, string description, string image, string numberOrType)
    {
        this.name = name;
        this.description = description;
        this.image = image;
        this.numberOrType = numberOrType;
    }

    public PlayableData()
    {
    }
}
