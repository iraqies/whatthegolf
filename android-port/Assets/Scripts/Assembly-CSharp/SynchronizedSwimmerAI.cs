using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200026F")]
public class SynchronizedSwimmerAI : MonoBehaviour
{
	[Token(Token = "0x4000CA1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SwimmerShooter shooter;

	[Token(Token = "0x4000CA2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Vector3> sequence;

	[Token(Token = "0x4000CA3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float delayBetweenMoves;

	[Token(Token = "0x4000CA4")]
	[FieldOffset(Offset = "0x2C")]
	private int currentMoveIndex;

	[Token(Token = "0x4000CA5")]
	[FieldOffset(Offset = "0x30")]
	private float lastMoveTime;

	[Token(Token = "0x4000CA6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Rigidbody rb;

	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ShootArrow shootArrow;

	[Token(Token = "0x4000CA8")]
	[FieldOffset(Offset = "0x48")]
	private float inputTarget;

	[Token(Token = "0x4000CA9")]
	[FieldOffset(Offset = "0x50")]
	private GolfBallController controller;

	[Token(Token = "0x4000CAA")]
	[FieldOffset(Offset = "0x58")]
	private float currentAnimVel;

	[Token(Token = "0x4000CAB")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float shootArrowAnimSmoothTime;

	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AD74", Offset = "0x4AD74")]
	private Action<SynchronizedSwimmerAI> m_OnMoveTargetReached;

	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0x68")]
	private bool raisedEventForLastMove;

	[Token(Token = "0x14000007")]
	public event Action<SynchronizedSwimmerAI> OnMoveTargetReached
	{
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x16F5D94", Offset = "0x16F5D94", VA = "0x16F5D94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE6C", Offset = "0x5FE6C")]
		add
		{
		}
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x16F5E38", Offset = "0x16F5E38", VA = "0x16F5E38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FE7C", Offset = "0x5FE7C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x16F5EDC", Offset = "0x16F5EDC", VA = "0x16F5EDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x16F5F5C", Offset = "0x16F5F5C", VA = "0x16F5F5C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x16F6188", Offset = "0x16F6188", VA = "0x16F6188")]
	public SynchronizedSwimmerAI()
	{
	}
}
