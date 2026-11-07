using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C7C")]
public class ArcadeSaveGamesDetector : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000C7D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44148", Offset = "0x44148")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004459")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400445A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, DateTime> _003C_003E9__4_0;

		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x176D428", Offset = "0x176D428", VA = "0x176D428")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x176D430", Offset = "0x176D430", VA = "0x176D430")]
		internal DateTime _003CGetLocalSavesList_003Eb__4_0(string f)
		{
			return default;
		}
	}

	[Token(Token = "0x2000C7E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44158", Offset = "0x44158")]
	private sealed class _003CGetCloudSavesSortedByLastModifiedCR_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400445B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400445C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400445D")]
		[FieldOffset(Offset = "0x20")]
		public Action<List<SaveFileInfo>> onDone;

		[Token(Token = "0x400445E")]
		[FieldOffset(Offset = "0x28")]
		public float timeout;

		[Token(Token = "0x400445F")]
		[FieldOffset(Offset = "0x30")]
		public ArcadeSaveGamesDetector _003C_003E4__this;

		[Token(Token = "0x4004460")]
		[FieldOffset(Offset = "0x38")]
		public Action<List<SaveFileInfo>> onDoneAfterTimeout;

		[Token(Token = "0x4004461")]
		[FieldOffset(Offset = "0x40")]
		private List<SaveFileInfo> _003Cfiles_003E5__2;

		[Token(Token = "0x4004462")]
		[FieldOffset(Offset = "0x48")]
		private float _003CtimeoutTime_003E5__3;

		[Token(Token = "0x4004463")]
		[FieldOffset(Offset = "0x50")]
		private TriCloudQuery _003Cquery_003E5__4;

		[Token(Token = "0x17000611")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003B3D")]
			[Address(RVA = "0x176DB04", Offset = "0x176DB04", VA = "0x176DB04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000612")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003B3F")]
			[Address(RVA = "0x176DB4C", Offset = "0x176DB4C", VA = "0x176DB4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x176D43C", Offset = "0x176D43C", VA = "0x176D43C")]
		[DebuggerHidden]
		public _003CGetCloudSavesSortedByLastModifiedCR_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x176D468", Offset = "0x176D468", VA = "0x176D468", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x176D46C", Offset = "0x176D46C", VA = "0x176D46C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x176DB04", Offset = "0x176DB04", VA = "0x176DB04", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x176DB0C", Offset = "0x176DB0C", VA = "0x176DB0C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x176DB4C", Offset = "0x176DB4C", VA = "0x176DB4C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004458")]
	[FieldOffset(Offset = "0x0")]
	private static ArcadeSaveGamesDetector _instance;

	[Token(Token = "0x17000610")]
	public static ArcadeSaveGamesDetector instance
	{
		[Token(Token = "0x6003B31")]
		[Address(RVA = "0x141E2CC", Offset = "0x141E2CC", VA = "0x141E2CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003B32")]
	[Address(RVA = "0x141E40C", Offset = "0x141E40C", VA = "0x141E40C")]
	public List<SaveFileInfo> GetLocalSavesList()
	{
		return null;
	}

	[Token(Token = "0x6003B33")]
	[Address(RVA = "0x141E428", Offset = "0x141E428", VA = "0x141E428")]
	public List<SaveFileInfo> GetLocalSavesList(string saveDirectory)
	{
		return null;
	}

	[Token(Token = "0x6003B34")]
	[Address(RVA = "0x141E868", Offset = "0x141E868", VA = "0x141E868")]
	public void GetCloudSavesSortedByLastModified(float timeout, Action<List<SaveFileInfo>> onDone, Action<List<SaveFileInfo>> onDoneAfterTimeout)
	{
	}

	[Token(Token = "0x6003B35")]
	[Address(RVA = "0x141E908", Offset = "0x141E908", VA = "0x141E908")]
	private IEnumerator GetCloudSavesSortedByLastModifiedCR(float timeout, Action<List<SaveFileInfo>> onDone, Action<List<SaveFileInfo>> onDoneAfterTimeout)
	{
		return null;
	}

	[Token(Token = "0x6003B36")]
	[Address(RVA = "0x141E9A0", Offset = "0x141E9A0", VA = "0x141E9A0")]
	public ArcadeSaveGamesDetector()
	{
	}
}
