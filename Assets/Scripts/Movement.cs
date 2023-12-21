using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;

    public Camera cam;

    public Vector2 mousePos;

    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        Bullet.enemiesKilled = 0;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        if (horizontal > 0)
        {
            gameObject.transform.localScale = new Vector3(0.31057f, 0.31057f, 0.31057f);
        }

        if (horizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(-0.31057f, 0.31057f, 0.31057f);
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

        Vector2 lookDir = mousePos - body.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
    }

    void FixedUpdate()
    {
        /*if (horizontal != 0 && vertical != 0)
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        if (horizontal > 0)
        {
            gameObject.transform.localScale = new Vector3(0.31057f, 0.31057f, 0.31057f);
        }

        if (horizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(-0.31057f, 0.31057f, 0.31057f);
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

        Vector2 lookDir = mousePos - body.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;*/
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            Debug.Log("Interaction Confirmed");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            isInRange = true;
        }

        if (collision.gameObject.tag == "LevelTrigger")
        {
            Debug.Log("End");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            isInRange = false;
        }
    }
}
