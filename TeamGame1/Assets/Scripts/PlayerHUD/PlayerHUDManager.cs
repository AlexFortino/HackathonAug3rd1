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
    public GameObject crossHair;
    public Text waveCountText;

    public static bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.GetComponent<Slider>().value = player.GetComponent<PlayerHealth>().health;
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                continuePlay();
            }else{
                pause();
            }
        }
        crossHair.transform.position = Input.mousePosition;
        if(crossHair.transform.position.y <= 100){
            crossHair.SetActive(false);
        }else{
            crossHair.SetActive(true);
        }
        waveCountText.text = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Wave>().getNumWaves().ToString();
    }

    public void pause(){
        pauseUI.SetActive(true); 
        pauseButton.SetActive(false);
        crossHair.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void quit(){
        Application.Quit();
    }
    public void continuePlay(){
        pauseUI.SetActive(false);
        pauseButton.SetActive(true);
        crossHair.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
