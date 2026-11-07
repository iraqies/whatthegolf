using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.GameKit.Players;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C79")]
public class ArcadeIdentityHelper : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000C7A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44138", Offset = "0x44138")]
	private struct _003CDetermineGameCenterUserAsync_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x400444F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ArcadeIdentityHelper _003C_003E4__this;

		[Token(Token = "0x4004452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> onDone;

		[Token(Token = "0x4004453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float authTimeoutSeconds;

		[Token(Token = "0x4004454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Task<GKAuthenticateResponse> _003Ctask_003E5__2;

		[Token(Token = "0x4004455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<Task> _003C_003Eu__1;

		[Token(Token = "0x6003B2D")]
		[Address(RVA = "0x176CDFC", Offset = "0x176CDFC", VA = "0x176CDFC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003B2E")]
		[Address(RVA = "0x176D3BC", Offset = "0x176D3BC", VA = "0x176D3BC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400444E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ArcadeIdentityHelper _instance;

	[Token(Token = "0x1700060F")]
	public static ArcadeIdentityHelper instance
	{
		[Token(Token = "0x6003B28")]
		[Address(RVA = "0x141DFCC", Offset = "0x141DFCC", VA = "0x141DFCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003B29")]
	[Address(RVA = "0x141E10C", Offset = "0x141E10C", VA = "0x141E10C")]
	public bool HasLocalSaveFile(string filename)
	{
		return default;
	}

	[Token(Token = "0x6003B2A")]
	[Address(RVA = "0x141E180", Offset = "0x141E180", VA = "0x141E180")]
	private void SetGameCenterUserFromCurrent(bool forceAuth)
	{
	}

	[Token(Token = "0x6003B2B")]
	[Address(RVA = "0x141E1D0", Offset = "0x141E1D0", VA = "0x141E1D0")]
	public Task DetermineGameCenterUserAsync(float authTimeoutSeconds, Action<bool> onDone)
	{
		return null;
	}

	[Token(Token = "0x6003B2C")]
	[Address(RVA = "0x141E2C4", Offset = "0x141E2C4", VA = "0x141E2C4")]
	public ArcadeIdentityHelper()
	{
	}
}
