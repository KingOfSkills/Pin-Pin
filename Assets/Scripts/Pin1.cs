using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin1 : MonoBehaviour
{
    public float speed = 20f;

    private Rigidbody2D rb;
    [SerializeField] private bool isPinned = false;
    [SerializeField] private GameObject spawnPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
        GetComponent<SpriteRenderer>().color = DataManager.pin_Color;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rotator"))
        {
            transform.position = spawnPoint.transform.position;
        }
    }
}
