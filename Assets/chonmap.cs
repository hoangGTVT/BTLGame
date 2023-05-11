using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chonmap : MonoBehaviour
{
    
     void Start()
    {
        SceneManager.LoadScene(2);
        GameObject map = GameObject.Find("map");
           GameObject map2 = map.transform.Find("map2").gameObject;
        if(map2 != null)
        {
            map2.SetActive(true);
        }   
    }


    // Start is called before the first frame update



    // Update is called once per frame
    void Update()
    { }
      
}
