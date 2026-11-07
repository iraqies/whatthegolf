using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000808")]
public class RailShooterCar : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000809")]
	public struct RailpointEvent
	{
		[Token(Token = "0x4002B3A")]
		[FieldOffset(Offset = "0x0")]
		public Transform point;

		[Token(Token = "0x4002B3B")]
		[FieldOffset(Offset = "0x8")]
		public UnityEvent OnPointReached;
	}

	[Serializable]
	[Token(Token = "0x200080A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41750", Offset = "0x41750")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002B3C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002B3D")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__14_0;

		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x18301B4", Offset = "0x18301B4", VA = "0x18301B4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x18301BC", Offset = "0x18301BC", VA = "0x18301BC")]
		internal void _003CStop_003Eb__14_0(float v)
		{
		}
	}

	[Token(Token = "0x4002B30")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float ForwardVelocity;

	[Token(Token = "0x4002B31")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<RailpointEvent> PointEvents;

	[Token(Token = "0x4002B32")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float RotationSpeed;

	[Token(Token = "0x4002B33")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float HitStunTime;

	[Token(Token = "0x4002B34")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LayerMask HitStunnersLayers;

	[Token(Token = "0x4002B35")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool startOnAwake;

	[Token(Token = "0x4002B36")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody m_rigidbody;

	[Token(Token = "0x4002B37")]
	[FieldOffset(Offset = "0x40")]
	private float speedMultiplier;

	[Token(Token = "0x4002B38")]
	[FieldOffset(Offset = "0x44")]
	private float hitStunTimer;

	[Token(Token = "0x4002B39")]
	[FieldOffset(Offset = "0x48")]
	private bool isMoving;

	[Token(Token = "0x60024EB")]
	[Address(RVA = "0x163E68C", Offset = "0x163E68C", VA = "0x163E68C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60024EC")]
	[Address(RVA = "0x163E6F8", Offset = "0x163E6F8", VA = "0x163E6F8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60024ED")]
	[Address(RVA = "0x163E978", Offset = "0x163E978", VA = "0x163E978")]
	public void Stop()
	{
	}

	[Token(Token = "0x60024EE")]
	[Address(RVA = "0x163E98C", Offset = "0x163E98C", VA = "0x163E98C")]
	public void Stop(float time)
	{
	}

	[Token(Token = "0x60024EF")]
	[Address(RVA = "0x163EB60", Offset = "0x163EB60", VA = "0x163EB60")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60024F0")]
	[Address(RVA = "0x163EBE4", Offset = "0x163EBE4", VA = "0x163EBE4")]
	public RailShooterCar()
	{
	}

	[Token(Token = "0x60024F1")]
	[Address(RVA = "0x163EBF4", Offset = "0x163EBF4", VA = "0x163EBF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66710", Offset = "0x66710")]
	private void _003CStop_003Eb__14_1()
	{
	}
}
