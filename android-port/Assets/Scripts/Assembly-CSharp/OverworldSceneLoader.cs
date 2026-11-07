using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x20001B8")]
public static class OverworldSceneLoader
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20001B9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DFF0", Offset = "0x3DFF0")]
	private struct _003CLoadOverworld_003Ed__0 : IAsyncStateMachine
	{
		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ContentPack pack;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool tunnel;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x181CE68", Offset = "0x181CE68", VA = "0x181CE68", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x181D02C", Offset = "0x181D02C", VA = "0x181D02C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20001BA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E000", Offset = "0x3E000")]
	private struct _003CTryLoadOverworld_003Ed__1 : IAsyncStateMachine
	{
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ContentPack pack;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool tunnel;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x181D038", Offset = "0x181D038", VA = "0x181D038", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x181D3DC", Offset = "0x181D3DC", VA = "0x181D3DC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x15CB1D4", Offset = "0x15CB1D4", VA = "0x15CB1D4")]
	public static void LoadOverworld(ContentPack pack, bool tunnel)
	{
	}

	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x15CB274", Offset = "0x15CB274", VA = "0x15CB274")]
	public static Task<bool> TryLoadOverworld(ContentPack pack, bool tunnel)
	{
		return null;
	}
}
