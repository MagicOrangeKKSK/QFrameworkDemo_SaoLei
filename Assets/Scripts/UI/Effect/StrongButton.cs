using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Marisa
{
    public class StrongButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
    {
        [HideInInspector] public Button Button;
        public event Action OnLeftClicked;
        public event Action OnRightClicked;
        public event Action OnEnterHovered;
        public event Action OnExitHovered;
        public bool Hovering = false;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
                OnLeftClicked?.Invoke();
            else if(eventData.button == PointerEventData.InputButton.Right)
                OnRightClicked?.Invoke();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            Hovering = true;
            OnEnterHovered?.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Hovering = false;
            OnExitHovered?.Invoke();
        }
    }
}