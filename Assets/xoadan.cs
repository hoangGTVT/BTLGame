using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xoadan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            // Tr? m?u gameobject kh?c khi vi?n ??n ch?m v?o
            
                    Destroy(collision.gameObject);
                }

            }
        }
