using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C51")]
public class Swing : MonoBehaviour
{
	[Token(Token = "0x2000C52")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x440C8", Offset = "0x440C8")]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x40043AD")]
		[FieldOffset(Offset = "0x10")]
		public Swing _003C_003E4__this;

		[Token(Token = "0x40043AE")]
		[FieldOffset(Offset = "0x18")]
		public float randomVolume;

		[Token(Token = "0x40043AF")]
		[FieldOffset(Offset = "0x1C")]
		public float randomPitch;

		[Token(Token = "0x6003A9C")]
		[Address(RVA = "0x185FC4C", Offset = "0x185FC4C", VA = "0x185FC4C")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x6003A9D")]
		[Address(RVA = "0x185FC54", Offset = "0x185FC54", VA = "0x185FC54")]
		internal void _003CPlaySound_003Eb__0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x400439D")]
	[FieldOffset(Offset = "0x18")]
	public bool DoSwing;

	[Token(Token = "0x400439E")]
	[FieldOffset(Offset = "0x19")]
	public bool UsePhysics;

	[Token(Token = "0x400439F")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 Axis;

	[Token(Token = "0x40043A0")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve AngleCurve;

	[Token(Token = "0x40043A1")]
	[FieldOffset(Offset = "0x30")]
	public float timeOffset;

	[Token(Token = "0x40043A2")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip swooshClip;

	[Token(Token = "0x40043A3")]
	[FieldOffset(Offset = "0x40")]
	public float speedFactor;

	[Token(Token = "0x40043A4")]
	[FieldOffset(Offset = "0x44")]
	public bool useTimeTime;

	[Token(Token = "0x40043A5")]
	[FieldOffset(Offset = "0x48")]
	private float timeIn;

	[Token(Token = "0x40043A6")]
	[FieldOffset(Offset = "0x4C")]
	private float timeOut;

	[Token(Token = "0x40043A7")]
	[FieldOffset(Offset = "0x50")]
	private float soundCooldown;

	[Token(Token = "0x40043A8")]
	[FieldOffset(Offset = "0x54")]
	private float nextSoundAt;

	[Token(Token = "0x40043A9")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody rigidbody;

	[Token(Token = "0x40043AA")]
	[FieldOffset(Offset = "0x60")]
	private float timeValueUsed;

	[Token(Token = "0x40043AB")]
	[FieldOffset(Offset = "0x64")]
	private Quaternion initialRotation;

	[Token(Token = "0x40043AC")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private bool useLocalRotation;

	[Token(Token = "0x6003A94")]
	[Address(RVA = "0x16F24F0", Offset = "0x16F24F0", VA = "0x16F24F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003A95")]
	[Address(RVA = "0x16F26C8", Offset = "0x16F26C8", VA = "0x16F26C8")]
	public void ReturnToDefaultRotation()
	{
	}

	[Token(Token = "0x6003A96")]
	[Address(RVA = "0x16F2708", Offset = "0x16F2708", VA = "0x16F2708")]
	public void StartSwinging()
	{
	}

	[Token(Token = "0x6003A97")]
	[Address(RVA = "0x16F2730", Offset = "0x16F2730", VA = "0x16F2730")]
	public void StopSwinging(bool returnToDefaultRotation)
	{
	}

	[Token(Token = "0x6003A98")]
	[Address(RVA = "0x16F2790", Offset = "0x16F2790", VA = "0x16F2790")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A99")]
	[Address(RVA = "0x16F288C", Offset = "0x16F288C", VA = "0x16F288C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003A9A")]
	[Address(RVA = "0x16F2B3C", Offset = "0x16F2B3C", VA = "0x16F2B3C")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6003A9B")]
	[Address(RVA = "0x16F2CA4", Offset = "0x16F2CA4", VA = "0x16F2CA4")]
	public Swing()
	{
	}
}
