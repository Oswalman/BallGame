using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    [Header("Velocidad de movimiento:")]
    public float speed;
    [Header("Fuerza de salto: ")]
    public float jump;
    private Rigidbody2D rb;
    public float distGround;

    private bool isOnGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo") )
        {
            isOnGround = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hider") )
        {
            var obj = GameObject.FindWithTag("Texto");
            if (obj != null)
            {
                obj.SetActive(false);
            }

        }
        else if (collision.CompareTag("KillZone"))
        {
            Scene escena = SceneManager.GetActiveScene();
            SceneManager.LoadScene(escena.name);

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            isOnGround = false;
        }
    }
    private void Update()
    {
       
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        Vector2 movimiento = new Vector2(movHorizontal, 0f);
        rb.AddForce(movimiento*speed*2f);
        rb.rotation=
        if (Input.GetButtonDown("Jump") && isOnGround) //Devuelve verdadero en  el frame que se oprimió
        {

            rb.AddForce(Vector2.up*jump*50f,ForceMode2D.Force);
        }
        /*
        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(Vector2.right*speed);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(Vector2.left * speed);
        }
        else if(Input.GetAxis("Vertical") > 0)

        {
            rb.AddForce(Vector2.up * speed*5.0f);
        }
        else if (Input.GetAxis("Vertical") < 0)

        {
            rb.AddForce(Vector2.down * speed * 5.0f);
        }*/

    }
}
