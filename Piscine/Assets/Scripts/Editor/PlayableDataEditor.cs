using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class PlayableDataEditor : EditorWindow
{
    public PlayableData playableData;

    private string playableDataProjectFilePath = "/Settings/cardsData.json";

    [MenuItem("Window/Playable Data Editor")]
    private static void Init()
    {
        PlayableDataEditor window = (PlayableDataEditor)EditorWindow.GetWindow(typeof(PlayableDataEditor));
        window.Show();
    }

    private void OnGUI()
    {
        //Vector2 scrollPosition = Vector2.zero;

        //scrollPosition = GUILayout.BeginScrollView(scrollPosition, true, true, GUILayout.Width(100), GUILayout.Height(100));

        if (playableData != null)
        {
            SerializedObject serializedObject = new SerializedObject(this);
            SerializedProperty serializedProperty = serializedObject.FindProperty("playableData");

            EditorGUILayout.PropertyField(serializedProperty, true);

            serializedObject.ApplyModifiedProperties();

            if (GUILayout.Button("Save data"))
            {
                SavePlayableData();
            }
        }

        if (GUILayout.Button("Load Data"))
        {
            LoadPlayableData();
        }

        //GUILayout.EndScrollView();
    }

    private void LoadPlayableData()
    {
        string filePath = Application.dataPath + playableDataProjectFilePath;

        if (File.Exists(filePath))
        {
            string dataAsJSON = File.ReadAllText(filePath);
            playableData = JsonUtility.FromJson<PlayableData>(dataAsJSON);
        }
        else
        {
            playableData = new PlayableData();
        }
    }
	
    private void SavePlayableData()
    {
        string dataAsJSON = JsonUtility.ToJson(playableData);
        string filePath = Application.dataPath + playableDataProjectFilePath;
        File.WriteAllText(filePath, dataAsJSON);
    }
}
