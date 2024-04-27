using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f; // заданная сила прыжка

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // начальный прыжок
    }

    void Update()
    {
        if (rb.velocity.y == 0) // если объект на земле
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); // прыжок вверх
        }
    }
}
