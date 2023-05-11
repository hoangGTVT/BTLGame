using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
public class ban : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab c?a gameobject vi?n ??n
    public float bulletSpeed = 10f; // T?c ?? di chuy?n c?a vi?n ??n
    public int damageAmount = 10; // S? ?i?m m?u tr? ?i khi b?n tr?ng ??i th?
    private Vector3 playerDirection = Vector3.right;
    public TextMeshProUGUI dam;
    public float fireRate = 1f; // Kho?ng th?i gian gi?a c?c l?n b?n
    private float nextFire = 0.0f; // Th?i ?i?m ???c ph?p b?n ti?p theo
    private Animator animator;
    public int damageIncreaseAmount = 5;
    public AudioSource bansound;
    void Start()
    {
        animator = GetComponent<Animator>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "magnum")
        {

            Destroy(collision.gameObject);
            damageAmount += damageIncreaseAmount;

        }


    }
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
       

            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;

                
                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                
                
                StartCoroutine(DanBan(bullet, playerDirection));
               
            }
            

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            playerDirection = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            playerDirection = Vector3.right;
        }
        dam.text = "Damage per bullet:" + damageAmount.ToString();
    }
    IEnumerator DanBan(GameObject obj, Vector3 direction)
    {
        bansound.Play();
        animator.Play("ban"); // play animation ban
        float startTime = Time.time; // th?i ?i?m b?t ??u b?n ??n
        float maxTime = 0.2f; // th?i gian t?i ?a cho animation ban
        while (obj != null && Time.time < startTime + maxTime)
        {
            obj.transform.Translate(direction * bulletSpeed * Time.deltaTime);
            yield return null;
        }
       
        
            
        
        animator.Play("dung"); // play animation d?ng
        while (obj != null && obj.transform.position.x < Camera.main.ViewportToWorldPoint(new Vector2(1f, 0f)).x && obj.transform.position.x > Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f)).x)
        {
            
            obj.transform.Translate(direction * bulletSpeed * Time.deltaTime);
            yield return null;

        }

    
        if(obj !=null)
                {
            Destroy(obj);
}
    }


  
}
