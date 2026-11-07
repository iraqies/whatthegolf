using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000899")]
public class HingeJointMotorEnabler : MonoBehaviour
{
	[Token(Token = "0x4002F3F")]
	[FieldOffset(Offset = "0x18")]
	public List<ShootingGalleryTarget> Targets;

	[Token(Token = "0x4002F40")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent AllHitEvent;

	[Token(Token = "0x4002F41")]
	[FieldOffset(Offset = "0x28")]
	private HingeJointMotorTarget joint;

	[Token(Token = "0x60027B0")]
	[Address(RVA = "0x14CC15C", Offset = "0x14CC15C", VA = "0x14CC15C")]
	private void Start()
	{
	}

	[Token(Token = "0x60027B1")]
	[Address(RVA = "0x14CC1B8", Offset = "0x14CC1B8", VA = "0x14CC1B8")]
	private void Update()
	{
	}

	[Token(Token = "0x60027B2")]
	[Address(RVA = "0x14CC298", Offset = "0x14CC298", VA = "0x14CC298")]
	public HingeJointMotorEnabler()
	{
	}
}
