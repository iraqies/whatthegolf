using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000516")]
public class PackStarter : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000517")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4018C", Offset = "0x4018C")]
	private struct _003CStartPack_003Ed__1 : IAsyncStateMachine
	{
		[Token(Token = "0x4001A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PackStarter _003C_003E4__this;

		[Token(Token = "0x4001A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x6001751")]
		[Address(RVA = "0x182081C", Offset = "0x182081C", VA = "0x182081C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001752")]
		[Address(RVA = "0x1820BF8", Offset = "0x1820BF8", VA = "0x1820BF8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4001A47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string packId;

	[Token(Token = "0x600174F")]
	[Address(RVA = "0x15D49C4", Offset = "0x15D49C4", VA = "0x15D49C4")]
	public void StartPack()
	{
	}

	[Token(Token = "0x6001750")]
	[Address(RVA = "0x15D4A5C", Offset = "0x15D4A5C", VA = "0x15D4A5C")]
	public PackStarter()
	{
	}
}
