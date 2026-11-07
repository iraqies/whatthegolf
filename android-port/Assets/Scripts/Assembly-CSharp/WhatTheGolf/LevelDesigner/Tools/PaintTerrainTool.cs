using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Triband.GolfTerrainTool;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Managers;

namespace WhatTheGolf.LevelDesigner.Tools
{
	[Token(Token = "0x200126C")]
	public class PaintTerrainTool : BaseTool, IRequireEvents<GUIEvent>, IRequireEvents
	{
		[Token(Token = "0x200126D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x486F4", Offset = "0x486F4")]
		private sealed class _003CBrushStartupProcess_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006316")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006317")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006318")]
			[FieldOffset(Offset = "0x20")]
			public PaintTerrainTool _003C_003E4__this;

			[Token(Token = "0x170009A4")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600551F")]
				[Address(RVA = "0x182248C", Offset = "0x182248C", VA = "0x182248C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009A5")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005521")]
				[Address(RVA = "0x18224D4", Offset = "0x18224D4", VA = "0x18224D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600551C")]
			[Address(RVA = "0x18223D8", Offset = "0x18223D8", VA = "0x18223D8")]
			[DebuggerHidden]
			public _003CBrushStartupProcess_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600551D")]
			[Address(RVA = "0x1822404", Offset = "0x1822404", VA = "0x1822404", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600551E")]
			[Address(RVA = "0x1822408", Offset = "0x1822408", VA = "0x1822408", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600551F")]
			[Address(RVA = "0x182248C", Offset = "0x182248C", VA = "0x182248C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005520")]
			[Address(RVA = "0x1822494", Offset = "0x1822494", VA = "0x1822494", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005521")]
			[Address(RVA = "0x18224D4", Offset = "0x18224D4", VA = "0x18224D4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400630A")]
		[FieldOffset(Offset = "0x18")]
		private TerrainManager m_TerrainManager;

		[Token(Token = "0x400630B")]
		[FieldOffset(Offset = "0x20")]
		private CameraManager m_CameraManager;

		[Token(Token = "0x400630C")]
		[FieldOffset(Offset = "0x28")]
		private GizmoManager m_GizmoManager;

		[Token(Token = "0x400630D")]
		[FieldOffset(Offset = "0x30")]
		private Brush m_Brush;

		[Token(Token = "0x400630E")]
		[FieldOffset(Offset = "0x38")]
		private int m_LayerIndex;

		[Token(Token = "0x400630F")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_IsEraser;

		[Token(Token = "0x4006310")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_IsPainting;

		[Token(Token = "0x4006311")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 m_LastPosition;

		[Token(Token = "0x4006312")]
		[FieldOffset(Offset = "0x50")]
		private IEnumerator m_StartupCoroutine;

		[Token(Token = "0x4006313")]
		[FieldOffset(Offset = "0x58")]
		private float m_BrushStartupTime;

		[Token(Token = "0x4006314")]
		[FieldOffset(Offset = "0x5C")]
		private float m_BrushStartupTimer;

		[Token(Token = "0x4006315")]
		[FieldOffset(Offset = "0x60")]
		private Color32 m_Color;

		[Token(Token = "0x170009A1")]
		private TerrainManager terrainManager
		{
			[Token(Token = "0x6005513")]
			[Address(RVA = "0x15D680C", Offset = "0x15D680C", VA = "0x15D680C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A2")]
		private CameraManager cameraManager
		{
			[Token(Token = "0x6005514")]
			[Address(RVA = "0x15D68C0", Offset = "0x15D68C0", VA = "0x15D68C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A3")]
		private GizmoManager gizmoManager
		{
			[Token(Token = "0x6005515")]
			[Address(RVA = "0x15D6974", Offset = "0x15D6974", VA = "0x15D6974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005516")]
		[Address(RVA = "0x15D6A28", Offset = "0x15D6A28", VA = "0x15D6A28", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005517")]
		[Address(RVA = "0x15D6A88", Offset = "0x15D6A88", VA = "0x15D6A88", Slot = "5")]
		public override void Update(bool guiHasFocus)
		{
		}

		[Token(Token = "0x6005518")]
		[Address(RVA = "0x15D7050", Offset = "0x15D7050", VA = "0x15D7050", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005519")]
		[Address(RVA = "0x15D6FDC", Offset = "0x15D6FDC", VA = "0x15D6FDC")]
		private IEnumerator BrushStartupProcess()
		{
			return null;
		}

		[Token(Token = "0x600551A")]
		[Address(RVA = "0x15D70C8", Offset = "0x15D70C8", VA = "0x15D70C8", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x600551B")]
		[Address(RVA = "0x15D6F98", Offset = "0x15D6F98", VA = "0x15D6F98")]
		private bool HasPaintInput()
		{
			return default;
		}
	}
}
