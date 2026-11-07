using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CF9")]
[Attribute(Name = "RequireComponent", RVA = "0x445B0", Offset = "0x445B0")]
public class BallBulge : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CFA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x44618", Offset = "0x44618")]
	private struct _003CStartTravelling_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x400467F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BallBulge _003C_003E4__this;

		[Token(Token = "0x4004682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x1770E00", Offset = "0x1770E00", VA = "0x1770E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x1771038", Offset = "0x1771038", VA = "0x1771038", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400467C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform ballBulge;

	[Token(Token = "0x400467D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float bulgeDelayInSeconds;

	[Token(Token = "0x400467E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ShortcutTunnelTraversable shortCutUser;

	[Token(Token = "0x6003D50")]
	[Address(RVA = "0x151813C", Offset = "0x151813C", VA = "0x151813C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003D51")]
	[Address(RVA = "0x15182C4", Offset = "0x15182C4", VA = "0x15182C4")]
	private void MovementUpdate(float timeRemaining)
	{
	}

	[Token(Token = "0x6003D52")]
	[Address(RVA = "0x15183F8", Offset = "0x15183F8", VA = "0x15183F8")]
	private void StartTravelling([Optional] ShortcutTunnel t)
	{
	}

	[Token(Token = "0x6003D53")]
	[Address(RVA = "0x1518490", Offset = "0x1518490", VA = "0x1518490")]
	public void EndTraveling([Optional] ShortcutTunnel t)
	{
	}

	[Token(Token = "0x6003D54")]
	[Address(RVA = "0x15184C0", Offset = "0x15184C0", VA = "0x15184C0")]
	public BallBulge()
	{
	}
}
