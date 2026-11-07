using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C81")]
public static class CloudSave
{
	[Token(Token = "0x2000C82")]
	public enum SaveType
	{
		[Token(Token = "0x400447A")]
		None = 0,
		[Token(Token = "0x400447B")]
		Local = 1,
		[Token(Token = "0x400447C")]
		RequireMainMenuReload = 2,
		[Token(Token = "0x400447D")]
		Identical = 3,
		[Token(Token = "0x400447E")]
		UUID = 4,
		[Token(Token = "0x400447F")]
		ReconciliationLocal = 5,
		[Token(Token = "0x4004480")]
		RequiresMainOverworldReload = 6
	}

	[Token(Token = "0x2000C83")]
	public enum ReconcileType
	{
		[Token(Token = "0x4004482")]
		UserChoice = 0,
		[Token(Token = "0x4004483")]
		NoReconcile = 1,
		[Token(Token = "0x4004484")]
		ForceLocal = 2,
		[Token(Token = "0x4004485")]
		CreateNew = 3
	}

	[Token(Token = "0x2000C84")]
	public struct SaveReconciliationResult
	{
		[Token(Token = "0x4004486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SaveType Type;

		[Token(Token = "0x4004487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SaveGame.SaveData Data;
	}

	[Token(Token = "0x2000C85")]
	public class ICloudResult
	{
		[Token(Token = "0x4004488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string clouddata;

		[Token(Token = "0x4004489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool success;

		[Token(Token = "0x6003B71")]
		[Address(RVA = "0x178A7D0", Offset = "0x178A7D0", VA = "0x178A7D0")]
		public ICloudResult()
		{
		}
	}

	[Token(Token = "0x2000C86")]
	public class CloudSaveResult
	{
		[Token(Token = "0x400448A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SaveGame.SaveData save;

		[Token(Token = "0x400448B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ICloudResult iCloudData;

		[Token(Token = "0x400448C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ParseError;

		[Token(Token = "0x6003B72")]
		[Address(RVA = "0x178A7C8", Offset = "0x178A7C8", VA = "0x178A7C8")]
		public CloudSaveResult()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C87")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44168", Offset = "0x44168")]
	private struct _003CSave_003Ed__22 : IAsyncStateMachine
	{
		[Token(Token = "0x400448D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400448E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400448F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filename;

		[Token(Token = "0x4004490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ReconcileType reconcileType;

		[Token(Token = "0x4004491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<SaveGame.SaveData> restartAfterCloudReconciliation;

		[Token(Token = "0x4004492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003B73")]
		[Address(RVA = "0x178BE30", Offset = "0x178BE30", VA = "0x178BE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003B74")]
		[Address(RVA = "0x178C000", Offset = "0x178C000", VA = "0x178C000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44178", Offset = "0x44178")]
	private struct _003CDownloadSave_003Ed__33 : IAsyncStateMachine
	{
		[Token(Token = "0x4004493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<CloudSaveResult> _003C_003Et__builder;

		[Token(Token = "0x4004495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string filename;

		[Token(Token = "0x4004496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<CloudSaveResult> _003C_003Eu__1;

		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x178A4F8", Offset = "0x178A4F8", VA = "0x178A4F8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x178A7D8", Offset = "0x178A7D8", VA = "0x178A7D8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C89")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44188", Offset = "0x44188")]
	private struct _003CMergeCloudIntoLocal_003Ed__34 : IAsyncStateMachine
	{
		[Token(Token = "0x4004497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<SaveReconciliationResult> _003C_003Et__builder;

		[Token(Token = "0x4004499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SaveGame.SaveData cloudSave;

		[Token(Token = "0x6003B77")]
		[Address(RVA = "0x178B5FC", Offset = "0x178B5FC", VA = "0x178B5FC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x178B9C0", Offset = "0x178B9C0", VA = "0x178B9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000C8A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44198", Offset = "0x44198")]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x400449A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool best;

		[Token(Token = "0x6003B79")]
		[Address(RVA = "0x1788ED8", Offset = "0x1788ED8", VA = "0x1788ED8")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6003B7A")]
		[Address(RVA = "0x1788EE0", Offset = "0x1788EE0", VA = "0x1788EE0")]
		internal object _003CMergeBooleanField_003Eb__0(object mergedValue, object otherValue)
		{
			return null;
		}
	}

	[Token(Token = "0x2000C8B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x441A8", Offset = "0x441A8")]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		[Token(Token = "0x400449B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool max;

		[Token(Token = "0x6003B7B")]
		[Address(RVA = "0x1788F50", Offset = "0x1788F50", VA = "0x1788F50")]
		public _003C_003Ec__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6003B7C")]
		[Address(RVA = "0x1788F58", Offset = "0x1788F58", VA = "0x1788F58")]
		internal object _003CMergeIntegerField_003Eb__0(object mergedValue, object otherValue)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000C8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x441B8", Offset = "0x441B8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400449C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400449D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<object, string> _003C_003E9__39_0;

		[Token(Token = "0x400449E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<string, bool> _003C_003E9__41_0;

		[Token(Token = "0x400449F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<string, bool> _003C_003E9__41_1;

		[Token(Token = "0x40044A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<string, bool> _003C_003E9__41_2;

		[Token(Token = "0x40044A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<string, bool> _003C_003E9__41_3;

		[Token(Token = "0x6003B7E")]
		[Address(RVA = "0x1788D4C", Offset = "0x1788D4C", VA = "0x1788D4C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003B7F")]
		[Address(RVA = "0x1788D54", Offset = "0x1788D54", VA = "0x1788D54")]
		internal string _003CParseList_003Eb__39_0(object obj)
		{
			return null;
		}

		[Token(Token = "0x6003B80")]
		[Address(RVA = "0x1788D78", Offset = "0x1788D78", VA = "0x1788D78")]
		internal bool _003CMergeSettingsSlot_003Eb__41_0(string k)
		{
			return default;
		}

		[Token(Token = "0x6003B81")]
		[Address(RVA = "0x1788DD0", Offset = "0x1788DD0", VA = "0x1788DD0")]
		internal bool _003CMergeSettingsSlot_003Eb__41_1(string k)
		{
			return default;
		}

		[Token(Token = "0x6003B82")]
		[Address(RVA = "0x1788E28", Offset = "0x1788E28", VA = "0x1788E28")]
		internal bool _003CMergeSettingsSlot_003Eb__41_2(string k)
		{
			return default;
		}

		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x1788E80", Offset = "0x1788E80", VA = "0x1788E80")]
		internal bool _003CMergeSettingsSlot_003Eb__41_3(string k)
		{
			return default;
		}
	}

	[Token(Token = "0x2000C8D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x441C8", Offset = "0x441C8")]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x40044A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool requiresReload;

		[Token(Token = "0x40044A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool mergedIsLocal;

		[Token(Token = "0x40044A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string key;

		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x17891E0", Offset = "0x17891E0", VA = "0x17891E0")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6003B85")]
		[Address(RVA = "0x17891E8", Offset = "0x17891E8", VA = "0x17891E8")]
		internal object _003CMergeListField_003Eb__0(object mergedValue, object otherValue)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C8E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x441D8", Offset = "0x441D8")]
	private struct _003CSaveAsync_003Ed__47 : IAsyncStateMachine
	{
		[Token(Token = "0x40044A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40044A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReconcileType reconcileType;

		[Token(Token = "0x40044A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filename;

		[Token(Token = "0x40044A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<SaveGame.SaveData> restartAfterCloudReconciliation;

		[Token(Token = "0x40044AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x40044AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ICloudResult _003Cdata_003E5__2;

		[Token(Token = "0x40044AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<ICloudResult> _003C_003Eu__2;

		[Token(Token = "0x40044AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<SaveReconciliationResult> _003C_003Eu__3;

		[Token(Token = "0x6003B86")]
		[Address(RVA = "0x178C00C", Offset = "0x178C00C", VA = "0x178C00C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003B87")]
		[Address(RVA = "0x178D2CC", Offset = "0x178D2CC", VA = "0x178D2CC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000C8F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x441E8", Offset = "0x441E8")]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		[Token(Token = "0x40044AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool processing;

		[Token(Token = "0x6003B88")]
		[Address(RVA = "0x17896F4", Offset = "0x17896F4", VA = "0x17896F4")]
		public _003C_003Ec__DisplayClass48_0()
		{
		}

		[Token(Token = "0x6003B89")]
		[Address(RVA = "0x17896FC", Offset = "0x17896FC", VA = "0x17896FC")]
		internal void _003CSaveAsync_Internal_003Eg__OnSuccess_007C0()
		{
		}

		[Token(Token = "0x6003B8A")]
		[Address(RVA = "0x17897B0", Offset = "0x17897B0", VA = "0x17897B0")]
		internal void _003CSaveAsync_Internal_003Eg__OnFailure_007C1(string error)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x441F8", Offset = "0x441F8")]
	private struct _003CSaveAsync_Internal_003Ed__48 : IAsyncStateMachine
	{
		[Token(Token = "0x40044AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40044B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string filename;

		[Token(Token = "0x40044B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;

		[Token(Token = "0x40044B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DateTime _003CstartTime_003E5__2;

		[Token(Token = "0x40044B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003B8B")]
		[Address(RVA = "0x178D2D8", Offset = "0x178D2D8", VA = "0x178D2D8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003B8C")]
		[Address(RVA = "0x178DA98", Offset = "0x178DA98", VA = "0x178DA98", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000C91")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44208", Offset = "0x44208")]
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		[Token(Token = "0x40044B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string outValue;

		[Token(Token = "0x40044B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool processing;

		[Token(Token = "0x40044B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ICloudResult result;

		[Token(Token = "0x6003B8D")]
		[Address(RVA = "0x1789884", Offset = "0x1789884", VA = "0x1789884")]
		public _003C_003Ec__DisplayClass50_0()
		{
		}

		[Token(Token = "0x6003B8E")]
		[Address(RVA = "0x178988C", Offset = "0x178988C", VA = "0x178988C")]
		internal void _003CFetchAsync_003Eg__OnSuccess_007C0(Dictionary<string, string> record)
		{
		}

		[Token(Token = "0x6003B8F")]
		[Address(RVA = "0x1789920", Offset = "0x1789920", VA = "0x1789920")]
		internal void _003CFetchAsync_003Eg__OnFailure_007C1(string error)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C92")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44218", Offset = "0x44218")]
	private struct _003CFetchAsync_003Ed__50 : IAsyncStateMachine
	{
		[Token(Token = "0x40044B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<ICloudResult> _003C_003Et__builder;

		[Token(Token = "0x40044BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string filename;

		[Token(Token = "0x40044BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass50_0 _003C_003E8__1;

		[Token(Token = "0x40044BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DateTime _003CstartTime_003E5__2;

		[Token(Token = "0x40044BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003B90")]
		[Address(RVA = "0x178A834", Offset = "0x178A834", VA = "0x178A834", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003B91")]
		[Address(RVA = "0x178B104", Offset = "0x178B104", VA = "0x178B104", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C93")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44228", Offset = "0x44228")]
	private struct _003CGetDataFromFetchAsync_003Ed__52 : IAsyncStateMachine
	{
		[Token(Token = "0x40044BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<CloudSaveResult> _003C_003Et__builder;

		[Token(Token = "0x40044C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string filename;

		[Token(Token = "0x40044C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CloudSaveResult _003Cresult_003E5__2;

		[Token(Token = "0x40044C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<ICloudResult> _003C_003Eu__1;

		[Token(Token = "0x6003B92")]
		[Address(RVA = "0x178B160", Offset = "0x178B160", VA = "0x178B160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x178B5A0", Offset = "0x178B5A0", VA = "0x178B5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000C94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44238", Offset = "0x44238")]
	private sealed class _003C_003Ec__DisplayClass53_0
	{
		[Token(Token = "0x40044C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool processing;

		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x1789AAC", Offset = "0x1789AAC", VA = "0x1789AAC")]
		public _003C_003Ec__DisplayClass53_0()
		{
		}

		[Token(Token = "0x6003B95")]
		[Address(RVA = "0x1789AB4", Offset = "0x1789AB4", VA = "0x1789AB4")]
		internal void _003CDeleteBackupSaveRoutine_003Eg__OnSuccess_007C0()
		{
		}

		[Token(Token = "0x6003B96")]
		[Address(RVA = "0x1789B68", Offset = "0x1789B68", VA = "0x1789B68")]
		internal void _003CDeleteBackupSaveRoutine_003Eg__OnFailure_007C1(string error)
		{
		}
	}

	[Token(Token = "0x2000C95")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44248", Offset = "0x44248")]
	private sealed class _003CDeleteBackupSaveRoutine_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40044C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40044C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40044C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass53_0 _003C_003E8__1;

		[Token(Token = "0x40044C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DateTime _003CstartTime_003E5__2;

		[Token(Token = "0x17000614")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003B9A")]
			[Address(RVA = "0x178A4A8", Offset = "0x178A4A8", VA = "0x178A4A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000615")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003B9C")]
			[Address(RVA = "0x178A4F0", Offset = "0x178A4F0", VA = "0x178A4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003B97")]
		[Address(RVA = "0x1789E8C", Offset = "0x1789E8C", VA = "0x1789E8C")]
		[DebuggerHidden]
		public _003CDeleteBackupSaveRoutine_003Ed__53(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003B98")]
		[Address(RVA = "0x1789EB8", Offset = "0x1789EB8", VA = "0x1789EB8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003B99")]
		[Address(RVA = "0x1789EBC", Offset = "0x1789EBC", VA = "0x1789EBC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003B9A")]
		[Address(RVA = "0x178A4A8", Offset = "0x178A4A8", VA = "0x178A4A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003B9B")]
		[Address(RVA = "0x178A4B0", Offset = "0x178A4B0", VA = "0x178A4B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x178A4F0", Offset = "0x178A4F0", VA = "0x178A4F0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000C96")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44258", Offset = "0x44258")]
	private sealed class _003C_003Ec__DisplayClass54_0
	{
		[Token(Token = "0x40044C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool processing;

		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x1789C3C", Offset = "0x1789C3C", VA = "0x1789C3C")]
		public _003C_003Ec__DisplayClass54_0()
		{
		}

		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x1789C44", Offset = "0x1789C44", VA = "0x1789C44")]
		internal void _003CUpdateAsync_003Eg__OnSuccess_007C0()
		{
		}

		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x1789D58", Offset = "0x1789D58", VA = "0x1789D58")]
		internal void _003CUpdateAsync_003Eg__OnFailure_007C1(string error)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C97")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44268", Offset = "0x44268")]
	private struct _003CUpdateAsync_003Ed__54 : IAsyncStateMachine
	{
		[Token(Token = "0x40044C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40044CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string filename;

		[Token(Token = "0x40044CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass54_0 _003C_003E8__1;

		[Token(Token = "0x40044CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DateTime _003CstartTime_003E5__2;

		[Token(Token = "0x40044CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x178DAA4", Offset = "0x178DAA4", VA = "0x178DAA4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BA1")]
		[Address(RVA = "0x178E2C4", Offset = "0x178E2C4", VA = "0x178E2C4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44278", Offset = "0x44278")]
	private struct _003CReconcileSave_003Ed__55 : IAsyncStateMachine
	{
		[Token(Token = "0x40044CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<SaveReconciliationResult> _003C_003Et__builder;

		[Token(Token = "0x40044D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string fileUrl;

		[Token(Token = "0x6003BA2")]
		[Address(RVA = "0x178BA1C", Offset = "0x178BA1C", VA = "0x178BA1C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BA3")]
		[Address(RVA = "0x178BDD4", Offset = "0x178BDD4", VA = "0x178BDD4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4004468")]
	public const float CLOUD_REQUEST_TIMEOUT = 10f;

	[Token(Token = "0x4004469")]
	public const float CLOUD_REQUEST_TIMEOUT_STARTUP = 5f;

	[Token(Token = "0x400446A")]
	public const float GC_INITIAL_REQUEST_TIMEOUT = 1f;

	[Token(Token = "0x400446B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x51264", Offset = "0x51264")]
	private static Action<bool> m_OnSuccessfulUploadOfSave;

	[Token(Token = "0x400446C")]
	private const bool VERBOSE = false;

	[Token(Token = "0x400446D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Logger dbg;

	[Token(Token = "0x400446E")]
	private const string RECORD_TYPE = "SaveGame";

	[Token(Token = "0x400446F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string BackupRecordID;

	[Token(Token = "0x4004470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float minimumSecondsForComparingSaves;

	[Token(Token = "0x4004471")]
	public const string ICLOUD_CONTAINER_ID = "iCloud.com.thelabelgames.golf.cloud";

	[Token(Token = "0x4004472")]
	private const string TAG = "CloudSave";

	[Token(Token = "0x4004473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly object threadLock;

	[Token(Token = "0x4004474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static bool saveInProgress;

	[Token(Token = "0x4004475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private static bool cancelSaves;

	[Token(Token = "0x4004476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x51274", Offset = "0x51274")]
	private static Action m_OnRequireMainMenuReload;

	[Token(Token = "0x4004477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x51284", Offset = "0x51284")]
	private static Action m_OnRequireMainOverworldReload;

	[Token(Token = "0x4004478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int waitingSaveThreads;

	[Token(Token = "0x17000613")]
	public static bool ICloudIsAvailable
	{
		[Token(Token = "0x6003B54")]
		[Address(RVA = "0x18A1064", Offset = "0x18A1064", VA = "0x18A1064")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x14000073")]
	public static event Action<bool> OnSuccessfulUploadOfSave
	{
		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x18A0E54", Offset = "0x18A0E54", VA = "0x18A0E54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B774", Offset = "0x6B774")]
		add
		{
		}
		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x18A0F5C", Offset = "0x18A0F5C", VA = "0x18A0F5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B784", Offset = "0x6B784")]
		remove
		{
		}
	}

	[Token(Token = "0x14000074")]
	public static event Action OnRequireMainMenuReload
	{
		[Token(Token = "0x6003B58")]
		[Address(RVA = "0x18A13E0", Offset = "0x18A13E0", VA = "0x18A13E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B7A8", Offset = "0x6B7A8")]
		add
		{
		}
		[Token(Token = "0x6003B59")]
		[Address(RVA = "0x18A14EC", Offset = "0x18A14EC", VA = "0x18A14EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B7B8", Offset = "0x6B7B8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000075")]
	public static event Action OnRequireMainOverworldReload
	{
		[Token(Token = "0x6003B5A")]
		[Address(RVA = "0x18A15F8", Offset = "0x18A15F8", VA = "0x18A15F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B7C8", Offset = "0x6B7C8")]
		add
		{
		}
		[Token(Token = "0x6003B5B")]
		[Address(RVA = "0x18A1704", Offset = "0x18A1704", VA = "0x18A1704")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B7D8", Offset = "0x6B7D8")]
		remove
		{
		}
	}

	[Token(Token = "0x6003B55")]
	[Address(RVA = "0x18A106C", Offset = "0x18A106C", VA = "0x18A106C")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6B794", Offset = "0x6B794")]
	private static void Init()
	{
	}

	[Token(Token = "0x6003B56")]
	[Address(RVA = "0x18A10D4", Offset = "0x18A10D4", VA = "0x18A10D4")]
	static CloudSave()
	{
	}

	[Token(Token = "0x6003B57")]
	[Address(RVA = "0x18A1330", Offset = "0x18A1330", VA = "0x18A1330")]
	public static void Save(string filename, ReconcileType reconcileType, [Optional] Action<SaveGame.SaveData> restartAfterCloudReconciliation)
	{
	}

	[Token(Token = "0x6003B5C")]
	[Address(RVA = "0x18A1810", Offset = "0x18A1810", VA = "0x18A1810")]
	public static bool InitializeICloudDatabase()
	{
		return default;
	}

	[Token(Token = "0x6003B5D")]
	[Address(RVA = "0x18A18A0", Offset = "0x18A18A0", VA = "0x18A18A0")]
	public static Task<CloudSaveResult> DownloadSave(string filename)
	{
		return null;
	}

	[Token(Token = "0x6003B5E")]
	[Address(RVA = "0x18A19AC", Offset = "0x18A19AC", VA = "0x18A19AC")]
	public static Task<SaveReconciliationResult> MergeCloudIntoLocal(SaveGame.SaveData cloudSave)
	{
		return null;
	}

	[Token(Token = "0x6003B5F")]
	[Address(RVA = "0x18A1AB8", Offset = "0x18A1AB8", VA = "0x18A1AB8")]
	private static SaveReconciliationResult GetBestSave(SaveGame.SaveData localSave, SaveGame.SaveData cloudSave, SaveReconciliationResult result)
	{
		return default;
	}

	[Token(Token = "0x6003B60")]
	[Address(RVA = "0x18A2C70", Offset = "0x18A2C70", VA = "0x18A2C70")]
	private static void MergeField(int saveslot, string key, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, Func<object, object, object> merge)
	{
	}

	[Token(Token = "0x6003B61")]
	[Address(RVA = "0x18A2FA0", Offset = "0x18A2FA0", VA = "0x18A2FA0")]
	private static void MergeBooleanField(int saveslot, string key, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool best)
	{
	}

	[Token(Token = "0x6003B62")]
	[Address(RVA = "0x18A30CC", Offset = "0x18A30CC", VA = "0x18A30CC")]
	private static void MergeIntegerField(int saveslot, string key, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool max)
	{
	}

	[Token(Token = "0x6003B63")]
	[Address(RVA = "0x18A31F8", Offset = "0x18A31F8", VA = "0x18A31F8")]
	private static List<string> ParseList(object list)
	{
		return null;
	}

	[Token(Token = "0x6003B64")]
	[Address(RVA = "0x18A34AC", Offset = "0x18A34AC", VA = "0x18A34AC")]
	private static bool MergeListField(int saveslot, string key, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool additive, bool mergedIsLocal)
	{
		return default;
	}

	[Token(Token = "0x6003B65")]
	[Address(RVA = "0x18A35E8", Offset = "0x18A35E8", VA = "0x18A35E8")]
	private static void MergeSettingsSlot(SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool mergedIsLocal)
	{
	}

	[Token(Token = "0x6003B66")]
	[Address(RVA = "0x18A3FB4", Offset = "0x18A3FB4", VA = "0x18A3FB4")]
	private static bool MergeSaveSlot(int saveslot, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool mergedIsLocal)
	{
		return default;
	}

	[Token(Token = "0x6003B67")]
	[Address(RVA = "0x18A48B8", Offset = "0x18A48B8", VA = "0x18A48B8")]
	private static bool MergeOverworld(int saveslot, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, bool requiresReload, SaveGame.OverWorldData overworld, bool mergedIsLocal)
	{
		return default;
	}

	[Token(Token = "0x6003B68")]
	[Address(RVA = "0x18A4648", Offset = "0x18A4648", VA = "0x18A4648")]
	private static bool CheckIfNewSaveSlot(int saveslot, SaveGame.SaveData mergedSave, SaveGame.SaveData otherSave, out bool newestSaveSlotIsOther)
	{
		return default;
	}

	[Token(Token = "0x6003B69")]
	[Address(RVA = "0x18A20F8", Offset = "0x18A20F8", VA = "0x18A20F8")]
	public static bool MergeSaveGames(SaveGame.SaveData localSave, SaveGame.SaveData cloudSave, out SaveGame.SaveData mergedSave, out bool requiresOverworldReload, out bool requiresMenuReload)
	{
		return default;
	}

	[Token(Token = "0x6003B6A")]
	[Address(RVA = "0x18A4BB0", Offset = "0x18A4BB0", VA = "0x18A4BB0")]
	private static Task SaveAsync(string filename, ReconcileType reconcileType, Action<SaveGame.SaveData> restartAfterCloudReconciliation)
	{
		return null;
	}

	[Token(Token = "0x6003B6B")]
	[Address(RVA = "0x18A4CA8", Offset = "0x18A4CA8", VA = "0x18A4CA8")]
	private static Task SaveAsync_Internal(string filename)
	{
		return null;
	}

	[Token(Token = "0x6003B6C")]
	[Address(RVA = "0x18A4D84", Offset = "0x18A4D84", VA = "0x18A4D84")]
	private static Task<ICloudResult> FetchAsync(string filename)
	{
		return null;
	}

	[Token(Token = "0x6003B6D")]
	[Address(RVA = "0x18A4E90", Offset = "0x18A4E90", VA = "0x18A4E90")]
	public static Task<CloudSaveResult> GetDataFromFetchAsync(string filename)
	{
		return null;
	}

	[Token(Token = "0x6003B6E")]
	[Address(RVA = "0x18A4FA0", Offset = "0x18A4FA0", VA = "0x18A4FA0")]
	public static IEnumerator DeleteBackupSaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003B6F")]
	[Address(RVA = "0x18A4FFC", Offset = "0x18A4FFC", VA = "0x18A4FFC")]
	private static Task UpdateAsync(string filename)
	{
		return null;
	}

	[Token(Token = "0x6003B70")]
	[Address(RVA = "0x18A50D8", Offset = "0x18A50D8", VA = "0x18A50D8")]
	private static Task<SaveReconciliationResult> ReconcileSave(string fileUrl, bool performReconciliation)
	{
		return null;
	}
}
