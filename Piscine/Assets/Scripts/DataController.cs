using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour {

    public DeckData[] allDeckData;


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
}
