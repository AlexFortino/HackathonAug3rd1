using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    GameObject UIShopCanvas;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        UIShopCanvas = GameObject.FindGameObjectWithTag("ShopUI");
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void waveEnd()
    {
        //Turn UI ON
        //And Pause Game
        UIShopCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void setAR (){
        Player.GetComponent<PlayerWeaponInteract>().changeWeapons(1);
        Time.timeScale = 1;
        Debug.Log(Player.GetComponent<PlayerWeaponInteract>().currentWeapon);
        UIShopCanvas.SetActive(true);
    }
    public void setPistiol()
    {
        Player.GetComponent<PlayerWeaponInteract>().changeWeapons(0);
        Time.timeScale = 1;
        Debug.Log(Player.GetComponent<PlayerWeaponInteract>().currentWeapon);
        UIShopCanvas.SetActive(true);
    }
    public void setShotgun()
    {
        Player.GetComponent<PlayerWeaponInteract>().changeWeapons(2);
        Time.timeScale = 1;
        Debug.Log(Player.GetComponent<PlayerWeaponInteract>().currentWeapon);
        UIShopCanvas.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
