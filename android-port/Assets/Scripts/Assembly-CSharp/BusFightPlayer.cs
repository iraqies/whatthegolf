using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200066C")]
public class BusFightPlayer : MonoBehaviour
{
	[Token(Token = "0x400214C")]
	[FieldOffset(Offset = "0x18")]
	public bool CanDie;

	[Token(Token = "0x400214D")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E4BC", Offset = "0x4E4BC")]
	private Action<float> m_OnHitObstacle;

	[Token(Token = "0x400214E")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E4CC", Offset = "0x4E4CC")]
	private Action<float> m_OnExploded;

	[Token(Token = "0x400214F")]
	[FieldOffset(Offset = "0x30")]
	private bool isDead;

	[Token(Token = "0x4002150")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigid;

	[Token(Token = "0x4002151")]
	[FieldOffset(Offset = "0x40")]
	private GolfBallController controller;

	[Token(Token = "0x4002152")]
	[FieldOffset(Offset = "0x48")]
	private GolfCarShooter shooter;

	[Token(Token = "0x1400002D")]
	public event Action<float> OnHitObstacle
	{
		[Token(Token = "0x6001D63")]
		[Address(RVA = "0x17D7418", Offset = "0x17D7418", VA = "0x17D7418")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647AC", Offset = "0x647AC")]
		add
		{
		}
		[Token(Token = "0x6001D64")]
		[Address(RVA = "0x17D74BC", Offset = "0x17D74BC", VA = "0x17D74BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647BC", Offset = "0x647BC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002E")]
	public event Action<float> OnExploded
	{
		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x17D7560", Offset = "0x17D7560", VA = "0x17D7560")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647CC", Offset = "0x647CC")]
		add
		{
		}
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x17D7604", Offset = "0x17D7604", VA = "0x17D7604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x647DC", Offset = "0x647DC")]
		remove
		{
		}
	}

	[Token(Token = "0x6001D67")]
	[Address(RVA = "0x17D76A8", Offset = "0x17D76A8", VA = "0x17D76A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001D68")]
	[Address(RVA = "0x17D7760", Offset = "0x17D7760", VA = "0x17D7760")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6001D69")]
	[Address(RVA = "0x17D672C", Offset = "0x17D672C", VA = "0x17D672C")]
	public void Explode(Vector3 pos)
	{
	}

	[Token(Token = "0x6001D6A")]
	[Address(RVA = "0x17D784C", Offset = "0x17D784C", VA = "0x17D784C")]
	public void Pause()
	{
	}

	[Token(Token = "0x6001D6B")]
	[Address(RVA = "0x17D78B4", Offset = "0x17D78B4", VA = "0x17D78B4")]
	public void Resume()
	{
	}

	[Token(Token = "0x6001D6C")]
	[Address(RVA = "0x17D7970", Offset = "0x17D7970", VA = "0x17D7970")]
	public BusFightPlayer()
	{
	}
}
