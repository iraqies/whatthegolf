namespace WhatTheGolf.LevelDesigner.Events
{
	public class GUIEvent : BaseEvent<GUIEvent.GUIEventType>
	{
		public enum GUIEventType
		{
			Empty = 0,
			ClickSelectionTool = 1,
			ClickPaintTool = 2,
			ClickEraseTool = 3,
			ClickSetLayer = 4,
			ClickUndo = 5,
			ClickRedo = 6,
			ClickElement = 7,
			ClickTerrainEraserMode = 8,
			ClickSelectableEraserMode = 9,
			ClickEditorBack = 10,
			ClickEditorFile = 11,
			ClickEditorSave = 12,
			ClickSaveAs = 13,
			ClickSaveNew = 14,
			ClickCancelSaveWithDetails = 15,
			ClickEditorPlay = 16,
			ClickViewLevelDetails = 17,
			ClickLevelDetailsPlay = 18,
			ClickLevelDetailsEdit = 19,
			ClickGolflixHome = 20,
			ClickGolflixPlay = 21,
			ClickGolflixEdit = 22,
			EnterModal = 23,
			ExitModal = 24
		}

		public GUIEvent(GUIEventType eventType, object data = null)
			: base(GUIEventType.Empty, (object)null)
		{
		}

		public static GUIEvent ClickBrushEvent(bool isPaintTool, float brushSize)
		{
			return null;
		}

		public static GUIEvent ClickElement(int elementId)
		{
			return null;
		}
	}
}
