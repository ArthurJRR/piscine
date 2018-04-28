using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuScreenController : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject DeckBuildingMenuPanel;

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


}