using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Managers;

namespace WhatTheGolf.LevelDesigner.Tools
{
	[Token(Token = "0x200126B")]
	public class PaintSelectableTool : BaseTool, IRequireEvents<GUIEvent>, IRequireEvents
	{
		[Token(Token = "0x40062FE")]
		[FieldOffset(Offset = "0x18")]
		private SelectableManager m_SelectableManager;

		[Token(Token = "0x40062FF")]
		[FieldOffset(Offset = "0x20")]
		private CameraManager m_CameraManager;

		[Token(Token = "0x4006300")]
		[FieldOffset(Offset = "0x28")]
		private GizmoManager m_GizmoManager;

		[Token(Token = "0x4006301")]
		[FieldOffset(Offset = "0x30")]
		private float m_BrushSize;

		[Token(Token = "0x4006302")]
		[FieldOffset(Offset = "0x38")]
		private SelectableDefinition m_Element;

		[Token(Token = "0x4006303")]
		[FieldOffset(Offset = "0x40")]
		private float m_IntervalTimer;

		[Token(Token = "0x4006304")]
		[FieldOffset(Offset = "0x44")]
		private float m_PaintStartTime;

		[Token(Token = "0x4006305")]
		[FieldOffset(Offset = "0x48")]
		private float m_LastEraseObjectAudioTime;

		[Token(Token = "0x4006306")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_IsPainting;

		[Token(Token = "0x4006307")]
		[FieldOffset(Offset = "0x4D")]
		private bool m_IsEraser;

		[Token(Token = "0x4006308")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 m_LastPosition;

		[Token(Token = "0x4006309")]
		[FieldOffset(Offset = "0x5C")]
		private Color32 m_Color;

		[Token(Token = "0x1700099E")]
		private SelectableManager selectableManager
		{
			[Token(Token = "0x600550A")]
			[Address(RVA = "0x15D5A28", Offset = "0x15D5A28", VA = "0x15D5A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700099F")]
		private CameraManager cameraManager
		{
			[Token(Token = "0x600550B")]
			[Address(RVA = "0x15D5ADC", Offset = "0x15D5ADC", VA = "0x15D5ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A0")]
		private GizmoManager gizmoManager
		{
			[Token(Token = "0x600550C")]
			[Address(RVA = "0x15D5B90", Offset = "0x15D5B90", VA = "0x15D5B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600550D")]
		[Address(RVA = "0x15D5C44", Offset = "0x15D5C44", VA = "0x15D5C44", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x600550E")]
		[Address(RVA = "0x15D5C4C", Offset = "0x15D5C4C", VA = "0x15D5C4C", Slot = "5")]
		public override void Update(bool guiHasFocus)
		{
		}

		[Token(Token = "0x600550F")]
		[Address(RVA = "0x15D6588", Offset = "0x15D6588", VA = "0x15D6588", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005510")]
		[Address(RVA = "0x15D6300", Offset = "0x15D6300", VA = "0x15D6300")]
		private void DeleleteSelectablesWithinBrushArea(Vector3 center, float radius)
		{
		}

		[Token(Token = "0x6005511")]
		[Address(RVA = "0x15D64D0", Offset = "0x15D64D0", VA = "0x15D64D0")]
		private float PlacementInterval(float paintStartElapsed, float initialPlacementInterval, float minPlacementInterval)
		{
			return default;
		}

		[Token(Token = "0x6005512")]
		[Address(RVA = "0x15D6590", Offset = "0x15D6590", VA = "0x15D6590", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}
	}
}
