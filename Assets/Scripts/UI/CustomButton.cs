using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CustomButton : MonoBehaviour, IPointerClickHandler
{
    public event Action Pressed;

    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Image image;

    public void OnPointerClick(PointerEventData eventData)
    {
        Pressed?.Invoke();
    }
}
