using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003E7")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3F8E4", Offset = "0x3F8E4")]
public class AudioVolumeToVelocity : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003E8")]
	public class SoundSettingFromRaycast
	{
		[Token(Token = "0x400155A")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 direction;

		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0x1C")]
		public float minVolume;

		[Token(Token = "0x400155C")]
		[FieldOffset(Offset = "0x20")]
		public float maxVolume;

		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x24")]
		public float minVelocity;

		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x28")]
		public float maxVelocity;

		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x2C")]
		public bool touching;

		[Token(Token = "0x600125B")]
		[Address(RVA = "0x1770460", Offset = "0x1770460", VA = "0x1770460")]
		public SoundSettingFromRaycast()
		{
		}
	}

	[Token(Token = "0x4001549")]
	[FieldOffset(Offset = "0x18")]
	public bool use2DRigidbody;

	[Token(Token = "0x400154A")]
	[FieldOffset(Offset = "0x19")]
	public bool use2DSpace;

	[Token(Token = "0x400154B")]
	[FieldOffset(Offset = "0x1A")]
	public bool mustTouchCollider;

	[Token(Token = "0x400154C")]
	[FieldOffset(Offset = "0x1B")]
	public bool noVolumeBelowMinVelocity;

	[Token(Token = "0x400154D")]
	[FieldOffset(Offset = "0x20")]
	public SoundSettingFromRaycast[] velocitySettings;

	[Token(Token = "0x400154E")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask layer;

	[Token(Token = "0x400154F")]
	[FieldOffset(Offset = "0x2C")]
	public float distanceToGroundThreshold;

	[Token(Token = "0x4001550")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody target;

	[Token(Token = "0x4001551")]
	[FieldOffset(Offset = "0x38")]
	public Rigidbody2D target2D;

	[Token(Token = "0x4001552")]
	[FieldOffset(Offset = "0x40")]
	public float fadeTime;

	[Token(Token = "0x4001553")]
	[FieldOffset(Offset = "0x48")]
	private SoundSettingFromRaycast currentDirection;

	[Token(Token = "0x4001554")]
	[FieldOffset(Offset = "0x50")]
	public float currentVelocity;

	[Token(Token = "0x4001555")]
	[FieldOffset(Offset = "0x54")]
	public float highestVelocity;

	[Token(Token = "0x4001556")]
	[FieldOffset(Offset = "0x58")]
	private float timeBeforeStart;

	[Token(Token = "0x4001557")]
	[FieldOffset(Offset = "0x60")]
	private AudioSource audioSrc;

	[Token(Token = "0x4001558")]
	[FieldOffset(Offset = "0x68")]
	private float dampVelocity;

	[Token(Token = "0x4001559")]
	[FieldOffset(Offset = "0x70")]
	private SoundSettingFromRaycast DefaultDirectionSound;

	[Token(Token = "0x6001255")]
	[Address(RVA = "0x1513460", Offset = "0x1513460", VA = "0x1513460")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001256")]
	[Address(RVA = "0x15134D0", Offset = "0x15134D0", VA = "0x15134D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001257")]
	[Address(RVA = "0x15135F8", Offset = "0x15135F8", VA = "0x15135F8")]
	private SoundSettingFromRaycast GetCurrentDirection()
	{
		return null;
	}

	[Token(Token = "0x6001258")]
	[Address(RVA = "0x1513684", Offset = "0x1513684", VA = "0x1513684")]
	private void VolumeFromCurrentDirection()
	{
	}

	[Token(Token = "0x6001259")]
	[Address(RVA = "0x15137DC", Offset = "0x15137DC", VA = "0x15137DC")]
	private bool TouchingSurface(SoundSettingFromRaycast direction)
	{
		return default;
	}

	[Token(Token = "0x600125A")]
	[Address(RVA = "0x15139AC", Offset = "0x15139AC", VA = "0x15139AC")]
	public AudioVolumeToVelocity()
	{
	}
}
