using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E70")]
public class BalloonVaseOnBreak : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000E71")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45078", Offset = "0x45078")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004E28")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004E29")]
		[FieldOffset(Offset = "0x8")]
		public static Action<LineRenderer> _003C_003E9__2_0;

		[Token(Token = "0x4004E2A")]
		[FieldOffset(Offset = "0x10")]
		public static Action<LineRope> _003C_003E9__2_1;

		[Token(Token = "0x4004E2B")]
		[FieldOffset(Offset = "0x18")]
		public static Action<SpringJoint> _003C_003E9__2_2;

		[Token(Token = "0x6004385")]
		[Address(RVA = "0x1771464", Offset = "0x1771464", VA = "0x1771464")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6004386")]
		[Address(RVA = "0x177146C", Offset = "0x177146C", VA = "0x177146C")]
		internal void _003COnBreak_003Eb__2_0(LineRenderer l)
		{
		}

		[Token(Token = "0x6004387")]
		[Address(RVA = "0x177148C", Offset = "0x177148C", VA = "0x177148C")]
		internal void _003COnBreak_003Eb__2_1(LineRope l)
		{
		}

		[Token(Token = "0x6004388")]
		[Address(RVA = "0x17714AC", Offset = "0x17714AC", VA = "0x17714AC")]
		internal void _003COnBreak_003Eb__2_2(SpringJoint l)
		{
		}
	}

	[Token(Token = "0x4004E27")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnityEvent OnObjectBreak;

	[Token(Token = "0x6004381")]
	[Address(RVA = "0x151A450", Offset = "0x151A450", VA = "0x151A450")]
	private void Start()
	{
	}

	[Token(Token = "0x6004382")]
	[Address(RVA = "0x151A50C", Offset = "0x151A50C", VA = "0x151A50C")]
	private void OnBreak()
	{
	}

	[Token(Token = "0x6004383")]
	[Address(RVA = "0x151A914", Offset = "0x151A914", VA = "0x151A914")]
	public BalloonVaseOnBreak()
	{
	}
}
