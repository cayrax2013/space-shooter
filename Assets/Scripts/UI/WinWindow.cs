using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinWindow : MonoBehaviour
{
    [SerializeField] private GameObject _winWindow;

    public void Open()
    {
        _winWindow.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
