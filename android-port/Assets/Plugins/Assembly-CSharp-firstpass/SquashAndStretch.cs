using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200003B")]
public class SquashAndStretch : MonoBehaviour
{
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int SquashID;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int RadiusID;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x8")]
	private static MaterialPropertyBlock _mpb;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x18")]
	public MeshRenderer MeshRenderer;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x20")]
	public float CollisionRadius;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x24")]
	public float RaycastDistance;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x28")]
	public bool Use2DPhysics;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x2C")]
	public float Strength;

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x30")]
	public float Dampening;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x34")]
	public float VelocityStretch;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x38")]
	public float MaxSpring;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x3C")]
	private float _squash;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x40")]
	private float _squashVelocity;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 _lastPosition;

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x13FC9B0", Offset = "0x13FC9B0", VA = "0x13FC9B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x13FC9EC", Offset = "0x13FC9EC", VA = "0x13FC9EC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x13FCF38", Offset = "0x13FCF38", VA = "0x13FCF38")]
	public SquashAndStretch()
	{
	}
}
