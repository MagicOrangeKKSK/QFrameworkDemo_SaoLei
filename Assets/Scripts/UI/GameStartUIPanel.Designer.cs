using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:7605b9f1-42a5-4000-960f-7dc8293b3679
	public partial class GameStartUIPanel
	{
		public const string Name = "GameStartUIPanel";
		
		[SerializeField]
		public UnityEngine.UI.Button GameStartEasyButton;
		[SerializeField]
		public UnityEngine.UI.Button GameStartNormalButton;
		[SerializeField]
		public UnityEngine.UI.Button GameStartHardButton;
		
		private GameStartUIPanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			GameStartEasyButton = null;
			GameStartNormalButton = null;
			GameStartHardButton = null;
			
			mData = null;
		}
		
		public GameStartUIPanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		GameStartUIPanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new GameStartUIPanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
