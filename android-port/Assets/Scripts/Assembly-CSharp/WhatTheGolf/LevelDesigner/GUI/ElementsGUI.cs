using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001287")]
	public class ElementsGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<GameStateEvent>
	{
		[Token(Token = "0x4006392")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<GUIElementTabContent> tabContentData;

		[Token(Token = "0x4006393")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ElementsTabGUI elementsTabGUIPrefab;

		[Token(Token = "0x4006394")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LayoutGroup tabLayoutGroup;

		[Token(Token = "0x4006395")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LayoutGroup tabContentLayoutGroup;

		[Token(Token = "0x4006396")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ScrollRect scroll;

		[Token(Token = "0x4006397")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshProUGUI tabTitleRenderer;

		[Token(Token = "0x4006398")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TextMeshProUGUI panelPaintTitleRenderer;

		[Token(Token = "0x4006399")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI panelSelectTitleRenderer;

		[Token(Token = "0x400639A")]
		[FieldOffset(Offset = "0x80")]
		private List<ElementsTabGUI> elementTabs;

		[Token(Token = "0x400639B")]
		[FieldOffset(Offset = "0x88")]
		private int m_SelectedTabIndex;

		[Token(Token = "0x400639C")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_IsVisible;

		[Token(Token = "0x400639D")]
		[FieldOffset(Offset = "0x8D")]
		private bool m_IsSelectMode;

		[Token(Token = "0x170009CA")]
		public override bool isActiveOnOpen
		{
			[Token(Token = "0x60055A8")]
			[Address(RVA = "0x143D244", Offset = "0x143D244", VA = "0x143D244", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60055A9")]
		[Address(RVA = "0x143D24C", Offset = "0x143D24C", VA = "0x143D24C", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x60055AA")]
		[Address(RVA = "0x143D9EC", Offset = "0x143D9EC", VA = "0x143D9EC")]
		private void TabGUI_OnElementSelected(ElementDefinition element)
		{
		}

		[Token(Token = "0x60055AB")]
		[Address(RVA = "0x143DA14", Offset = "0x143DA14", VA = "0x143DA14", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x60055AC")]
		[Address(RVA = "0x143E440", Offset = "0x143E440", VA = "0x143E440", Slot = "8")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x60055AD")]
		[Address(RVA = "0x143DE5C", Offset = "0x143DE5C", VA = "0x143DE5C")]
		private void ShowForSelect(int elementId)
		{
		}

		[Token(Token = "0x60055AE")]
		[Address(RVA = "0x143DB30", Offset = "0x143DB30", VA = "0x143DB30")]
		private void ShowForPaint()
		{
		}

		[Token(Token = "0x60055AF")]
		[Address(RVA = "0x143E35C", Offset = "0x143E35C", VA = "0x143E35C")]
		private void Hide()
		{
		}

		[Token(Token = "0x60055B0")]
		[Address(RVA = "0x143E660", Offset = "0x143E660", VA = "0x143E660")]
		private void DisableCanvas()
		{
		}

		[Token(Token = "0x60055B1")]
		[Address(RVA = "0x143E688", Offset = "0x143E688", VA = "0x143E688")]
		public void SetSelectedTab(ElementsTabGUI tabGui)
		{
		}

		[Token(Token = "0x60055B2")]
		[Address(RVA = "0x143E760", Offset = "0x143E760", VA = "0x143E760")]
		public int GetSelectedTabElementIndex(ElementsTabGUI tab, int currentSelection)
		{
			return default;
		}

		[Token(Token = "0x60055B3")]
		[Address(RVA = "0x143D5D0", Offset = "0x143D5D0", VA = "0x143D5D0")]
		private List<ElementDefinition> GetElementsOfGUIElementType(GUIElementType value)
		{
			return null;
		}

		[Token(Token = "0x60055B4")]
		[Address(RVA = "0x143E8DC", Offset = "0x143E8DC", VA = "0x143E8DC")]
		public ElementsGUI()
		{
		}
	}
}
