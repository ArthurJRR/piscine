using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Collections.Generic;


public class SettingsAutoConverter : AssetPostprocessor
{
    static Dictionary<string, Action> parsers;
    static SettingsAutoConverter()
    {
        Debug.Log("Test 1");
        parsers = new Dictionary<string, Action>();
        parsers.Add("General.csv", ParseEnemies);
        Debug.Log("Test 2");
    }

    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        Debug.Log("Test 3");
        for (int i = 0; i < importedAssets.Length; i++)
        {
            string fileName = Path.GetFileName(importedAssets[i]);
            if (parsers.ContainsKey(fileName))
                parsers[fileName]();
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
    static void ParseEnemies()
    {
        Debug.Log("Test 4");
        string filePath = Application.dataPath + "/Settings/General.csv";
        if (!File.Exists(filePath))
        {
            Debug.LogError("Missing Enemies Data: " + filePath);
            return;
        }
        string[] readText = File.ReadAllLines("Assets/Settings/General.csv");
        filePath = "Assets/Settings/Resources/Enemies/";
        for (int i = 1; i < readText.Length; ++i)
        {
            UnitData unitData = ScriptableObject.CreateInstance<UnitData>();
            unitData.Load(readText[i]);
            Debug.Log(unitData.name);
            string fileName = string.Format("{0}{1}.asset", filePath, unitData.name);
            AssetDatabase.CreateAsset(unitData, fileName);
        }
    }
}
