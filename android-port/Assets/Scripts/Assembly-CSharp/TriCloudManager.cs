using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CED")]
public class TriCloudManager : MonoBehaviour
{
	[Token(Token = "0x2000CEE")]
	private delegate void DelegateCallback(int requestId, bool success, string error, IntPtr dataPointer, int dataLength);

	[Token(Token = "0x2000CEF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44590", Offset = "0x44590")]
	private sealed class _003CFindCloudKitFilesCR_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400464B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400464C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400464D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string cloudContainerId;

		[Token(Token = "0x400464E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string fileType;

		[Token(Token = "0x400464F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TriCloudManager _003C_003E4__this;

		[Token(Token = "0x4004650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TriCloudQuery query;

		[Token(Token = "0x4004651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _003CrequestId_003E5__2;

		[Token(Token = "0x17000643")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003D36")]
			[Address(RVA = "0x186C43C", Offset = "0x186C43C", VA = "0x186C43C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000644")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003D38")]
			[Address(RVA = "0x186C484", Offset = "0x186C484", VA = "0x186C484", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003D33")]
		[Address(RVA = "0x186C210", Offset = "0x186C210", VA = "0x186C210")]
		[DebuggerHidden]
		public _003CFindCloudKitFilesCR_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003D34")]
		[Address(RVA = "0x186C23C", Offset = "0x186C23C", VA = "0x186C23C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003D35")]
		[Address(RVA = "0x186C240", Offset = "0x186C240", VA = "0x186C240", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003D36")]
		[Address(RVA = "0x186C43C", Offset = "0x186C43C", VA = "0x186C43C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003D37")]
		[Address(RVA = "0x186C444", Offset = "0x186C444", VA = "0x186C444", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003D38")]
		[Address(RVA = "0x186C484", Offset = "0x186C484", VA = "0x186C484", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000CF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x445A0", Offset = "0x445A0")]
	private sealed class _003CFetchUserRecordIDCR_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string cloudContainerId;

		[Token(Token = "0x4004655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TriCloudManager _003C_003E4__this;

		[Token(Token = "0x4004656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<TriCloudQuery> onDone;

		[Token(Token = "0x4004657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _003CrequestId_003E5__2;

		[Token(Token = "0x17000645")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003D3C")]
			[Address(RVA = "0x186C1C0", Offset = "0x186C1C0", VA = "0x186C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000646")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003D3E")]
			[Address(RVA = "0x186C208", Offset = "0x186C208", VA = "0x186C208", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003D39")]
		[Address(RVA = "0x186BF70", Offset = "0x186BF70", VA = "0x186BF70")]
		[DebuggerHidden]
		public _003CFetchUserRecordIDCR_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003D3A")]
		[Address(RVA = "0x186BF9C", Offset = "0x186BF9C", VA = "0x186BF9C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003D3B")]
		[Address(RVA = "0x186BFA0", Offset = "0x186BFA0", VA = "0x186BFA0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003D3C")]
		[Address(RVA = "0x186C1C0", Offset = "0x186C1C0", VA = "0x186C1C0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003D3D")]
		[Address(RVA = "0x186C1C8", Offset = "0x186C1C8", VA = "0x186C1C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x186C208", Offset = "0x186C208", VA = "0x186C208", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TriCloudManager _instance;

	[Token(Token = "0x400464A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<int, TriCloudResult> _results;

	[Token(Token = "0x17000642")]
	public static TriCloudManager instance
	{
		[Token(Token = "0x6003D29")]
		[Address(RVA = "0x172D16C", Offset = "0x172D16C", VA = "0x172D16C")]
		get
		{
			return null;
		}
	}

	[PreserveSig]
	[Token(Token = "0x6003D25")]
	[Address(RVA = "0x172D0C8", Offset = "0x172D0C8", VA = "0x172D0C8")]
	private static extern int TriCloud_GetFileList(string cloudContainerId, string fileType);

	[PreserveSig]
	[Token(Token = "0x6003D26")]
	[Address(RVA = "0x172D124", Offset = "0x172D124", VA = "0x172D124")]
	private static extern int TriCloud_FetchUserRecordID(string cloudContainerId);

	[PreserveSig]
	[Token(Token = "0x6003D27")]
	[Address(RVA = "0x172D158", Offset = "0x172D158", VA = "0x172D158")]
	private static extern void TriCloud_SetDelegate(DelegateCallback callback);

	[Token(Token = "0x6003D28")]
	[Address(RVA = "0x172CF2C", Offset = "0x172CF2C", VA = "0x172CF2C")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6BF00", Offset = "0x6BF00")]
	private static void DelegateMessageReceived(int requestId, bool success, string error, IntPtr dataPointer, int dataLength)
	{
	}

	[Token(Token = "0x6003D2A")]
	[Address(RVA = "0x172D2FC", Offset = "0x172D2FC", VA = "0x172D2FC")]
	private void ReturnResult(int requestId, TriCloudResult result)
	{
	}

	[Token(Token = "0x6003D2B")]
	[Address(RVA = "0x172D384", Offset = "0x172D384", VA = "0x172D384")]
	public IEnumerator FindCloudKitFilesCR(string cloudContainerId, string fileType, TriCloudQuery query)
	{
		return null;
	}

	[Token(Token = "0x6003D2C")]
	[Address(RVA = "0x172D410", Offset = "0x172D410", VA = "0x172D410")]
	public void FetchUserRecordID(string cloudContainerId, Action<TriCloudQuery> onDone)
	{
	}

	[Token(Token = "0x6003D2D")]
	[Address(RVA = "0x172D4A0", Offset = "0x172D4A0", VA = "0x172D4A0")]
	public IEnumerator FetchUserRecordIDCR(string cloudContainerId, Action<TriCloudQuery> onDone)
	{
		return null;
	}

	[Token(Token = "0x6003D2E")]
	[Address(RVA = "0x172D528", Offset = "0x172D528", VA = "0x172D528")]
	public TriCloudManager()
	{
	}
}
