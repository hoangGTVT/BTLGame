using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nhatitem : MonoBehaviour
{
    public AudioSource itemget;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "magnum" || collision.gameObject.tag == "boost" || collision.gameObject.tag == "heal")
        {

            itemget.Play();

        }


    }
}
