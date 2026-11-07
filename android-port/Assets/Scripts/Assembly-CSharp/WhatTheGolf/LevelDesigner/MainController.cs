using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Managers;
using WhatTheGolf.LevelDesigner.Tools;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200124C")]
	public sealed class MainController : MonoBehaviour, IRequireEvents<GUIEvent>, IRequireEvents
	{
		[Token(Token = "0x200124D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x485D4", Offset = "0x485D4")]
		private sealed class _003CStartupProcess_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400629D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400629E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400629F")]
			[FieldOffset(Offset = "0x20")]
			public StateType stateType;

			[Token(Token = "0x17000979")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600544C")]
				[Address(RVA = "0x17F1884", Offset = "0x17F1884", VA = "0x17F1884", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700097A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600544E")]
				[Address(RVA = "0x17F18CC", Offset = "0x17F18CC", VA = "0x17F18CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005449")]
			[Address(RVA = "0x17F16C8", Offset = "0x17F16C8", VA = "0x17F16C8")]
			[DebuggerHidden]
			public _003CStartupProcess_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600544A")]
			[Address(RVA = "0x17F16F4", Offset = "0x17F16F4", VA = "0x17F16F4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600544B")]
			[Address(RVA = "0x17F16F8", Offset = "0x17F16F8", VA = "0x17F16F8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600544C")]
			[Address(RVA = "0x17F1884", Offset = "0x17F1884", VA = "0x17F1884", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600544D")]
			[Address(RVA = "0x17F188C", Offset = "0x17F188C", VA = "0x17F188C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600544E")]
			[Address(RVA = "0x17F18CC", Offset = "0x17F18CC", VA = "0x17F18CC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200124E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x485E4", Offset = "0x485E4")]
		private sealed class _003CWaitForActiveScene_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062A0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062A1")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40062A2")]
			[FieldOffset(Offset = "0x20")]
			private bool _003CisSceneActive_003E5__2;

			[Token(Token = "0x1700097B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005452")]
				[Address(RVA = "0x17F19F0", Offset = "0x17F19F0", VA = "0x17F19F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700097C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005454")]
				[Address(RVA = "0x17F1A38", Offset = "0x17F1A38", VA = "0x17F1A38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600544F")]
			[Address(RVA = "0x17F18D4", Offset = "0x17F18D4", VA = "0x17F18D4")]
			[DebuggerHidden]
			public _003CWaitForActiveScene_003Ed__20(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005450")]
			[Address(RVA = "0x17F1900", Offset = "0x17F1900", VA = "0x17F1900", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005451")]
			[Address(RVA = "0x17F1904", Offset = "0x17F1904", VA = "0x17F1904", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005452")]
			[Address(RVA = "0x17F19F0", Offset = "0x17F19F0", VA = "0x17F19F0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005453")]
			[Address(RVA = "0x17F19F8", Offset = "0x17F19F8", VA = "0x17F19F8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005454")]
			[Address(RVA = "0x17F1A38", Offset = "0x17F1A38", VA = "0x17F1A38", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200124F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x485F4", Offset = "0x485F4")]
		private sealed class _003CCloseProcess_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062A3")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062A4")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x1700097D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005458")]
				[Address(RVA = "0x17F1678", Offset = "0x17F1678", VA = "0x17F1678", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700097E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600545A")]
				[Address(RVA = "0x17F16C0", Offset = "0x17F16C0", VA = "0x17F16C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005455")]
			[Address(RVA = "0x17F1520", Offset = "0x17F1520", VA = "0x17F1520")]
			[DebuggerHidden]
			public _003CCloseProcess_003Ed__22(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005456")]
			[Address(RVA = "0x17F154C", Offset = "0x17F154C", VA = "0x17F154C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005457")]
			[Address(RVA = "0x17F1550", Offset = "0x17F1550", VA = "0x17F1550", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005458")]
			[Address(RVA = "0x17F1678", Offset = "0x17F1678", VA = "0x17F1678", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005459")]
			[Address(RVA = "0x17F1680", Offset = "0x17F1680", VA = "0x17F1680", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600545A")]
			[Address(RVA = "0x17F16C0", Offset = "0x17F16C0", VA = "0x17F16C0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006290")]
		[FieldOffset(Offset = "0x0")]
		private static MainController s_Instance;

		[Token(Token = "0x4006291")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BaseManager[] m_ManagerPrefabs;

		[Token(Token = "0x4006292")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GuiController m_GuiController;

		[Token(Token = "0x4006293")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ElementDatabase m_ElementDatabase;

		[Token(Token = "0x4006294")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LevelData m_DefaultLevelData;

		[Token(Token = "0x4006295")]
		private const string kSceneName = "LevelDesigner";

		[Token(Token = "0x4006296")]
		private const string kEditorKeyword = "_EDITOR";

		[Token(Token = "0x4006297")]
		[FieldOffset(Offset = "0x38")]
		private bool m_Initialized;

		[Token(Token = "0x4006298")]
		[FieldOffset(Offset = "0x40")]
		private List<BaseSystem> m_Systems;

		[Token(Token = "0x4006299")]
		[FieldOffset(Offset = "0x48")]
		private List<BaseManager> m_Managers;

		[Token(Token = "0x400629A")]
		[FieldOffset(Offset = "0x50")]
		private List<BaseTool> m_Tools;

		[Token(Token = "0x400629B")]
		[FieldOffset(Offset = "0x58")]
		private int m_ActiveToolIndex;

		[Token(Token = "0x400629C")]
		[FieldOffset(Offset = "0x5C")]
		private GUIEvent.GUIEventType m_LatestToolEvent;

		[Token(Token = "0x17000977")]
		private static MainController Instance
		{
			[Token(Token = "0x6005436")]
			[Address(RVA = "0x155617C", Offset = "0x155617C", VA = "0x155617C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000978")]
		private BaseTool activeTool
		{
			[Token(Token = "0x6005438")]
			[Address(RVA = "0x15562DC", Offset = "0x15562DC", VA = "0x15562DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005437")]
		[Address(RVA = "0x15561C8", Offset = "0x15561C8", VA = "0x15561C8")]
		public MainController()
		{
		}

		[Token(Token = "0x6005439")]
		[Address(RVA = "0x1556348", Offset = "0x1556348", VA = "0x1556348")]
		private void Awake()
		{
		}

		[Token(Token = "0x600543A")]
		[Address(RVA = "0x15563A0", Offset = "0x15563A0", VA = "0x15563A0")]
		public static void Startup(StateType stateType)
		{
		}

		[Token(Token = "0x600543B")]
		[Address(RVA = "0x15564E8", Offset = "0x15564E8", VA = "0x15564E8")]
		private static IEnumerator StartupProcess(StateType stateType)
		{
			return null;
		}

		[Token(Token = "0x600543C")]
		[Address(RVA = "0x155655C", Offset = "0x155655C", VA = "0x155655C")]
		private static IEnumerator WaitForActiveScene()
		{
			return null;
		}

		[Token(Token = "0x600543D")]
		[Address(RVA = "0x15565B8", Offset = "0x15565B8", VA = "0x15565B8")]
		public static void Close()
		{
		}

		[Token(Token = "0x600543E")]
		[Address(RVA = "0x1556714", Offset = "0x1556714", VA = "0x1556714")]
		private static IEnumerator CloseProcess()
		{
			return null;
		}

		[Token(Token = "0x600543F")]
		[Address(RVA = "0x1556770", Offset = "0x1556770", VA = "0x1556770")]
		private void Init(StateType stateType)
		{
		}

		[Token(Token = "0x6005440")]
		private T CreateSystem<T>() where T : BaseSystem
		{
			return null;
		}

		[Token(Token = "0x6005441")]
		[Address(RVA = "0x1556EB4", Offset = "0x1556EB4", VA = "0x1556EB4")]
		private void CreateManager(BaseManager managerPrefab)
		{
		}

		[Token(Token = "0x6005442")]
		private T CreateTool<T>() where T : BaseTool
		{
			return null;
		}

		[Token(Token = "0x6005443")]
		[Address(RVA = "0x1556FD4", Offset = "0x1556FD4", VA = "0x1556FD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6005444")]
		[Address(RVA = "0x1557214", Offset = "0x1557214", VA = "0x1557214", Slot = "4")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x6005445")]
		[Address(RVA = "0x1557430", Offset = "0x1557430", VA = "0x1557430")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6005446")]
		public T GetManager<T>() where T : BaseManager
		{
			return null;
		}

		[Token(Token = "0x6005447")]
		[Address(RVA = "0x1557218", Offset = "0x1557218", VA = "0x1557218")]
		private void UpdateActiveTool(GUIEvent evt)
		{
		}

		[Token(Token = "0x6005448")]
		private int GetToolIndex<T>() where T : BaseTool
		{
			return default;
		}
	}
}
