using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20008BD")]
public class ReconciliationDialog : DialogBase
{
	[Token(Token = "0x20008BE")]
	public enum Choice
	{
		[Token(Token = "0x4002FF6")]
		None = 0,
		[Token(Token = "0x4002FF7")]
		Local = 1,
		[Token(Token = "0x4002FF8")]
		Cloud = 2
	}

	[Token(Token = "0x20008BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41C00", Offset = "0x41C00")]
	private sealed class _003CWaitForSaveSelection_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002FF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002FFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002FFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReconciliationDialog _003C_003E4__this;

		[Token(Token = "0x17000442")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600285C")]
			[Address(RVA = "0x1831638", Offset = "0x1831638", VA = "0x1831638", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000443")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600285E")]
			[Address(RVA = "0x1831680", Offset = "0x1831680", VA = "0x1831680", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002859")]
		[Address(RVA = "0x18315A8", Offset = "0x18315A8", VA = "0x18315A8")]
		[DebuggerHidden]
		public _003CWaitForSaveSelection_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600285A")]
		[Address(RVA = "0x18315D4", Offset = "0x18315D4", VA = "0x18315D4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600285B")]
		[Address(RVA = "0x18315D8", Offset = "0x18315D8", VA = "0x18315D8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600285C")]
		[Address(RVA = "0x1831638", Offset = "0x1831638", VA = "0x1831638", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600285D")]
		[Address(RVA = "0x1831640", Offset = "0x1831640", VA = "0x1831640", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600285E")]
		[Address(RVA = "0x1831680", Offset = "0x1831680", VA = "0x1831680", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20008C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41C10", Offset = "0x41C10")]
	private struct _003CWaitForSaveSelection_Task_003Ed__16 : IAsyncStateMachine
	{
		[Token(Token = "0x4002FFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4002FFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<Choice> _003C_003Et__builder;

		[Token(Token = "0x4002FFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReconciliationDialog _003C_003E4__this;

		[Token(Token = "0x4002FFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x600285F")]
		[Address(RVA = "0x1831688", Offset = "0x1831688", VA = "0x1831688", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002860")]
		[Address(RVA = "0x1831890", Offset = "0x1831890", VA = "0x1831890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4002FE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text m_UsedName;

	[Token(Token = "0x4002FE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform selectionHand;

	[Token(Token = "0x4002FEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private TMP_Text m_LocalSave_DeviceModel;

	[Token(Token = "0x4002FEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private TMP_Text m_LocalSave_DeviceName;

	[Token(Token = "0x4002FEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private TMP_Text m_LocalSave_Date;

	[Token(Token = "0x4002FED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private TMP_Text m_LocalSave_Time;

	[Token(Token = "0x4002FEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private TMP_Text m_CloudSave_DeviceModel;

	[Token(Token = "0x4002FEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private TMP_Text m_CloudSave_DeviceName;

	[Token(Token = "0x4002FF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private TMP_Text m_CloudSave_Date;

	[Token(Token = "0x4002FF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TMP_Text m_CloudSave_Time;

	[Token(Token = "0x4002FF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Choice m_SelectedSave;

	[Token(Token = "0x4002FF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int selectedIndex;

	[Token(Token = "0x4002FF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 handposition;

	[Token(Token = "0x17000441")]
	public Choice SelectedSave
	{
		[Token(Token = "0x6002851")]
		[Address(RVA = "0x1645A74", Offset = "0x1645A74", VA = "0x1645A74")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6002852")]
	[Address(RVA = "0x1645A7C", Offset = "0x1645A7C", VA = "0x1645A7C")]
	public IEnumerator WaitForSaveSelection()
	{
		return null;
	}

	[Token(Token = "0x6002853")]
	[Address(RVA = "0x1645AF0", Offset = "0x1645AF0", VA = "0x1645AF0")]
	public Task<Choice> WaitForSaveSelection_Task()
	{
		return null;
	}

	[Token(Token = "0x6002854")]
	[Address(RVA = "0x1645BFC", Offset = "0x1645BFC", VA = "0x1645BFC", Slot = "4")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6002855")]
	[Address(RVA = "0x1646054", Offset = "0x1646054", VA = "0x1646054")]
	public void SetDetails(SaveGame.SaveData localSaveData, SaveGame.SaveData cloudSaveData)
	{
	}

	[Token(Token = "0x6002856")]
	[Address(RVA = "0x16464F8", Offset = "0x16464F8", VA = "0x16464F8")]
	public void ChooseLocalSave()
	{
	}

	[Token(Token = "0x6002857")]
	[Address(RVA = "0x1646504", Offset = "0x1646504", VA = "0x1646504")]
	public void ChooseCloudSave()
	{
	}

	[Token(Token = "0x6002858")]
	[Address(RVA = "0x1646510", Offset = "0x1646510", VA = "0x1646510")]
	public ReconciliationDialog()
	{
	}
}
