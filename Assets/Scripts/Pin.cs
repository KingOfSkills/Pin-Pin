using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 20f;

    private Rigidbody2D rb;
    private bool isPinned = false;
    //[SerializeField] private GameObject child;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<SpriteRenderer>().color = DataManager.pin_Color;
        speed = DataManager.pinSpeed;
    }
    private void Update()
    {
        if (!isPinned) {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rotator"))
        {
            transform.SetParent(collision.transform);
            isPinned = true;
            FindObjectOfType<Score>().UpdateScore();
        }
        if (collision.CompareTag("Pin"))
        {
            if (DataManager.lives > 0)
            {
                FindObjectOfType<GameManager>().GameOver();
                FindObjectOfType<Score>().UpdateScore();
            }
            else
            {
                FindObjectOfType<GameManager>().Credits();
            }
        }
    }
}
