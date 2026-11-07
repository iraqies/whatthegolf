using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200089A")]
public class HingeJointMotorTarget : MonoBehaviour, IHitscanTarget
{
	[Token(Token = "0x4002F42")]
	[FieldOffset(Offset = "0x18")]
	public float StayDuration;

	[Token(Token = "0x4002F43")]
	[FieldOffset(Offset = "0x1C")]
	public float ShowInterval;

	[Token(Token = "0x4002F44")]
	[FieldOffset(Offset = "0x20")]
	public float TargetVelocitySize;

	[Token(Token = "0x4002F45")]
	[FieldOffset(Offset = "0x24")]
	public float StartyDelay;

	[Token(Token = "0x4002F46")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask AcceptedHitLayers;

	[Token(Token = "0x4002F47")]
	[FieldOffset(Offset = "0x30")]
	private HingeJoint joint;

	[Token(Token = "0x4002F48")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x17000433")]
	public Action<IHitscanTarget> OnHitscanHit
	{
		[Token(Token = "0x60027B3")]
		[Address(RVA = "0x14CC2A0", Offset = "0x14CC2A0", VA = "0x14CC2A0", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027B4")]
		[Address(RVA = "0x14CC2E0", Offset = "0x14CC2E0", VA = "0x14CC2E0", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x60027B5")]
	[Address(RVA = "0x14CC320", Offset = "0x14CC320", VA = "0x14CC320")]
	private void Start()
	{
	}

	[Token(Token = "0x60027B6")]
	[Address(RVA = "0x14CC388", Offset = "0x14CC388", VA = "0x14CC388")]
	private void Update()
	{
	}

	[Token(Token = "0x60027B7")]
	[Address(RVA = "0x14CC44C", Offset = "0x14CC44C", VA = "0x14CC44C", Slot = "4")]
	public void OnHit(Vector3 point)
	{
	}

	[Token(Token = "0x60027B8")]
	[Address(RVA = "0x14CC4F4", Offset = "0x14CC4F4", VA = "0x14CC4F4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60027B9")]
	[Address(RVA = "0x14CC5C0", Offset = "0x14CC5C0", VA = "0x14CC5C0")]
	public HingeJointMotorTarget()
	{
	}
}
