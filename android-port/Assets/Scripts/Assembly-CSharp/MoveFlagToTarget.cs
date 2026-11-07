using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000304")]
public class MoveFlagToTarget : MonoBehaviour
{
	[Token(Token = "0x2000305")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EE0C", Offset = "0x3EE0C")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0x10")]
		public MoveFlagToTarget _003C_003E4__this;

		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x17F928C", Offset = "0x17F928C", VA = "0x17F928C")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x17F9294", Offset = "0x17F9294", VA = "0x17F9294")]
		internal void _003Cmove_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x18")]
	public Transform position;

	[Token(Token = "0x40010BC")]
	[FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve curve;

	[Token(Token = "0x40010BE")]
	[FieldOffset(Offset = "0x30")]
	public GolfBallController controller;

	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigidbody;

	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x1570F20", Offset = "0x1570F20", VA = "0x1570F20")]
	private void Start()
	{
	}

	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x1570FF4", Offset = "0x1570FF4", VA = "0x1570FF4")]
	private void move(Vector3 boost)
	{
	}

	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x1571190", Offset = "0x1571190", VA = "0x1571190")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x157120C", Offset = "0x157120C", VA = "0x157120C")]
	public MoveFlagToTarget()
	{
	}
}
