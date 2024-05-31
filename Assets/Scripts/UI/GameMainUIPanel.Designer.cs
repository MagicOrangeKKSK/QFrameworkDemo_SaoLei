using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace Marisa
{
	// Generate Id:cbcb0a0a-fee7-4d87-ae26-6df88de4a059
	public partial class GameMainUIPanel
	{
		public const string Name = "GameMainUIPanel";
		
		[SerializeField]
		public RectTransform StartPosition;
		
		private GameMainUIPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			StartPosition = null;
			
			mData = null;
		}
		
		public GameMainUIPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		GameMainUIPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new GameMainUIPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
