using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x200128A")]
	public class EraserModeGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<GameStateEvent>
	{
		[Token(Token = "0x40063B0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PersistentButton terrainButton;

		[Token(Token = "0x40063B1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PersistentButton selectablesButton;

		[Token(Token = "0x40063B2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI terrainText;

		[Token(Token = "0x40063B3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI selectablesText;

		[Token(Token = "0x40063B4")]
		[FieldOffset(Offset = "0x60")]
		private bool m_IsVisible;

		[Token(Token = "0x40063B5")]
		[FieldOffset(Offset = "0x61")]
		private bool isTerrainMode;

		[Token(Token = "0x170009CB")]
		public override bool isActiveOnOpen
		{
			[Token(Token = "0x60055C3")]
			[Address(RVA = "0x1446348", Offset = "0x1446348", VA = "0x1446348", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60055C4")]
		[Address(RVA = "0x1446350", Offset = "0x1446350", VA = "0x1446350", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x60055C5")]
		[Address(RVA = "0x1446488", Offset = "0x1446488", VA = "0x1446488")]
		private void TerrainButton_OnSelected(PersistentButton obj)
		{
		}

		[Token(Token = "0x60055C6")]
		[Address(RVA = "0x1446604", Offset = "0x1446604", VA = "0x1446604")]
		private void SelectablesButton_OnSelected(PersistentButton obj)
		{
		}

		[Token(Token = "0x60055C7")]
		[Address(RVA = "0x14466F8", Offset = "0x14466F8", VA = "0x14466F8", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x60055C8")]
		[Address(RVA = "0x1446904", Offset = "0x1446904", VA = "0x1446904", Slot = "8")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x60055C9")]
		[Address(RVA = "0x1446878", Offset = "0x1446878", VA = "0x1446878")]
		private void Show()
		{
		}

		[Token(Token = "0x60055CA")]
		[Address(RVA = "0x1446794", Offset = "0x1446794", VA = "0x1446794")]
		private void Hide()
		{
		}

		[Token(Token = "0x60055CB")]
		[Address(RVA = "0x144699C", Offset = "0x144699C", VA = "0x144699C")]
		private void DisableCanvas()
		{
		}

		[Token(Token = "0x60055CC")]
		[Address(RVA = "0x14469C4", Offset = "0x14469C4", VA = "0x14469C4")]
		public EraserModeGUI()
		{
		}
	}
}
