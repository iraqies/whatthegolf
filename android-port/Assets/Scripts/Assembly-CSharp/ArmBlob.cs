using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A9B")]
public class ArmBlob : MonoBehaviour
{
	[Token(Token = "0x4003AF1")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> throwTargets;

	[Token(Token = "0x4003AF2")]
	[FieldOffset(Offset = "0x20")]
	public float pullForce;

	[Token(Token = "0x4003AF3")]
	[FieldOffset(Offset = "0x24")]
	public float pushForce;

	[Token(Token = "0x4003AF4")]
	[FieldOffset(Offset = "0x28")]
	public float isCloseThreshold;

	[Token(Token = "0x4003AF5")]
	[FieldOffset(Offset = "0x2C")]
	public float isCloseEnoughThreshold;

	[Token(Token = "0x4003AF6")]
	[FieldOffset(Offset = "0x30")]
	public float isTooCloseThreshold;

	[Token(Token = "0x4003AF7")]
	[FieldOffset(Offset = "0x38")]
	public Transform center;

	[Token(Token = "0x4003AF8")]
	[FieldOffset(Offset = "0x40")]
	public Transform target;

	[Token(Token = "0x4003AF9")]
	[FieldOffset(Offset = "0x48")]
	public bool debug;

	[Token(Token = "0x4003AFA")]
	[FieldOffset(Offset = "0x50")]
	public Transform eyeLeft;

	[Token(Token = "0x4003AFB")]
	[FieldOffset(Offset = "0x58")]
	public Transform eyeRight;

	[Token(Token = "0x4003AFC")]
	[FieldOffset(Offset = "0x60")]
	public float eyeMaxMovement;

	[Token(Token = "0x4003AFD")]
	[FieldOffset(Offset = "0x68")]
	public List<Transform> endpoints;

	[Token(Token = "0x4003AFE")]
	[FieldOffset(Offset = "0x70")]
	public float maxDistance;

	[Token(Token = "0x4003AFF")]
	[FieldOffset(Offset = "0x74")]
	public float raycastOffsetForFindingBall;

	[Token(Token = "0x4003B00")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private LayerMask layerMask;

	[Token(Token = "0x4003B01")]
	[FieldOffset(Offset = "0x7C")]
	public float extraDragWhilePulling;

	[Token(Token = "0x4003B02")]
	[FieldOffset(Offset = "0x80")]
	public float dragMinimumVelocity;

	[Token(Token = "0x4003B03")]
	[FieldOffset(Offset = "0x84")]
	public float multiplyOldVelocityBeforeThrowing;

	[Token(Token = "0x4003B04")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 eyeLeftBase;

	[Token(Token = "0x4003B05")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 eyeRightBase;

	[Token(Token = "0x4003B06")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x505D8", Offset = "0x505D8")]
	private bool isPulling__BackingField;

	[Token(Token = "0x4003B07")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 lastBallPos;

	[Token(Token = "0x4003B08")]
	[FieldOffset(Offset = "0xB0")]
	private float nextGrab;

	[Token(Token = "0x4003B09")]
	[FieldOffset(Offset = "0xB4")]
	private bool wasGrabbing;

	[Token(Token = "0x4003B0A")]
	[FieldOffset(Offset = "0xB8")]
	private int nextTarget;

	[Token(Token = "0x4003B0B")]
	[FieldOffset(Offset = "0xC0")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003B0C")]
	[FieldOffset(Offset = "0xC8")]
	public Transform[] ClawLeft;

	[Token(Token = "0x4003B0D")]
	[FieldOffset(Offset = "0xD0")]
	public Transform[] ClawRight;

	[Token(Token = "0x4003B0E")]
	[FieldOffset(Offset = "0xD8")]
	public float ClawRotationOffset;

	[Token(Token = "0x4003B0F")]
	[FieldOffset(Offset = "0xDC")]
	private float clawPct;

	[Token(Token = "0x4003B10")]
	[FieldOffset(Offset = "0xE0")]
	private float lastClawPct;

	[Token(Token = "0x4003B11")]
	[FieldOffset(Offset = "0xE4")]
	public bool ignoreRaycast;

	[Token(Token = "0x4003B12")]
	[FieldOffset(Offset = "0xE8")]
	private RaycastHit2D[] results;

	[Token(Token = "0x4003B13")]
	[FieldOffset(Offset = "0xF0")]
	public AudioEventAsset throwSFX;

	[Token(Token = "0x4003B14")]
	[FieldOffset(Offset = "0xF8")]
	public AudioEventAsset clawSFX;

	[Token(Token = "0x4003B15")]
	[FieldOffset(Offset = "0x100")]
	public float clawSFXCooldown;

	[Token(Token = "0x4003B16")]
	[FieldOffset(Offset = "0x104")]
	private float nextSFXTime;

	[Token(Token = "0x1700053C")]
	public bool isPulling
	{
		[Token(Token = "0x60032A9")]
		[Address(RVA = "0x1423890", Offset = "0x1423890", VA = "0x1423890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F54", Offset = "0x69F54")]
		get
		{
			return default;
		}
		[Token(Token = "0x60032AA")]
		[Address(RVA = "0x1423898", Offset = "0x1423898", VA = "0x1423898")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x69F64", Offset = "0x69F64")]
		private set
		{
		}
	}

	[Token(Token = "0x60032AB")]
	[Address(RVA = "0x14238A0", Offset = "0x14238A0", VA = "0x14238A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60032AC")]
	[Address(RVA = "0x14239AC", Offset = "0x14239AC", VA = "0x14239AC")]
	private void NextRandomTarget()
	{
	}

	[Token(Token = "0x60032AD")]
	[Address(RVA = "0x1423AC4", Offset = "0x1423AC4", VA = "0x1423AC4")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x60032AE")]
	[Address(RVA = "0x1423B00", Offset = "0x1423B00", VA = "0x1423B00")]
	private void UpdateClaws(bool isClawed)
	{
	}

	[Token(Token = "0x60032AF")]
	[Address(RVA = "0x1423CCC", Offset = "0x1423CCC", VA = "0x1423CCC")]
	private void Update()
	{
	}

	[Token(Token = "0x60032B0")]
	[Address(RVA = "0x1424980", Offset = "0x1424980", VA = "0x1424980")]
	public ArmBlob()
	{
	}
}
