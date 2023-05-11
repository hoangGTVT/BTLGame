using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public static AudioSource audioSource;
    public static AudioSource dieAudio;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dieAudio = GetComponent<AudioSource>();
        audioSource.Play();
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
