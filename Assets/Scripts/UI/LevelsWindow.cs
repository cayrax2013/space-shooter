using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsWindow : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;

    public void Open()
    {
        _levelsPanel.SetActive(true);
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Close()
    {
        _levelsPanel.SetActive(false);
    }
}
