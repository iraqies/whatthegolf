using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012B3")]
	public class GUIEvent : BaseEvent<GUIEvent.GUIEventType>
	{
		[Token(Token = "0x20012B4")]
		public enum GUIEventType
		{
			[Token(Token = "0x40064D2")]
			Empty = 0,
			[Token(Token = "0x40064D3")]
			ClickSelectionTool = 1,
			[Token(Token = "0x40064D4")]
			ClickPaintTool = 2,
			[Token(Token = "0x40064D5")]
			ClickEraseTool = 3,
			[Token(Token = "0x40064D6")]
			ClickSetLayer = 4,
			[Token(Token = "0x40064D7")]
			ClickUndo = 5,
			[Token(Token = "0x40064D8")]
			ClickRedo = 6,
			[Token(Token = "0x40064D9")]
			ClickElement = 7,
			[Token(Token = "0x40064DA")]
			ClickTerrainEraserMode = 8,
			[Token(Token = "0x40064DB")]
			ClickSelectableEraserMode = 9,
			[Token(Token = "0x40064DC")]
			ClickEditorBack = 10,
			[Token(Token = "0x40064DD")]
			ClickEditorFile = 11,
			[Token(Token = "0x40064DE")]
			ClickEditorSave = 12,
			[Token(Token = "0x40064DF")]
			ClickSaveAs = 13,
			[Token(Token = "0x40064E0")]
			ClickSaveNew = 14,
			[Token(Token = "0x40064E1")]
			ClickCancelSaveWithDetails = 15,
			[Token(Token = "0x40064E2")]
			ClickEditorPlay = 16,
			[Token(Token = "0x40064E3")]
			ClickViewLevelDetails = 17,
			[Token(Token = "0x40064E4")]
			ClickLevelDetailsPlay = 18,
			[Token(Token = "0x40064E5")]
			ClickLevelDetailsEdit = 19,
			[Token(Token = "0x40064E6")]
			ClickGolflixHome = 20,
			[Token(Token = "0x40064E7")]
			ClickGolflixPlay = 21,
			[Token(Token = "0x40064E8")]
			ClickGolflixEdit = 22,
			[Token(Token = "0x40064E9")]
			EnterModal = 23,
			[Token(Token = "0x40064EA")]
			ExitModal = 24
		}

		[Token(Token = "0x60056C8")]
		[Address(RVA = "0x1475FA8", Offset = "0x1475FA8", VA = "0x1475FA8")]
		public GUIEvent(GUIEventType eventType, [Optional] object data)
		{
		}

		[Token(Token = "0x60056C9")]
		[Address(RVA = "0x1476018", Offset = "0x1476018", VA = "0x1476018")]
		public static GUIEvent ClickBrushEvent(bool isPaintTool, float brushSize)
		{
			return null;
		}

		[Token(Token = "0x60056CA")]
		[Address(RVA = "0x1476148", Offset = "0x1476148", VA = "0x1476148")]
		public static GUIEvent ClickElement(int elementId)
		{
			return null;
		}
	}
}
