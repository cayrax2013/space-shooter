using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuWindow : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    [SerializeField] private LevelsWindow _levelsWindow;

    private RectTransform _rectTransform;
    private bool _isPress = false;

    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void Play()
    {
        _levelsWindow.Open();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _isPress = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _isPress = true;
    }

    private void Update()
    {
        if (_isPress)
            _rectTransform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        else
            _rectTransform.localScale = new Vector3(1, 1, 1);

    }
}
