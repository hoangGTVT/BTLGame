using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class botban : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab c?a gameobject vi?n ??n
    public float bulletSpeed = 10f; // T?c ?? di chuy?n c?a vi?n ??n
    public float fireRate = 1f; // Kho?ng th?i gian gi?a c?c l?n b?n ??n
    private float nextFire = 0.0f; // Th?i ?i?m ???c ph?p b?n ti?p theo
    private Rigidbody2D rb;
    Vector3 enemyDirection;
    public GameObject player;
    public int damageAmount = 10;
    public TextMeshProUGUI dam;
    public int damageIncreaseAmount = 5;
    public AudioSource bansound;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "magnum")
        {

            Destroy(collision.gameObject);
            damageAmount += damageIncreaseAmount;

        }


    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (player.transform.position.x < rb.transform.position.x)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }




        if (transform.localScale.x > 0) // Ki?m tra h??ng di chuy?n c?a enemy
        {
            enemyDirection = Vector3.left;
        }
        else
        {
            enemyDirection = Vector3.right;
        }

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            // T?o m?t gameobject m?i cho vi?n ??n
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            StartCoroutine(DanBan(bullet, enemyDirection));
        }
        dam.text = "Damage per bullet:" + damageAmount.ToString();
    }

    IEnumerator DanBan(GameObject obj, Vector3 direction)
    {

        bansound.Play();
        while (obj != null && obj.transform.position.x < Camera.main.ViewportToWorldPoint(new Vector2(1f, 0f)).x && obj.transform.position.x > Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f)).x)
        {
            obj.transform.Translate(direction * bulletSpeed * Time.deltaTime);
            yield return null;
        }
        if(obj !=null)
                {
            Destroy(obj); }
    }
  
    }

