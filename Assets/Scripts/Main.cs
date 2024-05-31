using QFramework;
using QFramework.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Marisa
{
    public class Main : MonoBehaviour
    {
        private void Awake()
        {
            ResKit.Init();
        }

        private void Start()
        {
            UIKit.Root.SetResolution(1080, 1334, 0f);
            UIKit.OpenPanel<GameStartUIPanel>();
        }
    }
}