using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000756")]
public class GrapplingHookShooter2D : GolfBallShooterExperimental
{
	[Token(Token = "0x40026EC")]
	[FieldOffset(Offset = "0x88")]
	public GameObject GrapplingHookPrefab;

	[Token(Token = "0x40026ED")]
	[FieldOffset(Offset = "0x90")]
	public int NumberOfHooks;

	[Token(Token = "0x40026EE")]
	[FieldOffset(Offset = "0x94")]
	public float GrappleLength;

	[Token(Token = "0x40026EF")]
	[FieldOffset(Offset = "0x98")]
	public List<AudioClip> RopeReachedMaxLengthClips;

	[Token(Token = "0x40026F0")]
	[FieldOffset(Offset = "0xA0")]
	public AudioSource CreakAudio;

	[Token(Token = "0x40026F1")]
	[FieldOffset(Offset = "0xA8")]
	public new Rigidbody2D RigidbodyOverride;

	[Token(Token = "0x40026F2")]
	[FieldOffset(Offset = "0xB0")]
	public Collider2D ColliderOverride;

	[Token(Token = "0x40026F3")]
	[FieldOffset(Offset = "0xB8")]
	private List<GrapplingHook2D> hookQueue;

	[Token(Token = "0x40026F4")]
	[FieldOffset(Offset = "0xC0")]
	private int nextHookIndex;

	[Token(Token = "0x40026F5")]
	[FieldOffset(Offset = "0xC8")]
	private GrapplingHook2D lastHook;

	[Token(Token = "0x40026F6")]
	[FieldOffset(Offset = "0xD0")]
	private bool firstShot;

	[Token(Token = "0x40026F7")]
	[FieldOffset(Offset = "0xD1")]
	private bool setAffectTime;

	[Token(Token = "0x40026F8")]
	[FieldOffset(Offset = "0xD8")]
	private Rigidbody2D rigid;

	[Token(Token = "0x40026F9")]
	[FieldOffset(Offset = "0xE0")]
	private bool hooksInitialized;

	[Token(Token = "0x60021D9")]
	[Address(RVA = "0x14B5378", Offset = "0x14B5378", VA = "0x14B5378")]
	private void Start()
	{
	}

	[Token(Token = "0x60021DA")]
	[Address(RVA = "0x14B548C", Offset = "0x14B548C", VA = "0x14B548C")]
	public void SetNumberOfHooks(int hooks)
	{
	}

	[Token(Token = "0x60021DB")]
	[Address(RVA = "0x14B58E8", Offset = "0x14B58E8", VA = "0x14B58E8")]
	private void OnCollided(Rigidbody2D rigid)
	{
	}

	[Token(Token = "0x60021DC")]
	[Address(RVA = "0x14B58EC", Offset = "0x14B58EC", VA = "0x14B58EC", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60021DD")]
	[Address(RVA = "0x14B5A70", Offset = "0x14B5A70", VA = "0x14B5A70")]
	private void Update()
	{
	}

	[Token(Token = "0x60021DE")]
	[Address(RVA = "0x14B5CA4", Offset = "0x14B5CA4", VA = "0x14B5CA4", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60021DF")]
	[Address(RVA = "0x14B5FD8", Offset = "0x14B5FD8", VA = "0x14B5FD8")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60021E0")]
	[Address(RVA = "0x14B6154", Offset = "0x14B6154", VA = "0x14B6154", Slot = "9")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x60021E1")]
	[Address(RVA = "0x14B62FC", Offset = "0x14B62FC", VA = "0x14B62FC")]
	private void EnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x60021E2")]
	[Address(RVA = "0x14B6484", Offset = "0x14B6484", VA = "0x14B6484")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60021E3")]
	[Address(RVA = "0x14B66C4", Offset = "0x14B66C4", VA = "0x14B66C4")]
	public GrapplingHookShooter2D()
	{
	}
}
