using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiepdung : MonoBehaviour
{
    public static bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        GameObject menu = GameObject.Find("Canvas");
        GameObject menupau = menu.transform.Find("menupause").gameObject;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Time.timeScale = 0f; // t?m d?ng game
                menupau.SetActive(true);

            }
            else
            {
                Time.timeScale = 1f; // ti?p t?c ch?i game
                menupau.SetActive(false);

            }

        }

        if (Time.timeScale == 0f)
        {
            isPaused = true;
        }
        else if (Time.timeScale == 1f)
        { isPaused = false; }

    }
}
