
using UnityEngine;

public class chamdanen : MonoBehaviour
{
    // Start is called before the first frame update
    public float hitForce = 0.5f;
   
    
    
    void OnTriggerEnter2D(Collider2D other)
    {
        botban Ban = new botban();
        int myDamage = Ban.damageAmount;
        if (other.gameObject.tag == "Bullet1")
        {

            Maupl PLHealth = GetComponent<Maupl>();
            if (PLHealth != null)
            {
                PLHealth.TakeDamage(myDamage);
            }


          
           Destroy(other.gameObject);


        }
        
    }
    
}
