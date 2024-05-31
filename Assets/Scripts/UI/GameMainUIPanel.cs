using UnityEngine;
using UnityEngine.UI;
using QFramework;
using System;

namespace Marisa
{
	public class GameMainUIPanelData : UIPanelData
	{
		public int MineNumber = 0;
	}
	public partial class GameMainUIPanel : UIPanel
	{
		private int row = 10;
		private int col = 10;

		private int totalMineNumber = 0;
		private int tempMineNumber = 0;

		private GameMainMineCell[,] mineCells;

		private GameObject mineCellPrefab;
		private ResLoader resLoader = ResLoader.Allocate();
		public bool GameOvered = false;


		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as GameMainUIPanelData ?? new GameMainUIPanelData();
			mineCellPrefab = resLoader.LoadSync<GameObject>("GameMainMineCell");
			TypeEventSystem.Global.Register<GameMainMineCell_OnClickedEventArgs>(OnGameMainCellEvent)
				.UnRegisterWhenGameObjectDestroyed(gameObject);
			InitMineCells();
		}

        private void OnGameMainCellEvent(GameMainMineCell_OnClickedEventArgs args)
        {
			Debug.Log(args.Row+ " "+args.Col);
        }

        private void InitMineCells()
		{
			mineCells = new GameMainMineCell[row, col];
			for(int i = 0; i < row; i++)
			{
				for(int j = 0; j < col; j++)
				{
					mineCells[i, j] = mineCellPrefab.Instantiate()
						.Parent(StartPosition)
						.LocalIdentity()
						.Name($"{i}_{j}")
						.GetComponent<GameMainMineCell>()
						.SetInfo(i, j, new Vector2(i * 103f + 50f, j * 103f + 50f));
				}
			}
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
