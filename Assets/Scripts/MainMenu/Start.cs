using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level_1");// в кавычках название сцены на которую осуществляется переход
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
