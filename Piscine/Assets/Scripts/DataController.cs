using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class DataController : MonoBehaviour {

    public DeckData[] allDeckData;
    private string materialsDataFileName = "PlayableData.json";


    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("MenuScreen");
    }

    public DeckData GetCurrentRoundData()
    {
        return allDeckData[0];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadGameData()
    {
        string filePath = Path.Combine(Application.dataPath, "Settings/"+materialsDataFileName);

        if(File.Exists(filePath))
        {
            string dataAsJSON = File.ReadAllText(filePath);
            DeckData loadedData = JsonUtility.FromJson<DeckData>(dataAsJSON);

            //dataVariable= loadedData;
        }
        else
        {
            Debug.Log("Cannot Load Game Data");
        }
    }
}
