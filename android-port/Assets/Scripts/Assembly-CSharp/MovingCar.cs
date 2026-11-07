using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009D7")]
public class MovingCar : MonoBehaviour
{
	[Token(Token = "0x20009D8")]
	public delegate void OnStoppedDelegate();

	[Token(Token = "0x400360C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float offsetTime;

	[Token(Token = "0x400360D")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float tweenTime;

	[Token(Token = "0x400360E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float waitTime;

	[Token(Token = "0x400360F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform[] targets;

	[Token(Token = "0x4003610")]
	[FieldOffset(Offset = "0x30")]
	private AnimationCurve xPosition;

	[Token(Token = "0x4003611")]
	[FieldOffset(Offset = "0x38")]
	private AnimationCurve yPosition;

	[Token(Token = "0x4003612")]
	[FieldOffset(Offset = "0x40")]
	private AnimationCurve zPosition;

	[Token(Token = "0x4003613")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003614")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 lastPosition;

	[Token(Token = "0x4003615")]
	[FieldOffset(Offset = "0x5C")]
	private bool wasMoving;

	[Token(Token = "0x4003616")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF3C", Offset = "0x4FF3C")]
	private OnStoppedDelegate m_OnStopped;

	[Token(Token = "0x4003617")]
	[FieldOffset(Offset = "0x68")]
	public Action OnMoveStart;

	[Token(Token = "0x1400004F")]
	public event OnStoppedDelegate OnStopped
	{
		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x15758F8", Offset = "0x15758F8", VA = "0x15758F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x689B8", Offset = "0x689B8")]
		add
		{
		}
		[Token(Token = "0x6002E4E")]
		[Address(RVA = "0x157599C", Offset = "0x157599C", VA = "0x157599C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x689C8", Offset = "0x689C8")]
		remove
		{
		}
	}

	[Token(Token = "0x6002E4F")]
	[Address(RVA = "0x1575A40", Offset = "0x1575A40", VA = "0x1575A40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002E50")]
	[Address(RVA = "0x1575F4C", Offset = "0x1575F4C", VA = "0x1575F4C")]
	public void Move(float time)
	{
	}

	[Token(Token = "0x6002E51")]
	[Address(RVA = "0x157600C", Offset = "0x157600C", VA = "0x157600C")]
	private Vector3 EvaluatePosition(float time)
	{
		return default;
	}

	[Token(Token = "0x6002E52")]
	[Address(RVA = "0x157608C", Offset = "0x157608C", VA = "0x157608C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002E53")]
	[Address(RVA = "0x1576218", Offset = "0x1576218", VA = "0x1576218")]
	public MovingCar()
	{
	}
}
