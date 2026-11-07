using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200089B")]
public class HingeJointSpringTarget : MonoBehaviour, IHitscanTarget
{
	[Token(Token = "0x4002F49")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask AcceptedHitLayers;

	[Token(Token = "0x4002F4A")]
	[FieldOffset(Offset = "0x20")]
	private HingeJoint joint;

	[Token(Token = "0x17000434")]
	public Action<IHitscanTarget> OnHitscanHit
	{
		[Token(Token = "0x60027BA")]
		[Address(RVA = "0x14CC5DC", Offset = "0x14CC5DC", VA = "0x14CC5DC", Slot = "5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027BB")]
		[Address(RVA = "0x14CC61C", Offset = "0x14CC61C", VA = "0x14CC61C", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x60027BC")]
	[Address(RVA = "0x14CC65C", Offset = "0x14CC65C", VA = "0x14CC65C")]
	private void Start()
	{
	}

	[Token(Token = "0x60027BD")]
	[Address(RVA = "0x14CC6B8", Offset = "0x14CC6B8", VA = "0x14CC6B8", Slot = "4")]
	public void OnHit(Vector3 point)
	{
	}

	[Token(Token = "0x60027BE")]
	[Address(RVA = "0x14CC6D8", Offset = "0x14CC6D8", VA = "0x14CC6D8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60027BF")]
	[Address(RVA = "0x14CC7B0", Offset = "0x14CC7B0", VA = "0x14CC7B0")]
	public HingeJointSpringTarget()
	{
	}
}
