using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class DeckDataEditor : EditorWindow
{
    public DeckData deckData;

    private string deckDataProjectFilePath = "";

    [MenuItem("Window/Deck Data Editor")]
    private static void Init()
    {
        DeckDataEditor window = (DeckDataEditor)EditorWindow.GetWindow(typeof(DeckDataEditor));
        window.Show();
    }

    private void OnGUI()
    {
        if (deckData != null)
        {
            SerializedObject serializedObject = new SerializedObject(this);
            SerializedProperty serializedProperty = serializedObject.FindProperty("deckData");

            EditorGUILayout.PropertyField(serializedProperty, true);

            serializedObject.ApplyModifiedProperties();

            if (GUILayout.Button("Save data"))
            {
                SaveDeckData();
            }
        }

        if (GUILayout.Button("Load Data"))
        {
            LoadDeckData();
        }
    }

    private void LoadDeckData()
    {
        string filePath = Application.dataPath + deckDataProjectFilePath;

        if (File.Exists(filePath))
        {
            string dataAsJSON = File.ReadAllText(filePath);
            deckData = JsonUtility.FromJson<DeckData>(dataAsJSON);
        }
        else
        {
            deckData = new DeckData();
        }
    }
	
    private void SaveDeckData()
    {
        string dataAsJSON = JsonUtility.ToJson(deckData);
        string filePath = Application.dataPath + deckDataProjectFilePath;
        File.WriteAllText(filePath, dataAsJSON);
    }
}
