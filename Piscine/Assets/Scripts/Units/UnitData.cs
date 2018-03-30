using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class UnitData : ScriptableObject
{
    public int hp;
    public int atk;
    //public string description;

    public void Load(string line)
    {
        string[] elements = line.Split(',');
        name = elements[0];
        hp = Convert.ToInt32(elements[1]);
        atk = Convert.ToInt32(elements[2]);
    }

    public GameObject retrieve(string line)
    {
        GameObject obj = new GameObject();
        obj.AddComponent<Unit>();
        Unit unit = obj.GetComponent<Unit>();
        unit.SetHp(hp);
        unit.SetAtk(atk);
        return obj;
    }
}