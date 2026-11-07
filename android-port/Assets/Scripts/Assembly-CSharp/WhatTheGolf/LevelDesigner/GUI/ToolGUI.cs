using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x20012A6")]
	public class ToolGUI : BaseGUI, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		[Token(Token = "0x40064A6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PersistentButton m_SelectionToolButton;

		[Token(Token = "0x40064A7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BrushToolGUI m_PaintToolButton;

		[Token(Token = "0x40064A8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BrushToolGUI m_EraseToolButton;

		[Token(Token = "0x40064A9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button m_UndoButton;

		[Token(Token = "0x40064AA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button m_RedoButton;

		[Token(Token = "0x170009E1")]
		public override bool isActiveOnOpen
		{
			[Token(Token = "0x60056A7")]
			[Address(RVA = "0x171DC94", Offset = "0x171DC94", VA = "0x171DC94", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170009E2")]
		public override bool hasFocus
		{
			[Token(Token = "0x60056A8")]
			[Address(RVA = "0x171DC9C", Offset = "0x171DC9C", VA = "0x171DC9C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170009E3")]
		private bool isDraggingSlider
		{
			[Token(Token = "0x60056A9")]
			[Address(RVA = "0x171DCE8", Offset = "0x171DCE8", VA = "0x171DCE8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60056AA")]
		[Address(RVA = "0x171DD34", Offset = "0x171DD34", VA = "0x171DD34", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x60056AB")]
		[Address(RVA = "0x171E094", Offset = "0x171E094", VA = "0x171E094")]
		private void Update()
		{
		}

		[Token(Token = "0x60056AC")]
		[Address(RVA = "0x171E0F0", Offset = "0x171E0F0", VA = "0x171E0F0")]
		private void OnSelectionToolSelected(PersistentButton obj)
		{
		}

		[Token(Token = "0x60056AD")]
		[Address(RVA = "0x171E154", Offset = "0x171E154", VA = "0x171E154")]
		private void OnPaintToolChanged()
		{
		}

		[Token(Token = "0x60056AE")]
		[Address(RVA = "0x171E18C", Offset = "0x171E18C", VA = "0x171E18C")]
		private void OnEraseToolChanged()
		{
		}

		[Token(Token = "0x60056AF")]
		[Address(RVA = "0x171E1C4", Offset = "0x171E1C4", VA = "0x171E1C4")]
		private void OnUndoClicked()
		{
		}

		[Token(Token = "0x60056B0")]
		[Address(RVA = "0x171E228", Offset = "0x171E228", VA = "0x171E228")]
		private void OnRedoClicked()
		{
		}

		[Token(Token = "0x60056B1")]
		[Address(RVA = "0x171E28C", Offset = "0x171E28C", VA = "0x171E28C")]
		private void Show()
		{
		}

		[Token(Token = "0x60056B2")]
		[Address(RVA = "0x171E2F0", Offset = "0x171E2F0", VA = "0x171E2F0")]
		private void Hide()
		{
		}

		[Token(Token = "0x60056B3")]
		[Address(RVA = "0x171E3D4", Offset = "0x171E3D4", VA = "0x171E3D4")]
		private void Disable()
		{
		}

		[Token(Token = "0x60056B4")]
		[Address(RVA = "0x171E3FC", Offset = "0x171E3FC", VA = "0x171E3FC", Slot = "7")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x60056B5")]
		[Address(RVA = "0x171E4A0", Offset = "0x171E4A0", VA = "0x171E4A0")]
		public ToolGUI()
		{
		}
	}
}
