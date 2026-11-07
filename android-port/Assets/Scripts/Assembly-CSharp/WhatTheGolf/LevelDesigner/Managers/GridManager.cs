using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Token(Token = "0x20012C9")]
	public sealed class GridManager : BaseManager, IRequireEvents<GameStateEvent>, IRequireEvents, IRequireRender
	{
		[Token(Token = "0x20012CA")]
		private struct ShaderID
		{
			[Token(Token = "0x4006546")]
			[FieldOffset(Offset = "0x0")]
			public static readonly int GridColor;
		}

		[Token(Token = "0x20012CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48998", Offset = "0x48998")]
		private sealed class _003CTransitionGrid_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006547")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006548")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006549")]
			[FieldOffset(Offset = "0x20")]
			public GridManager _003C_003E4__this;

			[Token(Token = "0x400654A")]
			[FieldOffset(Offset = "0x28")]
			public bool state;

			[Token(Token = "0x400654B")]
			[FieldOffset(Offset = "0x2C")]
			public float transitionTime;

			[Token(Token = "0x400654C")]
			[FieldOffset(Offset = "0x30")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x170009F2")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005712")]
				[Address(RVA = "0x17B96E0", Offset = "0x17B96E0", VA = "0x17B96E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009F3")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005714")]
				[Address(RVA = "0x17B9728", Offset = "0x17B9728", VA = "0x17B9728", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600570F")]
			[Address(RVA = "0x17B95B4", Offset = "0x17B95B4", VA = "0x17B95B4")]
			[DebuggerHidden]
			public _003CTransitionGrid_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005710")]
			[Address(RVA = "0x17B95E0", Offset = "0x17B95E0", VA = "0x17B95E0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005711")]
			[Address(RVA = "0x17B95E4", Offset = "0x17B95E4", VA = "0x17B95E4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005712")]
			[Address(RVA = "0x17B96E0", Offset = "0x17B96E0", VA = "0x17B96E0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005713")]
			[Address(RVA = "0x17B96E8", Offset = "0x17B96E8", VA = "0x17B96E8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005714")]
			[Address(RVA = "0x17B9728", Offset = "0x17B9728", VA = "0x17B9728", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400653C")]
		private const float kPlaneScale = 0.1f;

		[Token(Token = "0x400653D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material m_Material;

		[Token(Token = "0x400653E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_GridSize;

		[Token(Token = "0x400653F")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_Initialized;

		[Token(Token = "0x4006540")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_GridState;

		[Token(Token = "0x4006541")]
		[FieldOffset(Offset = "0x30")]
		private Mesh m_Mesh;

		[Token(Token = "0x4006542")]
		[FieldOffset(Offset = "0x38")]
		private Matrix4x4 m_Matrix;

		[Token(Token = "0x4006543")]
		[FieldOffset(Offset = "0x78")]
		private Material m_MaterialInstance;

		[Token(Token = "0x4006544")]
		[FieldOffset(Offset = "0x80")]
		private Color m_GridColor;

		[Token(Token = "0x4006545")]
		[FieldOffset(Offset = "0x90")]
		private Color m_FadeColor;

		[Token(Token = "0x6005708")]
		[Address(RVA = "0x14BD04C", Offset = "0x14BD04C", VA = "0x14BD04C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005709")]
		[Address(RVA = "0x14BD22C", Offset = "0x14BD22C", VA = "0x14BD22C", Slot = "5")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x600570A")]
		[Address(RVA = "0x14BD4D8", Offset = "0x14BD4D8", VA = "0x14BD4D8", Slot = "6")]
		public void QueueDraws(bool isScreenshot)
		{
		}

		[Token(Token = "0x600570B")]
		[Address(RVA = "0x14BD44C", Offset = "0x14BD44C", VA = "0x14BD44C")]
		private IEnumerator TransitionGrid(bool state, float transitionTime)
		{
			return null;
		}

		[Token(Token = "0x600570C")]
		[Address(RVA = "0x14BD5DC", Offset = "0x14BD5DC", VA = "0x14BD5DC")]
		private void SetGridColor(bool target, float t)
		{
		}

		[Token(Token = "0x600570D")]
		[Address(RVA = "0x14BD72C", Offset = "0x14BD72C", VA = "0x14BD72C")]
		public GridManager()
		{
		}
	}
}
