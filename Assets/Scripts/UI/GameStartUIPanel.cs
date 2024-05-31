using UnityEngine;
using UnityEngine.UI;
using QFramework;
using Marisa;

namespace QFramework.Example
{
	public class GameStartUIPanelData : UIPanelData
	{
	}
	public partial class GameStartUIPanel : UIPanel
	{
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as GameStartUIPanelData ?? new GameStartUIPanelData();
			GameStartEasyButton.onClick.AddListener(() => 
			{
				Debug.Log("Game Easy");
				StartGame(10);
			});

			GameStartNormalButton.onClick.AddListener(() =>
			{
				Debug.Log("Game Normal");
				StartGame(20);
			});

            GameStartHardButton.onClick.AddListener(() =>
			{
				Debug.Log("Game Hard");
				StartGame(40);
			});
        }

		private void StartGame(int number)
		{
			UIKit.OpenPanel<GameMainUIPanel>(new GameMainUIPanelData()
			{
				MineNumber = number
			});
			CloseSelf();
		}

		protected override void OnOpen(IUIData uiData = null)
		{
		}
		
		protected override void OnShow()
		{
		}
		
		protected override void OnHide()
		{
		}
		
		protected override void OnClose()
		{
		}
	}
}
