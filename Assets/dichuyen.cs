using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
    public bool isfacingright = true;
    public bool isground = true;
    public float speed;
    public float jumpForce = 20f; // L?c nh?y
    private float trai_phai;
    private Rigidbody2D rb;
    private Animator animator;
    public float speedIncreaseAmount = 3f;
    
    private bool isSpeedIncreasing = false;
    public float speedIncreaseTime = 3f;
    public AudioSource jumpsound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        trai_phai = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y); // đi sang trái
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y); // đi sang phải
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y); // không di chuyển nếu không có phím nào được ấn
        }

        flip();
        animator.SetFloat("move", Mathf.Abs(trai_phai));

        if (Input.GetKeyDown(KeyCode.W) && isground) // N?u ng??i ch?i nh?n n?t Space v? ?ang ch?m ground
        {
            jumpsound.Play();
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isground = false;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isground = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isground = true;
        }
        if (collision.gameObject.tag == "boost")
        {
            if (!isSpeedIncreasing)
            {
                Destroy(collision.gameObject);
                StartCoroutine(IncreaseSpeedCoroutine());
            }
        }


    }
    IEnumerator IncreaseSpeedCoroutine()
    {
        
        isSpeedIncreasing = true;

        // Tăng giá trị biến speedp
        speed += speedIncreaseAmount;

      
        yield return new WaitForSeconds(speedIncreaseTime);

        
        speed -= speedIncreaseAmount;

        
        isSpeedIncreasing = false;
    }
    void flip()
    {
        if (isfacingright && trai_phai < 0 || !isfacingright && trai_phai > 0)
        {
            isfacingright = !isfacingright;
            Vector3 xoay = transform.localScale;
            xoay.x = xoay.x * -1;
            transform.localScale = xoay;
        }
    }
   
}