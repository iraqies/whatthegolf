using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B8B")]
public class CarAgent : MonoBehaviour
{
	[Token(Token = "0x400403A")]
	[FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x400403B")]
	[FieldOffset(Offset = "0x1C")]
	public float Gravity;

	[Token(Token = "0x400403C")]
	[FieldOffset(Offset = "0x20")]
	public float RotateSpeed;

	[Token(Token = "0x400403D")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask IgnoreLayers;

	[Token(Token = "0x400403E")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask GroundLayer;

	[Token(Token = "0x400403F")]
	[FieldOffset(Offset = "0x2C")]
	public float unlockedForce;

	[Token(Token = "0x4004040")]
	[FieldOffset(Offset = "0x30")]
	public float groundDist;

	[Token(Token = "0x4004041")]
	[FieldOffset(Offset = "0x34")]
	public bool startUnlocked;

	[Token(Token = "0x4004042")]
	[FieldOffset(Offset = "0x38")]
	public List<string> ResetTags;

	[Token(Token = "0x4004043")]
	[FieldOffset(Offset = "0x40")]
	protected Rigidbody rigid;

	[Token(Token = "0x4004044")]
	[FieldOffset(Offset = "0x48")]
	protected TrafficController.TrafficPoint _currentPath;

	[Token(Token = "0x4004045")]
	[FieldOffset(Offset = "0x50")]
	private TrafficController trafficController;

	[Token(Token = "0x4004046")]
	[FieldOffset(Offset = "0x58")]
	private TrafficController.TrafficPoint trafficPoint;

	[Token(Token = "0x4004047")]
	[FieldOffset(Offset = "0x60")]
	public Action _onOutOfBounds;

	[Token(Token = "0x4004048")]
	[FieldOffset(Offset = "0x68")]
	public Action _onCarFallingOffSide;

	[Token(Token = "0x4004049")]
	[FieldOffset(Offset = "0x70")]
	protected Action _onCarCrashed;

	[Token(Token = "0x400404A")]
	[FieldOffset(Offset = "0x78")]
	public Action _onCarSpeeding;

	[Token(Token = "0x400404B")]
	[FieldOffset(Offset = "0x80")]
	protected Transform _currentGoal;

	[Token(Token = "0x400404C")]
	[FieldOffset(Offset = "0x88")]
	protected bool isLocked;

	[Token(Token = "0x400404D")]
	[FieldOffset(Offset = "0x8C")]
	protected Vector3 smoothedNormal;

	[Token(Token = "0x400404E")]
	[FieldOffset(Offset = "0x98")]
	protected float nonGroundTime;

	[Token(Token = "0x400404F")]
	[FieldOffset(Offset = "0x9C")]
	protected bool hasBeenFlat;

	[Token(Token = "0x4004050")]
	[FieldOffset(Offset = "0xA0")]
	protected Vector3 smoothedFlatForward;

	[Token(Token = "0x4004051")]
	[FieldOffset(Offset = "0xAC")]
	protected bool isFalling;

	[Token(Token = "0x4004052")]
	[FieldOffset(Offset = "0xB0")]
	protected float startLockTime;

	[Token(Token = "0x4004053")]
	[FieldOffset(Offset = "0xB4")]
	private bool isSpeedingUp;

	[Token(Token = "0x60037B1")]
	[Address(RVA = "0x1887D38", Offset = "0x1887D38", VA = "0x1887D38")]
	private void Awake()
	{
	}

	[Token(Token = "0x60037B2")]
	[Address(RVA = "0x1887DDC", Offset = "0x1887DDC", VA = "0x1887DDC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60037B3")]
	[Address(RVA = "0x1887F18", Offset = "0x1887F18", VA = "0x1887F18")]
	public void Iniitialize(Vector3 position, Vector3 forward, TrafficController aTrafficController, TrafficController.TrafficPoint point)
	{
	}

	[Token(Token = "0x60037B4")]
	[Address(RVA = "0x1888100", Offset = "0x1888100", VA = "0x1888100")]
	protected Vector3 GetNormal()
	{
		return default;
	}

	[Token(Token = "0x60037B5")]
	[Address(RVA = "0x18881FC", Offset = "0x18881FC", VA = "0x18881FC", Slot = "4")]
	protected virtual void Unlock()
	{
	}

	[Token(Token = "0x60037B6")]
	[Address(RVA = "0x188826C", Offset = "0x188826C", VA = "0x188826C")]
	protected bool IsGrounded()
	{
		return default;
	}

	[Token(Token = "0x60037B7")]
	[Address(RVA = "0x1888344", Offset = "0x1888344", VA = "0x1888344")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60037B8")]
	[Address(RVA = "0x1888478", Offset = "0x1888478", VA = "0x1888478", Slot = "5")]
	protected virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x60037B9")]
	[Address(RVA = "0x1888974", Offset = "0x1888974", VA = "0x1888974")]
	public CarAgent()
	{
	}
}
