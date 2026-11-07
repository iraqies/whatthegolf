using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200078B")]
public class MovingTarget : MonoBehaviour
{
	[Token(Token = "0x200078C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x414F0", Offset = "0x414F0")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x40027EC")]
		[FieldOffset(Offset = "0x10")]
		public MovingTarget _003C_003E4__this;

		[Token(Token = "0x40027ED")]
		[FieldOffset(Offset = "0x18")]
		public float endSpeed;

		[Token(Token = "0x60022A8")]
		[Address(RVA = "0x17FC070", Offset = "0x17FC070", VA = "0x17FC070")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60022A9")]
		[Address(RVA = "0x17FC078", Offset = "0x17FC078", VA = "0x17FC078")]
		internal void _003CAwake_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x40027E6")]
	[FieldOffset(Offset = "0x18")]
	public bool isMovingAway;

	[Token(Token = "0x40027E7")]
	[FieldOffset(Offset = "0x1C")]
	public float speed;

	[Token(Token = "0x40027E8")]
	[FieldOffset(Offset = "0x20")]
	public float minDistance;

	[Token(Token = "0x40027E9")]
	[FieldOffset(Offset = "0x28")]
	public Transform avoidTarget;

	[Token(Token = "0x40027EA")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody2D rigid;

	[Token(Token = "0x40027EB")]
	[FieldOffset(Offset = "0x38")]
	private bool fadeInSpeed;

	[Token(Token = "0x60022A5")]
	[Address(RVA = "0x1578E54", Offset = "0x1578E54", VA = "0x1578E54")]
	private void Awake()
	{
	}

	[Token(Token = "0x60022A6")]
	[Address(RVA = "0x1578F74", Offset = "0x1578F74", VA = "0x1578F74")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60022A7")]
	[Address(RVA = "0x157908C", Offset = "0x157908C", VA = "0x157908C")]
	public MovingTarget()
	{
	}
}
