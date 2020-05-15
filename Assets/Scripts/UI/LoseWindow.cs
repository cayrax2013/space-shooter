using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseWindow : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;

    public void Open()
    {
        _losePanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("level1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
