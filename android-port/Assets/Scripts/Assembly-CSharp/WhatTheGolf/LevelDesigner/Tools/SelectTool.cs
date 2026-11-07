using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Managers;
using WhatTheGolf.LevelDesigner.Selectables;

namespace WhatTheGolf.LevelDesigner.Tools
{
	[Token(Token = "0x200126E")]
	public sealed class SelectTool : BaseTool, IRequireEvents<GUIEvent>, IRequireEvents
	{
		[Token(Token = "0x4006319")]
		[FieldOffset(Offset = "0x18")]
		private SelectableManager m_SelectableManager;

		[Token(Token = "0x400631A")]
		[FieldOffset(Offset = "0x20")]
		private GizmoManager m_GizmoManager;

		[Token(Token = "0x400631B")]
		[FieldOffset(Offset = "0x28")]
		private Bounds m_SelectGizmoBounds;

		[Token(Token = "0x400631C")]
		[FieldOffset(Offset = "0x40")]
		private Bounds m_RotateGizmoBounds;

		[Token(Token = "0x400631D")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 m_SelectionOffset;

		[Token(Token = "0x400631E")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 m_RotateSelectionOffset;

		[Token(Token = "0x400631F")]
		[FieldOffset(Offset = "0x68")]
		private bool m_TranslationGizmoSelected;

		[Token(Token = "0x4006320")]
		[FieldOffset(Offset = "0x69")]
		private bool m_RotationGizmoSelected;

		[Token(Token = "0x4006321")]
		[FieldOffset(Offset = "0x6A")]
		private bool m_LastHoverRotateGizmoState;

		[Token(Token = "0x4006322")]
		[FieldOffset(Offset = "0x70")]
		private Selectable m_LastSelectableHit;

		[Token(Token = "0x4006323")]
		[FieldOffset(Offset = "0x78")]
		private Color32 m_SelectedColor;

		[Token(Token = "0x4006324")]
		[FieldOffset(Offset = "0x7C")]
		private Color32 m_HighlightColor;

		[Token(Token = "0x170009A6")]
		private SelectableManager selectableManager
		{
			[Token(Token = "0x6005522")]
			[Address(RVA = "0x1682F2C", Offset = "0x1682F2C", VA = "0x1682F2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A7")]
		private GizmoManager gizmoManager
		{
			[Token(Token = "0x6005523")]
			[Address(RVA = "0x1682FE0", Offset = "0x1682FE0", VA = "0x1682FE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005524")]
		[Address(RVA = "0x1683094", Offset = "0x1683094", VA = "0x1683094", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005525")]
		[Address(RVA = "0x168309C", Offset = "0x168309C", VA = "0x168309C", Slot = "5")]
		public override void Update(bool guiHasFocus)
		{
		}

		[Token(Token = "0x6005526")]
		[Address(RVA = "0x1683CD8", Offset = "0x1683CD8", VA = "0x1683CD8")]
		private void DrawGizmos(Selectable selectable, bool hitTranslateGizmo, bool hitRotateGizmo)
		{
		}

		[Token(Token = "0x6005527")]
		[Address(RVA = "0x1684C1C", Offset = "0x1684C1C", VA = "0x1684C1C", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005528")]
		[Address(RVA = "0x1684C24", Offset = "0x1684C24", VA = "0x1684C24", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x6005529")]
		[Address(RVA = "0x16839E4", Offset = "0x16839E4", VA = "0x16839E4")]
		private bool TestSelection(out Selectable selectable)
		{
			return default;
		}

		[Token(Token = "0x600552A")]
		[Address(RVA = "0x1683C60", Offset = "0x1683C60", VA = "0x1683C60")]
		private bool TestSelectRotate()
		{
			return default;
		}

		[Token(Token = "0x600552B")]
		[Address(RVA = "0x1684218", Offset = "0x1684218", VA = "0x1684218")]
		private void RotateSelection()
		{
		}

		[Token(Token = "0x600552C")]
		[Address(RVA = "0x1684394", Offset = "0x1684394", VA = "0x1684394")]
		private void MoveSelection()
		{
		}

		[Token(Token = "0x600552D")]
		[Address(RVA = "0x1684974", Offset = "0x1684974", VA = "0x1684974")]
		private void QueueCircleGizmoForSelectable(Selectable selectable, Color32 color)
		{
		}

		[Token(Token = "0x600552E")]
		[Address(RVA = "0x1684A64", Offset = "0x1684A64", VA = "0x1684A64")]
		private void QueueCrossGizmoForSelectable(Selectable selectable, Color32 color)
		{
		}

		[Token(Token = "0x600552F")]
		[Address(RVA = "0x1684B54", Offset = "0x1684B54", VA = "0x1684B54")]
		private void QueueRotationGizmoForSelectable(Selectable selectable, Color32 color)
		{
		}
	}
}
