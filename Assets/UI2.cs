using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI2 : MonoBehaviour
{

    public void LoadScene2AndSetActiveMap2()
    {
        SceneManager.sceneLoaded += OnSceneLoaded2;
        SceneManager.LoadScene(2);



    }
    public void LoadScene2AndSetActiveMap1()
    {
        SceneManager.sceneLoaded += OnSceneLoaded1;
        SceneManager.LoadScene(2);



    }

    public void OnSceneLoaded1(Scene scene, LoadSceneMode mode)
    {
        GameObject map = GameObject.Find("map");
        if (map != null)
        {
            GameObject map1 = map.transform.Find("map1").gameObject;
            GameObject map2 = map.transform.Find("map2").gameObject;

            if (map2 != null && map1 != null)
            {

                map1.SetActive(true);
                map2.SetActive(false);
                AstarPath.active.Scan();
            }
        }
    }
    public void OnSceneLoaded2(Scene scene, LoadSceneMode mode)
    {
        GameObject map = GameObject.Find("map");
        if (map != null)
        {
            GameObject map1 = map.transform.Find("map1").gameObject;
            GameObject map2 = map.transform.Find("map2").gameObject;

            if (map2 != null && map1 != null)
            {

                map1.SetActive(false);
                map2.SetActive(true);
                AstarPath.active.Scan();
            }
        }

    }
    }


