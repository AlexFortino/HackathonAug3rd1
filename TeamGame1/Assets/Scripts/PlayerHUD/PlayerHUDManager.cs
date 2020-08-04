using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUDManager : MonoBehaviour
{
    [Header("No references")]
    GameObject player;
    
    public GameObject healthBar;
    public GameObject pauseButton;
    public GameObject pauseUI;

    public static bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //healthBar.GetComponent<Slider>().maxValue = player.GetComponent<PlayerHealth>().health;
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                continuePlay();
            }else{
                pause();
            }
        }
    }

    public void pause(){
        pauseUI.SetActive(true); 
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void quit(){
        Application.Quit();
    }
    public void continuePlay(){
        pauseUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
