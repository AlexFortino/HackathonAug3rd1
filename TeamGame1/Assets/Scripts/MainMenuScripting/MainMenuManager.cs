using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    //Main menu button references
    [Header("Main Menu Buttons")]
    public GameObject playButton;
    public GameObject statisticsButton;
    public GameObject quitButton;
    public Button backButton;

    [Header("Additional Panels")]
    public GameObject playPanel;
    public GameObject statisticsPanel;

    //Main menu button methods
    public void quitApplication(){
        Debug.Log("Quit");
        Application.Quit();
    }
    public void back(){
        playButton.SetActive(true);
        statisticsButton.SetActive(true);
        quitButton.SetActive(true);
        playPanel.SetActive(false);
        statisticsPanel.SetActive(false);
        backButton.interactable = false;
    }
    public void playButtonSelected(){
        makeAllButtonsInactive();
        playPanel.SetActive(true);
    }
    public void statisticsButtonSelected(){
        makeAllButtonsInactive();
        statisticsPanel.SetActive(true);
    }
    public void levelOneSelected(){
        SceneManager.LoadScene("LevelOne", LoadSceneMode.Single);
    }

    //Additional use methods
    public void makeAllButtonsInactive(){
        playButton.SetActive(false);
        statisticsButton.SetActive(false);
        quitButton.SetActive(false);
        backButton.interactable = true;
    }

    //Start method
    void Start(){
        backButton.interactable = false;
    }

}
