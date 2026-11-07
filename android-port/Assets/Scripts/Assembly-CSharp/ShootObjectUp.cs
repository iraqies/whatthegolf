using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008B1")]
public class ShootObjectUp : MonoBehaviour, IObjectLauncher
{
	[Serializable]
	[Token(Token = "0x20008B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41BA0", Offset = "0x41BA0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002FB7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002FB8")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__10_0;

		[Token(Token = "0x6002822")]
		[Address(RVA = "0x1849B50", Offset = "0x1849B50", VA = "0x1849B50")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002823")]
		[Address(RVA = "0x1849B58", Offset = "0x1849B58", VA = "0x1849B58")]
		internal void _003CStartLauncher_003Eb__10_0(float v)
		{
		}
	}

	[Token(Token = "0x4002FAE")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody2D m_Rigidbody;

	[Token(Token = "0x4002FAF")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 direction;

	[Token(Token = "0x4002FB0")]
	[FieldOffset(Offset = "0x2C")]
	public float force;

	[Token(Token = "0x4002FB1")]
	[FieldOffset(Offset = "0x30")]
	public float angularVelocity;

	[Token(Token = "0x4002FB2")]
	[FieldOffset(Offset = "0x34")]
	public float startDelay;

	[Token(Token = "0x4002FB3")]
	[FieldOffset(Offset = "0x38")]
	public float shootCooldown;

	[Token(Token = "0x4002FB4")]
	[FieldOffset(Offset = "0x3C")]
	private float lastShotTime;

	[Token(Token = "0x4002FB5")]
	[FieldOffset(Offset = "0x40")]
	private bool isRunning;

	[Token(Token = "0x4002FB6")]
	[FieldOffset(Offset = "0x41")]
	private bool hasShot;

	[Token(Token = "0x600281A")]
	[Address(RVA = "0x16A2334", Offset = "0x16A2334", VA = "0x16A2334")]
	private void Awake()
	{
	}

	[Token(Token = "0x600281B")]
	[Address(RVA = "0x16A23AC", Offset = "0x16A23AC", VA = "0x16A23AC", Slot = "4")]
	public void StartLauncher()
	{
	}

	[Token(Token = "0x600281C")]
	[Address(RVA = "0x16A2570", Offset = "0x16A2570", VA = "0x16A2570", Slot = "5")]
	public void StopLauncher()
	{
	}

	[Token(Token = "0x600281D")]
	[Address(RVA = "0x16A2580", Offset = "0x16A2580", VA = "0x16A2580")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600281E")]
	[Address(RVA = "0x16A2680", Offset = "0x16A2680", VA = "0x16A2680")]
	private void AddForce()
	{
	}

	[Token(Token = "0x600281F")]
	[Address(RVA = "0x16A2750", Offset = "0x16A2750", VA = "0x16A2750")]
	public ShootObjectUp()
	{
	}

	[Token(Token = "0x6002820")]
	[Address(RVA = "0x16A2758", Offset = "0x16A2758", VA = "0x16A2758")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67064", Offset = "0x67064")]
	private void _003CStartLauncher_003Eb__10_1()
	{
	}
}
