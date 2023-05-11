using UnityEngine;

public class cham : MonoBehaviour
{
    
    public float hitForce = 0.5f; 
    void OnTriggerEnter2D(Collider2D other)
    {
        ban myBan = new ban();
        int myDamage = myBan.damageAmount;
        if (other.gameObject.tag=="Bullet")
        {
            
            mau enemyHealth = GetComponent<mau>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(myDamage);
            }


            /* Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Vector3 hitDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(hitDirection * hitForce, ForceMode2D.Impulse);
            */

            
            
        }
    }

    

}
