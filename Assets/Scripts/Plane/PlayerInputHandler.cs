using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInputHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private float _direction;
    [SerializeField] private PlaneMover _snakeMover;

    private bool _theScreenIsTouch = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        _theScreenIsTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _theScreenIsTouch = false;
    }

    private void Update()
    {
        if (_theScreenIsTouch)
            _snakeMover.Move(_direction);
    }
}
