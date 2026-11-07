using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B8A")]
public class SphericalTimeScaleModifier : MonoBehaviour
{
	[Token(Token = "0x400402F")]
	[FieldOffset(Offset = "0x18")]
	public TimeControl TimeControl;

	[Token(Token = "0x4004030")]
	[FieldOffset(Offset = "0x20")]
	public float MinTimeScale;

	[Token(Token = "0x4004031")]
	[FieldOffset(Offset = "0x28")]
	private CBFollow followCam;

	[Token(Token = "0x4004032")]
	[FieldOffset(Offset = "0x30")]
	public float MinElevation;

	[Token(Token = "0x4004033")]
	[FieldOffset(Offset = "0x34")]
	public float MaxRotationAngle;

	[Token(Token = "0x4004034")]
	[FieldOffset(Offset = "0x38")]
	public float RotationMoveSpeed;

	[Token(Token = "0x4004035")]
	[FieldOffset(Offset = "0x40")]
	private SphereCollider collider;

	[Token(Token = "0x4004036")]
	[FieldOffset(Offset = "0x48")]
	private float startElevation;

	[Token(Token = "0x4004037")]
	[FieldOffset(Offset = "0x4C")]
	private float rotTarget;

	[Token(Token = "0x4004038")]
	[FieldOffset(Offset = "0x50")]
	private Transform playerEntered;

	[Token(Token = "0x4004039")]
	[FieldOffset(Offset = "0x58")]
	private bool playerHasExit;

	[Token(Token = "0x60037AB")]
	[Address(RVA = "0x16D2654", Offset = "0x16D2654", VA = "0x16D2654")]
	private void Start()
	{
	}

	[Token(Token = "0x60037AC")]
	[Address(RVA = "0x16D2730", Offset = "0x16D2730", VA = "0x16D2730")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60037AD")]
	[Address(RVA = "0x16D2860", Offset = "0x16D2860", VA = "0x16D2860")]
	private void Update()
	{
	}

	[Token(Token = "0x60037AE")]
	[Address(RVA = "0x16D2D78", Offset = "0x16D2D78", VA = "0x16D2D78")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60037AF")]
	[Address(RVA = "0x16D2E84", Offset = "0x16D2E84", VA = "0x16D2E84")]
	public SphericalTimeScaleModifier()
	{
	}

	[Token(Token = "0x60037B0")]
	[Address(RVA = "0x16D2EAC", Offset = "0x16D2EAC", VA = "0x16D2EAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AD0C", Offset = "0x6AD0C")]
	private void _003CStart_003Eb__11_0(CameraBehavior cb)
	{
	}
}
