using UnityEngine;
using QFramework;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
namespace Marisa
{
	public partial class GameMainMineCell : ViewController
	{
		[HideInInspector]
		public RectTransform Rect;
		[HideInInspector]
		public StrongButton Button;

		public int X;
		public int Y;

		public bool Clicked = false;

		private void Awake()
		{
			Rect = GetComponent<RectTransform>();
			Button = GetComponent<StrongButton>();
			Button.OnLeftClicked += OnLeftClicked;
			Button.OnRightClicked += OnRightClicked;
		}

		public GameMainMineCell SetInfo(int x, int y, Vector2 position)
		{
			this.X = x;
			this.Y = y;
			this.Rect.anchoredPosition = position;
			return this;
		}

		public void OnLeftClicked()
		{
			if (Clicked)
				return;
			TypeEventSystem.Global.Send(new GameMainMineCell_OnClickedEventArgs(this, X, Y, 1)); 
			Clicked = true;
		}

		public void OnRightClicked()
		{
			TypeEventSystem.Global.Send(new GameMainMineCell_OnClickedEventArgs(this, X, Y, 2));
		}

        
    }
}
