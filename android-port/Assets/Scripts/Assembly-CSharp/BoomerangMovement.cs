using Audio;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x200020A")]
public class BoomerangMovement : MonoBehaviour
{
	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x18")]
	public Transform ReturnPoint;

	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x20")]
	public float RotateSpeed;

	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x24")]
	public float ModelRotateSpeed;

	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x28")]
	public float FlySpeed;

	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x30")]
	public HammerThrowingCamera HammerCamera;

	[Token(Token = "0x40009F6")]
	[FieldOffset(Offset = "0x38")]
	public Transform Model;

	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x40")]
	public float MaxVelocity;

	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x44")]
	public float VelocityDampen;

	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x48")]
	public Transform Center;

	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x50")]
	public float ReturnThreshold;

	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x58")]
	public PuppetMaster Puppet;

	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0x60")]
	public TrailRenderer trail;

	[Token(Token = "0x40009FD")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve RotationCurve;

	[Token(Token = "0x40009FE")]
	[FieldOffset(Offset = "0x70")]
	public DropPropOnShoot PropDropper;

	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x78")]
	public float TrailVelocityThreshold;

	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x80")]
	public Collider Collider;

	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x88")]
	public ClipSettingsCollection sfxOnShoot;

	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x90")]
	public ClipSettingsCollection sfxOnPickup;

	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x98")]
	public AudioSource whooshSource;

	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0xA0")]
	public MinMax velocityForAudioModulation;

	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0xA8")]
	public MinMax volumeRange;

	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0xB0")]
	public MinMax pitchRange;

	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0xB8")]
	private Rigidbody rigid;

	[Token(Token = "0x4000A08")]
	[FieldOffset(Offset = "0xC0")]
	private PuppetMasterProp prop;

	[Token(Token = "0x4000A09")]
	[FieldOffset(Offset = "0xC8")]
	private Quaternion origRot;

	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0xD8")]
	private float throwTimer;

	[Token(Token = "0x4000A0B")]
	[FieldOffset(Offset = "0xDC")]
	private bool resetting;

	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 propBoost;

	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0xF0")]
	private Rigidbody pickedUpRigid;

	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0xF8")]
	private float timeAtAwake;

	[Token(Token = "0x600091D")]
	[Address(RVA = "0x1618790", Offset = "0x1618790", VA = "0x1618790")]
	private void Awake()
	{
	}

	[Token(Token = "0x600091E")]
	[Address(RVA = "0x16188E0", Offset = "0x16188E0", VA = "0x16188E0")]
	private void PropDropped(Vector3 boost)
	{
	}

	[Token(Token = "0x600091F")]
	[Address(RVA = "0x1618920", Offset = "0x1618920", VA = "0x1618920")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0x1619004", Offset = "0x1619004", VA = "0x1619004")]
	private void HandleAudioWhileFlying()
	{
	}

	[Token(Token = "0x6000921")]
	[Address(RVA = "0x16191F8", Offset = "0x16191F8", VA = "0x16191F8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000922")]
	[Address(RVA = "0x1619348", Offset = "0x1619348", VA = "0x1619348")]
	public BoomerangMovement()
	{
	}
}
