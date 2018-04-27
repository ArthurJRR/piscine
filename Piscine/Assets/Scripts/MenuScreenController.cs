using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuScreenController : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject DeckBuildingMenuPanel;

    private PlayableData playableData;
    private string playableDataProjectFilePath = "/Settings/PlayableData.json";

    public SimpleObjectPool disableableButtonObjectPool;
    public Transform factionButtonParent;

    public void StartGame()
    {
        SceneManager.LoadScene("arthur");
    }
    public void toThisMenu(GameObject toBeActiveMenu)
    {
        MainMenuPanel.GetComponent<CanvasGroup>().interactable=false;
        DeckBuildingMenuPanel.GetComponent<CanvasGroup>().interactable = false;
        MainMenuPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;
        DeckBuildingMenuPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;
        MainMenuPanel.GetComponent<CanvasGroup>().alpha = 0;
        DeckBuildingMenuPanel.GetComponent<CanvasGroup>().alpha = 0;

        toBeActiveMenu.GetComponent<CanvasGroup>().interactable = true;
        toBeActiveMenu.GetComponent<CanvasGroup>().blocksRaycasts = true;
        toBeActiveMenu.GetComponent<CanvasGroup>().alpha = 1;
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
            Debug.Log("Error, Playable File not found");
        }
    }

    public void OnDeckClick()
    {
        LoadPlayableData();
        DisplayFactionButtons();
    }

    public void DisplayFactionButtons()
    {
        for(int i=0; i<playableData.factions.Length; i++)
        {
            GameObject factionButtonGameObject = disableableButtonObjectPool.GetObject();
            //factionButtonGameObjects.Add(factionButtonGameObject);
            factionButtonGameObject.transform.SetParent(factionButtonParent);

            DisableableButton factionButton = factionButtonGameObject.GetComponent<DisableableButton>();
            factionButton.Setup(playableData.factions[i]);
        }

    }

    public void RemoveFactionButtons()
    {
        while (factionButtonParent.childCount > 0)
        {
            GameObject toRemove = factionButtonParent.transform.GetChild(0).gameObject;
            toRemove.SetActive(false);
        }
    }

}