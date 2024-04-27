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
        // ���������, ��������� �� �������� �� �����
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    private void FixedUpdate()
    {
        moveInput = joystick.Horizontal;
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    // ����� ��� ������
    public void Jump()
    {
        // ���������, ���� �� � ��������� ������
        if (jumpsLeft > 0)
        {
            // ��������� ���������� �������
            jumpsLeft--;

            // �������
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ���� �������� ��������� �� �����, �� ��������� ���������� �������
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpsLeft = maxJumps;
        }
    }    
}