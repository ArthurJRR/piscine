using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item: PlayableData
{
    /*public string itemName;
    public Sprite sprite;
    public string numberOrType;

    public Item(string itemName, Sprite sprite, string numberOrType)
    {
        this.itemName = itemName;
        this.sprite = sprite;
        this.numberOrType = numberOrType;
    }*/
    public Item(string name, string description, string image, string numberOrType)
    {
        this.name = name;
        this.description = description;
        this.image = image;
        this.numberOrType = numberOrType;
    }
}