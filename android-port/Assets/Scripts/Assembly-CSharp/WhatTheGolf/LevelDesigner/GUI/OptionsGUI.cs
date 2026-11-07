using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x200129C")]
	public sealed class OptionsGUI : BaseGUI, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		[Token(Token = "0x400646D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private OptionsGUIData m_Data;

		[Token(Token = "0x400646E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button m_BackButton;

		[Token(Token = "0x400646F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button m_FileButton;

		[Token(Token = "0x4006470")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button m_SaveButton;

		[Token(Token = "0x4006471")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button m_PlayButton;

		[Token(Token = "0x4006472")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SVGImage m_PlayImage;

		[Token(Token = "0x170009D4")]
		public override bool isActiveOnOpen
		{
			[Token(Token = "0x6005652")]
			[Address(RVA = "0x159D014", Offset = "0x159D014", VA = "0x159D014", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005653")]
		[Address(RVA = "0x159D01C", Offset = "0x159D01C", VA = "0x159D01C", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005654")]
		[Address(RVA = "0x159D044", Offset = "0x159D044", VA = "0x159D044", Slot = "7")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x6005655")]
		[Address(RVA = "0x159D2E0", Offset = "0x159D2E0", VA = "0x159D2E0")]
		public void OnClickBack()
		{
		}

		[Token(Token = "0x6005656")]
		[Address(RVA = "0x159D344", Offset = "0x159D344", VA = "0x159D344")]
		public void OnClickFile()
		{
		}

		[Token(Token = "0x6005657")]
		[Address(RVA = "0x159D3A8", Offset = "0x159D3A8", VA = "0x159D3A8")]
		public void OnClickSave()
		{
		}

		[Token(Token = "0x6005658")]
		[Address(RVA = "0x159D40C", Offset = "0x159D40C", VA = "0x159D40C")]
		public void OnClickPlay()
		{
		}

		[Token(Token = "0x6005659")]
		[Address(RVA = "0x159D470", Offset = "0x159D470", VA = "0x159D470")]
		public OptionsGUI()
		{
		}
	}
}
