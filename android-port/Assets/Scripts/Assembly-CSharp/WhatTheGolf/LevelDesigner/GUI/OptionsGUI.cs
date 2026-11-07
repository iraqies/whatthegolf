using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public sealed class OptionsGUI : BaseGUI, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		[SerializeField]
		private OptionsGUIData m_Data;

		[SerializeField]
		private Button m_BackButton;

		[SerializeField]
		private Button m_FileButton;

		[SerializeField]
		private Button m_SaveButton;

		[SerializeField]
		private Button m_PlayButton;

		[SerializeField]
		private SVGImage m_PlayImage;

		public override bool isActiveOnOpen => false;

		public override void Init()
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		public void OnClickBack()
		{
		}

		public void OnClickFile()
		{
		}

		public void OnClickSave()
		{
		}

		public void OnClickPlay()
		{
		}
	}
}
