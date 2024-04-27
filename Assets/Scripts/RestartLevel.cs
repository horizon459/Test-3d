using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Проверяем коллизию с игроком
        {
            Debug.Log("Победил БОТ!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Перезапускаем текущий уровень
        }
        if (collision.CompareTag("Enemy")) // Проверяем коллизию с игроком
        {
            Debug.Log("ВЫ победили!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Перезапускаем текущий уровень
        }
    }
}
