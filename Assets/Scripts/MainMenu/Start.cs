using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level_1");// � �������� �������� ����� �� ������� �������������� �������
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
