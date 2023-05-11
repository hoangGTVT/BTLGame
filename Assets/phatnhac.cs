using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class phatnhac : MonoBehaviour
{
    public AudioSource bgmnhac;
    // Start is called before the first frame update
    void Start()
    {
        bgmnhac.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) {
            bgmnhac.Pause();
        }
        else
        {
            bgmnhac.UnPause();
        }
    }
}
