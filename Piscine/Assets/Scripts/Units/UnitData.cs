using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class UnitData : ScriptableObject
{
    public int hp;
    public int atk;
    //public string description;

    public GameObject Load(string line)
    {
        /*string[] elements = line.Split(',');
        name = elements[0];
        hp = Convert.ToInt32(elements[1]);
        atk = Convert.ToInt32(elements[2]);
        //description = Convert.ToString(elements[3]);*/
        GameObject obj = new GameObject();
        obj.AddComponent<Unit>();
        Unit unit = obj.GetComponent<Unit>();
        unit.SetHp(hp);
        unit.SetAtk(atk);
        return obj;
    }
}