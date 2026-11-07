using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CC5")]
public class iOSOnlineServices : MonoBehaviour
{
	[Token(Token = "0x2000CC6")]
	private enum GCState
	{
		[Token(Token = "0x400457E")]
		None = 0,
		[Token(Token = "0x400457F")]
		WaitingForGameCenter = 1,
		[Token(Token = "0x4004580")]
		SignInAllowed = 2,
		[Token(Token = "0x4004581")]
		NoGameCenter = 3,
		[Token(Token = "0x4004582")]
		HasGameCenter = 4
	}

	[Token(Token = "0x2000CC7")]
	public enum ReloadState
	{
		[Token(Token = "0x4004584")]
		None = 0,
		[Token(Token = "0x4004585")]
		Menu = 1,
		[Token(Token = "0x4004586")]
		Overworld = 2,
		[Token(Token = "0x4004587")]
		All = 3,
		[Token(Token = "0x4004588")]
		NewUser = 4
	}

	[Token(Token = "0x2000CC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44428", Offset = "0x44428")]
	private sealed class _003CReloadWhenInASceneThatAllowsReloadRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400458A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400458B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReloadState shouldReload;

		[Token(Token = "0x400458C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public iOSOnlineServices _003C_003E4__this;

		[Token(Token = "0x400458D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _003CcurrentSceneName_003E5__2;

		[Token(Token = "0x17000630")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003C90")]
			[Address(RVA = "0x1880834", Offset = "0x1880834", VA = "0x1880834", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000631")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C92")]
			[Address(RVA = "0x188087C", Offset = "0x188087C", VA = "0x188087C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x188017C", Offset = "0x188017C", VA = "0x188017C")]
		[DebuggerHidden]
		public _003CReloadWhenInASceneThatAllowsReloadRoutine_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x18801A8", Offset = "0x18801A8", VA = "0x18801A8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x18801AC", Offset = "0x18801AC", VA = "0x18801AC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003C90")]
		[Address(RVA = "0x1880834", Offset = "0x1880834", VA = "0x1880834", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C91")]
		[Address(RVA = "0x188083C", Offset = "0x188083C", VA = "0x188083C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003C92")]
		[Address(RVA = "0x188087C", Offset = "0x188087C", VA = "0x188087C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000CC9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44438", Offset = "0x44438")]
	private sealed class _003CPreloadSaveCR_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400458E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400458F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string filename;

		[Token(Token = "0x4004591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public iOSOnlineServices _003C_003E4__this;

		[Token(Token = "0x4004592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<CloudSave.CloudSaveResult> OnDone;

		[Token(Token = "0x4004593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Task<CloudSave.CloudSaveResult> _003Ctask_003E5__2;

		[Token(Token = "0x17000632")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003C96")]
			[Address(RVA = "0x188012C", Offset = "0x188012C", VA = "0x188012C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000633")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C98")]
			[Address(RVA = "0x1880174", Offset = "0x1880174", VA = "0x1880174", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003C93")]
		[Address(RVA = "0x187FFC0", Offset = "0x187FFC0", VA = "0x187FFC0")]
		[DebuggerHidden]
		public _003CPreloadSaveCR_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003C94")]
		[Address(RVA = "0x187FFEC", Offset = "0x187FFEC", VA = "0x187FFEC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x187FFF0", Offset = "0x187FFF0", VA = "0x187FFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003C96")]
		[Address(RVA = "0x188012C", Offset = "0x188012C", VA = "0x188012C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C97")]
		[Address(RVA = "0x1880134", Offset = "0x1880134", VA = "0x1880134", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003C98")]
		[Address(RVA = "0x1880174", Offset = "0x1880174", VA = "0x1880174", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000CCA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44448", Offset = "0x44448")]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		[Token(Token = "0x4004594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<SaveFileInfo> cloudSaves;

		[Token(Token = "0x4004595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool cloudRequestFinished;

		[Token(Token = "0x6003C99")]
		[Address(RVA = "0x187DFA8", Offset = "0x187DFA8", VA = "0x187DFA8")]
		public _003C_003Ec__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6003C9A")]
		[Address(RVA = "0x187DFB0", Offset = "0x187DFB0", VA = "0x187DFB0")]
		internal void _003CMegaMergeAllSaveFilesCR_003Eb__0(List<SaveFileInfo> list)
		{
		}

		[Token(Token = "0x6003C9B")]
		[Address(RVA = "0x187DFC0", Offset = "0x187DFC0", VA = "0x187DFC0")]
		internal void _003CMegaMergeAllSaveFilesCR_003Eb__1(List<SaveFileInfo> list)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000CCB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44458", Offset = "0x44458")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<SaveFileInfo, bool> _003C_003E9__34_2;

		[Token(Token = "0x4004598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<SaveFileInfo, long> _003C_003E9__34_3;

		[Token(Token = "0x4004599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action<bool> _003C_003E9__41_0;

		[Token(Token = "0x6003C9D")]
		[Address(RVA = "0x187DE54", Offset = "0x187DE54", VA = "0x187DE54")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003C9E")]
		[Address(RVA = "0x187DE5C", Offset = "0x187DE5C", VA = "0x187DE5C")]
		internal bool _003CMegaMergeAllSaveFilesCR_003Eb__34_2(SaveFileInfo s)
		{
			return default;
		}

		[Token(Token = "0x6003C9F")]
		[Address(RVA = "0x187DEC0", Offset = "0x187DEC0", VA = "0x187DEC0")]
		internal long _003CMegaMergeAllSaveFilesCR_003Eb__34_3(SaveFileInfo s)
		{
			return default;
		}

		[Token(Token = "0x6003CA0")]
		[Address(RVA = "0x187DED8", Offset = "0x187DED8", VA = "0x187DED8")]
		internal void _003CInitializeRoutine_003Eb__41_0(bool success)
		{
		}
	}

	[Token(Token = "0x2000CCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44468", Offset = "0x44468")]
	private sealed class _003CMegaMergeAllSaveFilesCR_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400459A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400459B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400459C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iOSOnlineServices _003C_003E4__this;

		[Token(Token = "0x400459D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

		[Token(Token = "0x400459E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SaveGame.SaveData _003CmergedLocal_003E5__2;

		[Token(Token = "0x400459F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _003CmergeNeeded_003E5__3;

		[Token(Token = "0x40045A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _003CanyDownloadFailed_003E5__4;

		[Token(Token = "0x40045A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long _003ClatestCloudTimestamp_003E5__5;

		[Token(Token = "0x40045A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<SaveFileInfo>.Enumerator _003C_003E7__wrap5;

		[Token(Token = "0x40045A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SaveFileInfo _003CcloudSaveInfo_003E5__7;

		[Token(Token = "0x40045A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Task<CloudSave.CloudSaveResult> _003CsaveDownload_003E5__8;

		[Token(Token = "0x17000634")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003CA5")]
			[Address(RVA = "0x187FF70", Offset = "0x187FF70", VA = "0x187FF70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000635")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003CA7")]
			[Address(RVA = "0x187FFB8", Offset = "0x187FFB8", VA = "0x187FFB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003CA1")]
		[Address(RVA = "0x187ED14", Offset = "0x187ED14", VA = "0x187ED14")]
		[DebuggerHidden]
		public _003CMegaMergeAllSaveFilesCR_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003CA2")]
		[Address(RVA = "0x187ED40", Offset = "0x187ED40", VA = "0x187ED40", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003CA3")]
		[Address(RVA = "0x187EE14", Offset = "0x187EE14", VA = "0x187EE14", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003CA4")]
		[Address(RVA = "0x187EDB8", Offset = "0x187EDB8", VA = "0x187EDB8")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6003CA5")]
		[Address(RVA = "0x187FF70", Offset = "0x187FF70", VA = "0x187FF70", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0x187FF78", Offset = "0x187FF78", VA = "0x187FF78", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x187FFB8", Offset = "0x187FFB8", VA = "0x187FFB8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000CCD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44478", Offset = "0x44478")]
	private sealed class _003CSynchronizeSavesCR_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40045A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40045A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40045A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iOSOnlineServices _003C_003E4__this;

		[Token(Token = "0x40045A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<ReloadState> onDone;

		[Token(Token = "0x40045A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CloudSave.CloudSaveResult cachedCloudResult;

		[Token(Token = "0x40045AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _003Cfilename_003E5__2;

		[Token(Token = "0x40045AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ReloadState _003CreloadState_003E5__3;

		[Token(Token = "0x40045AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool _003CcanOverwriteCloud_003E5__4;

		[Token(Token = "0x40045AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool _003CiCloudExists_003E5__5;

		[Token(Token = "0x40045AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Task<CloudSave.CloudSaveResult> _003Ctask_003E5__6;

		[Token(Token = "0x40045AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Task<CloudSave.SaveReconciliationResult> _003CmergeTask_003E5__7;

		[Token(Token = "0x17000636")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003CAB")]
			[Address(RVA = "0x1881794", Offset = "0x1881794", VA = "0x1881794", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000637")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003CAD")]
			[Address(RVA = "0x18817DC", Offset = "0x18817DC", VA = "0x18817DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0x1880FA8", Offset = "0x1880FA8", VA = "0x1880FA8")]
		[DebuggerHidden]
		public _003CSynchronizeSavesCR_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x1880FD4", Offset = "0x1880FD4", VA = "0x1880FD4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x1880FD8", Offset = "0x1880FD8", VA = "0x1880FD8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x1881794", Offset = "0x1881794", VA = "0x1881794", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x188179C", Offset = "0x188179C", VA = "0x188179C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003CAD")]
		[Address(RVA = "0x18817DC", Offset = "0x18817DC", VA = "0x18817DC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000CCE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44488", Offset = "0x44488")]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x40045B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<bool> onDone;

		[Token(Token = "0x6003CAE")]
		[Address(RVA = "0x187DFCC", Offset = "0x187DFCC", VA = "0x187DFCC")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6003CAF")]
		[Address(RVA = "0x187DFD4", Offset = "0x187DFD4", VA = "0x187DFD4")]
		internal void _003CDetermineGCUserAsync_003Eb__0(bool success)
		{
		}
	}

	[Token(Token = "0x2000CCF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44498", Offset = "0x44498")]
	private sealed class _003CDetermineGCUserAsync_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40045B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40045B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40045B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<bool> onDone;

		[Token(Token = "0x40045B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public iOSOnlineServices _003C_003E4__this;

		[Token(Token = "0x40045B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		[Token(Token = "0x17000638")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003CB3")]
			[Address(RVA = "0x187E3BC", Offset = "0x187E3BC", VA = "0x187E3BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000639")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003CB5")]
			[Address(RVA = "0x187E404", Offset = "0x187E404", VA = "0x187E404", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003CB0")]
		[Address(RVA = "0x187E1F0", Offset = "0x187E1F0", VA = "0x187E1F0")]
		[DebuggerHidden]
		public _003CDetermineGCUserAsync_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003CB1")]
		[Address(RVA = "0x187E21C", Offset = "0x187E21C", VA = "0x187E21C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003CB2")]
		[Address(RVA = "0x187E220", Offset = "0x187E220", VA = "0x187E220", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003CB3")]
		[Address(RVA = "0x187E3BC", Offset = "0x187E3BC", VA = "0x187E3BC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003CB4")]
		[Address(RVA = "0x187E3C4", Offset = "0x187E3C4", VA = "0x187E3C4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003CB5")]
		[Address(RVA = "0x187E404", Offset = "0x187E404", VA = "0x187E404", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000CD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x444A8", Offset = "0x444A8")]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		[Token(Token = "0x40045B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool hasPreloadedICloud;

		[Token(Token = "0x40045B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CloudSave.CloudSaveResult cloudSaveResult;

		[Token(Token = "0x6003CB6")]
		[Address(RVA = "0x187E0D0", Offset = "0x187E0D0", VA = "0x187E0D0")]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6003CB7")]
		[Address(RVA = "0x187E0D8", Offset = "0x187E0D8", VA = "0x187E0D8")]
		internal void _003CInitializeRoutine_003Eb__1(CloudSave.CloudSaveResult result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CD1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x444B8", Offset = "0x444B8")]
	private struct _003CInitializeRoutine_003Ed__41 : IAsyncStateMachine
	{
		[Token(Token = "0x40045B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40045B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40045BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public iOSOnlineServices _003C_003E4__this;

		[Token(Token = "0x40045BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action OnSaveFilenameDetermined;

		[Token(Token = "0x40045BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		[Token(Token = "0x40045BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action OnReady;

		[Token(Token = "0x40045BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003CB8")]
		[Address(RVA = "0x187E58C", Offset = "0x187E58C", VA = "0x187E58C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003CB9")]
		[Address(RVA = "0x187ED08", Offset = "0x187ED08", VA = "0x187ED08", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000CD2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x444C8", Offset = "0x444C8")]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		[Token(Token = "0x40045BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isGameCenterUserDetermined;

		[Token(Token = "0x6003CBA")]
		[Address(RVA = "0x187E1DC", Offset = "0x187E1DC", VA = "0x187E1DC")]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6003CBB")]
		[Address(RVA = "0x187E1E4", Offset = "0x187E1E4", VA = "0x187E1E4")]
		internal void _003CSynchronizeGCUserAndSavesCR_003Eb__0(bool success)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CD3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x444D8", Offset = "0x444D8")]
	private struct _003CSynchronizeGCUserAndSavesCR_003Ed__46 : IAsyncStateMachine
	{
		[Token(Token = "0x40045C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40045C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40045C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public iOSOnlineServices _003C_003E4__this;

		[Token(Token = "0x40045C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool gameCenterOnly;

		[Token(Token = "0x40045C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass46_0 _003C_003E8__1;

		[Token(Token = "0x40045C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x1880A38", Offset = "0x1880A38", VA = "0x1880A38", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003CBD")]
		[Address(RVA = "0x1880F9C", Offset = "0x1880F9C", VA = "0x1880F9C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000CD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x444E8", Offset = "0x444E8")]
	private sealed class _003CRestartApp_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40045C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40045C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40045C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iOSOnlineServices _003C_003E4__this;

		[Token(Token = "0x1700063A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003CC1")]
			[Address(RVA = "0x18809E8", Offset = "0x18809E8", VA = "0x18809E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700063B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003CC3")]
			[Address(RVA = "0x1880A30", Offset = "0x1880A30", VA = "0x1880A30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003CBE")]
		[Address(RVA = "0x1880884", Offset = "0x1880884", VA = "0x1880884")]
		[DebuggerHidden]
		public _003CRestartApp_003Ed__48(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003CBF")]
		[Address(RVA = "0x18808B0", Offset = "0x18808B0", VA = "0x18808B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003CC0")]
		[Address(RVA = "0x18808B4", Offset = "0x18808B4", VA = "0x18808B4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003CC1")]
		[Address(RVA = "0x18809E8", Offset = "0x18809E8", VA = "0x18809E8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x18809F0", Offset = "0x18809F0", VA = "0x18809F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x1880A30", Offset = "0x1880A30", VA = "0x1880A30", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000CD5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x444F8", Offset = "0x444F8")]
	private sealed class _003CDisplayGameCenterUnavailableDialog_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40045C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40045CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40045CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iOSOnlineServices _003C_003E4__this;

		[Token(Token = "0x1700063C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003CC7")]
			[Address(RVA = "0x187E53C", Offset = "0x187E53C", VA = "0x187E53C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700063D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003CC9")]
			[Address(RVA = "0x187E584", Offset = "0x187E584", VA = "0x187E584", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0x187E40C", Offset = "0x187E40C", VA = "0x187E40C")]
		[DebuggerHidden]
		public _003CDisplayGameCenterUnavailableDialog_003Ed__49(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x187E438", Offset = "0x187E438", VA = "0x187E438", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003CC6")]
		[Address(RVA = "0x187E43C", Offset = "0x187E43C", VA = "0x187E43C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003CC7")]
		[Address(RVA = "0x187E53C", Offset = "0x187E53C", VA = "0x187E53C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003CC8")]
		[Address(RVA = "0x187E544", Offset = "0x187E544", VA = "0x187E544", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003CC9")]
		[Address(RVA = "0x187E584", Offset = "0x187E584", VA = "0x187E584", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static iOSOnlineServices k_Instance;

	[Token(Token = "0x4004572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x513BC", Offset = "0x513BC")]
	private static bool IsReady__BackingField;

	[Token(Token = "0x4004573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private DialogBase m_ICloudUnavailableAlert;

	[Token(Token = "0x4004574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DialogBase m_GameCenterUnavailableAlert;

	[Token(Token = "0x4004575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ReconciliationDialog m_ReconciliationDialog;

	[Token(Token = "0x4004576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject statusText;

	[Token(Token = "0x4004577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5140C", Offset = "0x5140C")]
	private Action<ReloadState> m_OnShouldReload;

	[Token(Token = "0x4004578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Coroutine reloadWhenInASceneThatAllowsReloadCoroutine;

	[Token(Token = "0x4004579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GCState _gcState;

	[Token(Token = "0x400457A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private ReloadState LastReloadState;

	[Token(Token = "0x400457B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isWaitingForIcloud;

	[Token(Token = "0x400457C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool m_ResumeRoutine;

	[Token(Token = "0x1700062D")]
	public static iOSOnlineServices Instance
	{
		[Token(Token = "0x6003C6A")]
		[Address(RVA = "0x1764164", Offset = "0x1764164", VA = "0x1764164")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700062E")]
	public static bool IsReady
	{
		[Token(Token = "0x6003C6B")]
		[Address(RVA = "0x176429C", Offset = "0x176429C", VA = "0x176429C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BB68", Offset = "0x6BB68")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003C6C")]
		[Address(RVA = "0x1764300", Offset = "0x1764300", VA = "0x1764300")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BB78", Offset = "0x6BB78")]
		set
		{
		}
	}

	[Token(Token = "0x1700062F")]
	private GCState GameCenterState
	{
		[Token(Token = "0x6003C6F")]
		[Address(RVA = "0x17644B8", Offset = "0x17644B8", VA = "0x17644B8")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003C70")]
		[Address(RVA = "0x17644C0", Offset = "0x17644C0", VA = "0x17644C0")]
		set
		{
		}
	}

	[Token(Token = "0x14000076")]
	public event Action<ReloadState> OnShouldReload
	{
		[Token(Token = "0x6003C6D")]
		[Address(RVA = "0x1764370", Offset = "0x1764370", VA = "0x1764370")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BB88", Offset = "0x6BB88")]
		add
		{
		}
		[Token(Token = "0x6003C6E")]
		[Address(RVA = "0x1764414", Offset = "0x1764414", VA = "0x1764414")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6BB98", Offset = "0x6BB98")]
		remove
		{
		}
	}

	[Token(Token = "0x6003C71")]
	[Address(RVA = "0x176459C", Offset = "0x176459C", VA = "0x176459C")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6BBA8", Offset = "0x6BBA8")]
	private static void Init()
	{
	}

	[Token(Token = "0x6003C72")]
	[Address(RVA = "0x176463C", Offset = "0x176463C", VA = "0x176463C")]
	public void SetupCallbacks()
	{
	}

	[Token(Token = "0x6003C73")]
	[Address(RVA = "0x176486C", Offset = "0x176486C", VA = "0x176486C")]
	private void OnSaveDoICloud(SaveGame.SaveSlot slot)
	{
	}

	[Token(Token = "0x6003C74")]
	[Address(RVA = "0x1764758", Offset = "0x1764758", VA = "0x1764758")]
	private void UnsetCallbacks()
	{
	}

	[Token(Token = "0x6003C75")]
	[Address(RVA = "0x1764980", Offset = "0x1764980", VA = "0x1764980")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003C76")]
	[Address(RVA = "0x1764984", Offset = "0x1764984", VA = "0x1764984")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003C77")]
	[Address(RVA = "0x1764BA4", Offset = "0x1764BA4", VA = "0x1764BA4")]
	private IEnumerator ReloadWhenInASceneThatAllowsReloadRoutine(ReloadState shouldReload)
	{
		return null;
	}

	[Token(Token = "0x6003C78")]
	[Address(RVA = "0x1764C20", Offset = "0x1764C20", VA = "0x1764C20")]
	public void IOSOnlineServices_OnShouldReload(ReloadState shouldReload)
	{
	}

	[Token(Token = "0x6003C79")]
	[Address(RVA = "0x1764CDC", Offset = "0x1764CDC", VA = "0x1764CDC")]
	public IEnumerator PreloadSaveCR(string filename, Action<CloudSave.CloudSaveResult> OnDone)
	{
		return null;
	}

	[Token(Token = "0x6003C7A")]
	[Address(RVA = "0x1764D64", Offset = "0x1764D64", VA = "0x1764D64")]
	private void OnLoadedSaveCacheSaveGame(SaveGame.SaveSlot slot)
	{
	}

	[Token(Token = "0x6003C7B")]
	[Address(RVA = "0x1764D88", Offset = "0x1764D88", VA = "0x1764D88")]
	public void SetReadyForGameCenterLogin()
	{
	}

	[Token(Token = "0x6003C7C")]
	[Address(RVA = "0x1764D90", Offset = "0x1764D90", VA = "0x1764D90")]
	private SaveGame.SaveData MergeSaves(SaveGame.SaveData a, SaveGame.SaveData b)
	{
		return null;
	}

	[Token(Token = "0x6003C7D")]
	[Address(RVA = "0x1764E3C", Offset = "0x1764E3C", VA = "0x1764E3C")]
	public IEnumerator MegaMergeAllSaveFilesCR()
	{
		return null;
	}

	[Token(Token = "0x6003C7E")]
	[Address(RVA = "0x1764EB0", Offset = "0x1764EB0", VA = "0x1764EB0")]
	public void Initialize(Action OnReady, Action OnSaveFilenameDetermined)
	{
	}

	[Token(Token = "0x6003C7F")]
	[Address(RVA = "0x1764874", Offset = "0x1764874", VA = "0x1764874")]
	private void SynchronizeSaves(bool force = false)
	{
	}

	[Token(Token = "0x6003C80")]
	[Address(RVA = "0x176513C", Offset = "0x176513C", VA = "0x176513C")]
	private IEnumerator SynchronizeSavesCR(CloudSave.CloudSaveResult cachedCloudResult, Action<ReloadState> onDone)
	{
		return null;
	}

	[Token(Token = "0x6003C81")]
	[Address(RVA = "0x17651C4", Offset = "0x17651C4", VA = "0x17651C4")]
	public void TriggerReload(ReloadState reloadState)
	{
	}

	[Token(Token = "0x6003C82")]
	[Address(RVA = "0x1765234", Offset = "0x1765234", VA = "0x1765234")]
	private IEnumerator DetermineGCUserAsync(Action<bool> onDone)
	{
		return null;
	}

	[Token(Token = "0x6003C83")]
	[Address(RVA = "0x176508C", Offset = "0x176508C", VA = "0x176508C")]
	private void InitializeRoutine(Action OnReady, Action OnSaveFilenameDetermined)
	{
	}

	[Token(Token = "0x6003C84")]
	[Address(RVA = "0x17652AC", Offset = "0x17652AC", VA = "0x17652AC")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6003C85")]
	[Address(RVA = "0x1765440", Offset = "0x1765440", VA = "0x1765440")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x6003C86")]
	[Address(RVA = "0x17652BC", Offset = "0x17652BC", VA = "0x17652BC")]
	private void TrySynchronizeOnStateChange(bool gameCenterOnly = false)
	{
	}

	[Token(Token = "0x6003C87")]
	[Address(RVA = "0x1765450", Offset = "0x1765450", VA = "0x1765450")]
	private void SynchronizeGCUserAndSavesCR(bool gameCenterOnly = false)
	{
	}

	[Token(Token = "0x6003C88")]
	[Address(RVA = "0x17654F4", Offset = "0x17654F4", VA = "0x17654F4")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6003C89")]
	[Address(RVA = "0x17654FC", Offset = "0x17654FC", VA = "0x17654FC")]
	private IEnumerator RestartApp()
	{
		return null;
	}

	[Token(Token = "0x6003C8A")]
	[Address(RVA = "0x1765570", Offset = "0x1765570", VA = "0x1765570")]
	public IEnumerator DisplayGameCenterUnavailableDialog()
	{
		return null;
	}

	[Token(Token = "0x6003C8B")]
	[Address(RVA = "0x17655E4", Offset = "0x17655E4", VA = "0x17655E4")]
	public iOSOnlineServices()
	{
	}
}
