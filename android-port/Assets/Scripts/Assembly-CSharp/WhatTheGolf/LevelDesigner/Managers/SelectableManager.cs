using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Selectables;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Token(Token = "0x20012CC")]
	public sealed class SelectableManager : BaseManager, IRequireSerialization, IRequireEvents<GameStateEvent>, IRequireEvents, IRequireEvents<PlayEvent>
	{
		[Token(Token = "0x20012CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x489A8", Offset = "0x489A8")]
		private sealed class _003CResetLevel_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400655A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400655B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SelectableManager _003C_003E4__this;

			[Token(Token = "0x170009FA")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005738")]
				[Address(RVA = "0x1841E14", Offset = "0x1841E14", VA = "0x1841E14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009FB")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600573A")]
				[Address(RVA = "0x1841E5C", Offset = "0x1841E5C", VA = "0x1841E5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005735")]
			[Address(RVA = "0x1841C3C", Offset = "0x1841C3C", VA = "0x1841C3C")]
			[DebuggerHidden]
			public _003CResetLevel_003Ed__32(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005736")]
			[Address(RVA = "0x1841C68", Offset = "0x1841C68", VA = "0x1841C68", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005737")]
			[Address(RVA = "0x1841C6C", Offset = "0x1841C6C", VA = "0x1841C6C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005738")]
			[Address(RVA = "0x1841E14", Offset = "0x1841E14", VA = "0x1841E14", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005739")]
			[Address(RVA = "0x1841E1C", Offset = "0x1841E1C", VA = "0x1841E1C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600573A")]
			[Address(RVA = "0x1841E5C", Offset = "0x1841E5C", VA = "0x1841E5C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20012CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x489B8", Offset = "0x489B8")]
		private sealed class _003CWaitThen_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400655C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400655D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400655E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float wait;

			[Token(Token = "0x400655F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action action;

			[Token(Token = "0x4006560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _003Cend_003E5__2;

			[Token(Token = "0x170009FC")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600573E")]
				[Address(RVA = "0x1842058", Offset = "0x1842058", VA = "0x1842058", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009FD")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005740")]
				[Address(RVA = "0x18420A0", Offset = "0x18420A0", VA = "0x18420A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600573B")]
			[Address(RVA = "0x1841F9C", Offset = "0x1841F9C", VA = "0x1841F9C")]
			[DebuggerHidden]
			public _003CWaitThen_003Ed__33(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600573C")]
			[Address(RVA = "0x1841FC8", Offset = "0x1841FC8", VA = "0x1841FC8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600573D")]
			[Address(RVA = "0x1841FCC", Offset = "0x1841FCC", VA = "0x1841FCC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600573E")]
			[Address(RVA = "0x1842058", Offset = "0x1842058", VA = "0x1842058", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600573F")]
			[Address(RVA = "0x1842060", Offset = "0x1842060", VA = "0x1842060", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005740")]
			[Address(RVA = "0x18420A0", Offset = "0x18420A0", VA = "0x18420A0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20012CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x489C8", Offset = "0x489C8")]
		private sealed class _003C_003Ec__DisplayClass42_0
		{
			[Token(Token = "0x4006561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SelectableManager _003C_003E4__this;

			[Token(Token = "0x4006562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int newElementId;

			[Token(Token = "0x4006563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 selectablePosition;

			[Token(Token = "0x4006564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion selectableRotation;

			[Token(Token = "0x6005741")]
			[Address(RVA = "0x1841978", Offset = "0x1841978", VA = "0x1841978")]
			public _003C_003Ec__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6005742")]
			[Address(RVA = "0x1841980", Offset = "0x1841980", VA = "0x1841980")]
			internal void _003CReplaceSelectable_003Eb__0()
			{
			}
		}

		[Token(Token = "0x20012D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x489D8", Offset = "0x489D8")]
		private sealed class _003C_003Ec__DisplayClass43_0
		{
			[Token(Token = "0x4006565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SelectableManager _003C_003E4__this;

			[Token(Token = "0x4006566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Selectable selectable;

			[Token(Token = "0x4006567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action onComplete;

			[Token(Token = "0x6005743")]
			[Address(RVA = "0x18419D4", Offset = "0x18419D4", VA = "0x18419D4")]
			public _003C_003Ec__DisplayClass43_0()
			{
			}

			[Token(Token = "0x6005744")]
			[Address(RVA = "0x18419DC", Offset = "0x18419DC", VA = "0x18419DC")]
			internal void _003CDeleteSelectable_003Eb__0()
			{
			}
		}

		[Token(Token = "0x20012D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x489E8", Offset = "0x489E8")]
		private sealed class _003CWaitForReturn_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400656A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject obj;

			[Token(Token = "0x170009FE")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005748")]
				[Address(RVA = "0x1841F4C", Offset = "0x1841F4C", VA = "0x1841F4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009FF")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600574A")]
				[Address(RVA = "0x1841F94", Offset = "0x1841F94", VA = "0x1841F94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005745")]
			[Address(RVA = "0x1841E64", Offset = "0x1841E64", VA = "0x1841E64")]
			[DebuggerHidden]
			public _003CWaitForReturn_003Ed__44(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005746")]
			[Address(RVA = "0x1841E90", Offset = "0x1841E90", VA = "0x1841E90", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005747")]
			[Address(RVA = "0x1841E94", Offset = "0x1841E94", VA = "0x1841E94", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005748")]
			[Address(RVA = "0x1841F4C", Offset = "0x1841F4C", VA = "0x1841F4C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005749")]
			[Address(RVA = "0x1841F54", Offset = "0x1841F54", VA = "0x1841F54", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600574A")]
			[Address(RVA = "0x1841F94", Offset = "0x1841F94", VA = "0x1841F94", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20012D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x489F8", Offset = "0x489F8")]
		private sealed class _003C_003Ec__DisplayClass46_0
		{
			[Token(Token = "0x400656B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SelectableDefinition selectableDefinition;

			[Token(Token = "0x600574B")]
			[Address(RVA = "0x1841B98", Offset = "0x1841B98", VA = "0x1841B98")]
			public _003C_003Ec__DisplayClass46_0()
			{
			}

			[Token(Token = "0x600574C")]
			[Address(RVA = "0x1841BA0", Offset = "0x1841BA0", VA = "0x1841BA0")]
			internal bool _003CDeleteSelection_003Eb__0(Selectable s)
			{
				return default;
			}
		}

		[Token(Token = "0x400654D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraManager m_CameraManager;

		[Token(Token = "0x400654E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GizmoManager m_GizmoManager;

		[Token(Token = "0x400654F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_DeleteParticles;

		[Token(Token = "0x4006550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Initialized;

		[Token(Token = "0x4006551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WhatTheGolf.LevelDesigner.Selectables.Ball m_Ball;

		[Token(Token = "0x4006552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Goal m_Goal;

		[Token(Token = "0x4006553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Selectable> m_Selectables;

		[Token(Token = "0x4006554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Selectable m_CurrentSelection;

		[Token(Token = "0x4006555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Selectable, (Vector3, Quaternion, CollisionDetectionMode, bool, RigidbodyInterpolation)> m_SelectableStates;

		[Token(Token = "0x4006556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Color32 m_GizmoColor;

		[Token(Token = "0x4006557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool isResetting;

		[Token(Token = "0x4006558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float transitionDuration;

		[Token(Token = "0x170009F4")]
		public CameraManager cameraManager
		{
			[Token(Token = "0x6005715")]
			[Address(RVA = "0x1685FBC", Offset = "0x1685FBC", VA = "0x1685FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F5")]
		public GizmoManager gizmoManager
		{
			[Token(Token = "0x6005716")]
			[Address(RVA = "0x1686070", Offset = "0x1686070", VA = "0x1686070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F6")]
		public WhatTheGolf.LevelDesigner.Selectables.Ball ball
		{
			[Token(Token = "0x6005717")]
			[Address(RVA = "0x1686124", Offset = "0x1686124", VA = "0x1686124")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F7")]
		public Goal goal
		{
			[Token(Token = "0x6005718")]
			[Address(RVA = "0x168612C", Offset = "0x168612C", VA = "0x168612C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F8")]
		public Selectable currentSelection
		{
			[Token(Token = "0x6005719")]
			[Address(RVA = "0x1686134", Offset = "0x1686134", VA = "0x1686134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009F9")]
		public List<Selectable> selectables
		{
			[Token(Token = "0x600571A")]
			[Address(RVA = "0x168613C", Offset = "0x168613C", VA = "0x168613C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600571B")]
		[Address(RVA = "0x1686144", Offset = "0x1686144", VA = "0x1686144", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x600571C")]
		[Address(RVA = "0x1686220", Offset = "0x1686220", VA = "0x1686220")]
		private void Update()
		{
		}

		[Token(Token = "0x600571D")]
		[Address(RVA = "0x1686364", Offset = "0x1686364", VA = "0x1686364", Slot = "7")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x600571E")]
		[Address(RVA = "0x1686E54", Offset = "0x1686E54", VA = "0x1686E54", Slot = "8")]
		public void OnEvent(PlayEvent evt)
		{
		}

		[Token(Token = "0x600571F")]
		[Address(RVA = "0x168735C", Offset = "0x168735C", VA = "0x168735C", Slot = "5")]
		public void Load(LevelContentData levelData)
		{
		}

		[Token(Token = "0x6005720")]
		[Address(RVA = "0x1687AF8", Offset = "0x1687AF8", VA = "0x1687AF8", Slot = "6")]
		public void Save(LevelContentData levelData)
		{
		}

		[Token(Token = "0x6005721")]
		[Address(RVA = "0x1687F50", Offset = "0x1687F50", VA = "0x1687F50")]
		private void StoreSelectableState(Selectable selectable)
		{
		}

		[Token(Token = "0x6005722")]
		[Address(RVA = "0x16880E8", Offset = "0x16880E8", VA = "0x16880E8")]
		public void HandleOutOfBounds(string message)
		{
		}

		[Token(Token = "0x6005723")]
		[Address(RVA = "0x168817C", Offset = "0x168817C", VA = "0x168817C")]
		private IEnumerator ResetLevel()
		{
			return null;
		}

		[Token(Token = "0x6005724")]
		[Address(RVA = "0x16881F0", Offset = "0x16881F0", VA = "0x16881F0")]
		private IEnumerator WaitThen(float wait, Action action)
		{
			return null;
		}

		[Token(Token = "0x6005725")]
		[Address(RVA = "0x1688274", Offset = "0x1688274", VA = "0x1688274")]
		public void OnHitFlag(string message)
		{
		}

		[Token(Token = "0x6005726")]
		[Address(RVA = "0x1688378", Offset = "0x1688378", VA = "0x1688378")]
		public void HandleOutOfBounds()
		{
		}

		[Token(Token = "0x6005727")]
		[Address(RVA = "0x1684E6C", Offset = "0x1684E6C", VA = "0x1684E6C")]
		public void SetBall(int ballID)
		{
		}

		[Token(Token = "0x6005728")]
		[Address(RVA = "0x168840C", Offset = "0x168840C", VA = "0x168840C")]
		public void SetBall(BallDefinition ballDefinition)
		{
		}

		[Token(Token = "0x6005729")]
		[Address(RVA = "0x168848C", Offset = "0x168848C", VA = "0x168848C")]
		public Selectable CreateSelectable(int elementId, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x600572A")]
		[Address(RVA = "0x1687798", Offset = "0x1687798", VA = "0x1687798")]
		public Selectable CreateSelectable(SelectableDefinition selectableDefinition, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x600572B")]
		[Address(RVA = "0x1688674", Offset = "0x1688674", VA = "0x1688674")]
		private Selectable CreateSelectable(SelectableDefinition selectableDefinition, Vector3 position, Quaternion rotation, Guid guid)
		{
			return null;
		}

		[Token(Token = "0x600572C")]
		[Address(RVA = "0x1685038", Offset = "0x1685038", VA = "0x1685038")]
		public void ReplaceSelectedSelectable(int newElementId)
		{
		}

		[Token(Token = "0x600572D")]
		[Address(RVA = "0x1688CD8", Offset = "0x1688CD8", VA = "0x1688CD8")]
		public void ReplaceSelectable(int newElementId, Selectable selectable)
		{
		}

		[Token(Token = "0x600572E")]
		[Address(RVA = "0x1688DF4", Offset = "0x1688DF4", VA = "0x1688DF4")]
		public void DeleteSelectable(Selectable selectable, [Optional] Action onComplete)
		{
		}

		[Token(Token = "0x600572F")]
		[Address(RVA = "0x1688F50", Offset = "0x1688F50", VA = "0x1688F50")]
		private IEnumerator WaitForReturn(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x6005730")]
		[Address(RVA = "0x1683E74", Offset = "0x1683E74", VA = "0x1683E74")]
		public void SetSelection(Selectable selectable)
		{
		}

		[Token(Token = "0x6005731")]
		[Address(RVA = "0x1684704", Offset = "0x1684704", VA = "0x1684704")]
		public void DeleteSelection()
		{
		}

		[Token(Token = "0x6005732")]
		[Address(RVA = "0x1688FC4", Offset = "0x1688FC4", VA = "0x1688FC4")]
		public bool IsWithinRadiusOfSelectable(Vector3 position, float radius)
		{
			return default;
		}

		[Token(Token = "0x6005733")]
		[Address(RVA = "0x16891C8", Offset = "0x16891C8", VA = "0x16891C8")]
		public SelectableManager()
		{
		}

		[Token(Token = "0x6005734")]
		[Address(RVA = "0x168922C", Offset = "0x168922C", VA = "0x168922C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71C24", Offset = "0x71C24")]
		private void _003COnHitFlag_003Eb__34_0()
		{
		}
	}
}
