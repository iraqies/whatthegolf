using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000755")]
public class GrapplingHookShooter : GolfBallShooterExperimental
{
	[Token(Token = "0x40026DF")]
	[FieldOffset(Offset = "0x88")]
	public GameObject GrapplingHookPrefab;

	[Token(Token = "0x40026E0")]
	[FieldOffset(Offset = "0x90")]
	public int NumberOfHooks;

	[Token(Token = "0x40026E1")]
	[FieldOffset(Offset = "0x94")]
	public float GrappleLength;

	[Token(Token = "0x40026E2")]
	[FieldOffset(Offset = "0x98")]
	public float ObjectThrowSpeed;

	[Token(Token = "0x40026E3")]
	[FieldOffset(Offset = "0x9C")]
	public Vector3 forceShot;

	[Token(Token = "0x40026E4")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private float pullMinDistance;

	[Token(Token = "0x40026E5")]
	[FieldOffset(Offset = "0xB0")]
	public List<AudioClip> RopeReachedMaxLengthClips;

	[Token(Token = "0x40026E6")]
	[FieldOffset(Offset = "0xB8")]
	public AudioSource CreakAudio;

	[Token(Token = "0x40026E7")]
	[FieldOffset(Offset = "0xC0")]
	private List<GrapplingHook> hookQueue;

	[Token(Token = "0x40026E8")]
	[FieldOffset(Offset = "0xC8")]
	private int nextHookIndex;

	[Token(Token = "0x40026E9")]
	[FieldOffset(Offset = "0xD0")]
	private GrapplingHook lastHook;

	[Token(Token = "0x40026EA")]
	[FieldOffset(Offset = "0xD8")]
	private bool firstShot;

	[Token(Token = "0x40026EB")]
	[FieldOffset(Offset = "0xD9")]
	private bool setAffectTime;

	[Token(Token = "0x60021D0")]
	[Address(RVA = "0x14B43BC", Offset = "0x14B43BC", VA = "0x14B43BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60021D1")]
	[Address(RVA = "0x14B4630", Offset = "0x14B4630", VA = "0x14B4630")]
	private void OnCollided(Rigidbody rigid)
	{
	}

	[Token(Token = "0x60021D2")]
	[Address(RVA = "0x14B4634", Offset = "0x14B4634", VA = "0x14B4634", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60021D3")]
	[Address(RVA = "0x14B4884", Offset = "0x14B4884", VA = "0x14B4884")]
	private void Update()
	{
	}

	[Token(Token = "0x60021D4")]
	[Address(RVA = "0x14B4AB8", Offset = "0x14B4AB8", VA = "0x14B4AB8", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60021D5")]
	[Address(RVA = "0x14B4EA8", Offset = "0x14B4EA8", VA = "0x14B4EA8")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60021D6")]
	[Address(RVA = "0x14B5024", Offset = "0x14B5024", VA = "0x14B5024", Slot = "9")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x60021D7")]
	[Address(RVA = "0x14B51D4", Offset = "0x14B51D4", VA = "0x14B51D4")]
	private void EnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x60021D8")]
	[Address(RVA = "0x14B535C", Offset = "0x14B535C", VA = "0x14B535C")]
	public GrapplingHookShooter()
	{
	}
}
