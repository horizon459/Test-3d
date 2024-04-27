using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private int maxJumps = 1;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.1f;
    [SerializeField] private LayerMask whatIsGround;


    private Rigidbody2D rb;
    private int jumpsLeft;
    private bool isGrounded;
    public Joystick joystick;
    private float moveInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        // Проверяем, находится ли персонаж на земле
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    private void FixedUpdate()
    {
        moveInput = joystick.Horizontal;
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    // Метод для прыжка
    public void Jump()
    {
        // Проверяем, есть ли у персонажа прыжки
        if (jumpsLeft > 0)
        {
            // Уменьшаем количество прыжков
            jumpsLeft--;

            // Прыгаем
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Если персонаж находится на земле, то обновляем количество прыжков
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpsLeft = maxJumps;
        }
    }    
}