using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Maupl : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int maxHealth = 1000;
    public int currentHealth;
    private Vector3 startPosition;
    public slidermau thanhmau;
    public Transform vt;
    public TextMeshProUGUI kq;
    public TextMeshProUGUI mau;
    public int healthIncreaseAmount = 50;
   
   
    void Start()
    {
        
        currentHealth = maxHealth;
        startPosition = transform.position;
        thanhmau.setmaxmau(maxHealth);
        thanhmau.setmau(currentHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "heal")
        {
            
                Destroy(collision.gameObject);
                currentHealth += healthIncreaseAmount;
            
        }


    }
  
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            
            Die();
            
        }
        else
        {
            thanhmau.setmau(currentHealth);
        }
    }

    void Update()
    {
       
        float y = transform.position.y;

        if(currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }
        if (y < -7f || currentHealth <= 0)
        {
            Die();
            Time.timeScale = 0f; // D?ng game
        }
        mau.text = "Health:" + currentHealth.ToString() + "/" + maxHealth.ToString();

    }


    void Die()
    {
        currentHealth = 0;
        kq.text = "Player lose";
        GameObject menu = GameObject.Find("Canvas");
        GameObject menukq = menu.transform.Find("ketqua").gameObject;
        menukq.SetActive(true);
        

    }
}
