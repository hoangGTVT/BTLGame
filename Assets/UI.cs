using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public static bool isPaused;
    
    void Start()
    {

        
    }
    public void choimoi()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void thoat()
    {
        Application.Quit();
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }


    
   

    public void tiep()
    {

        GameObject menu = GameObject.Find("Canvas");
        GameObject menupau = menu.transform.Find("menupause").gameObject;
        Time.timeScale = 1f; 
        menupau.SetActive(false);
        isPaused = false;
    }


}
