using Marisa;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Marisa
{

    [RequireComponent(typeof(StrongButton))]
    public class ButtonHoverFadeEffect : MonoBehaviour 
    {
        public float MinAlpha = 0f;
        public float MaxAlpha = 0.3f;
        public float Speed = 5f;  //在倒数秒内达到目标值。

        public Image Target;

        [ReadOnly]
        public bool Hovered = false;
        [HideInInspector] public StrongButton Button;

        private void Awake()
        {
            Button = GetComponent<StrongButton>();
            Button.OnEnterHovered += () => Hovered = true;
            Button.OnExitHovered += () => Hovered = false;
        }

        private void Update()
        {
            if (Target == null)
                return;
            Color c = Target.color;
            c.a = Hovered ? Mathf.Min(MaxAlpha, c.a + Time.deltaTime * Speed)
                          : Mathf.Max(MinAlpha, c.a - Time.deltaTime * Speed);
            Target.color = c;
        }
    }
}