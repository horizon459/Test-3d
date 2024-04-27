using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // ��������� �������� � �������
        {
            Debug.Log("������� ���!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ������������� ������� �������
        }
        if (collision.CompareTag("Enemy")) // ��������� �������� � �������
        {
            Debug.Log("�� ��������!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ������������� ������� �������
        }
    }
}
