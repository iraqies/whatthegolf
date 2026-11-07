using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005B9")]
public class MagnetCraneShooter : MonoBehaviour
{
	[Token(Token = "0x20005BA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x40820", Offset = "0x40820")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4001D43")]
		[FieldOffset(Offset = "0x10")]
		public RaycastHit closest;

		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x17F0AAC", Offset = "0x17F0AAC", VA = "0x17F0AAC")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x17F0AB4", Offset = "0x17F0AB4", VA = "0x17F0AB4")]
		internal bool _003CFixedUpdate_003Eb__1(FixedJoint r)
		{
			return default;
		}
	}

	[Token(Token = "0x4001D35")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x4001D36")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider Magnet;

	[Token(Token = "0x4001D37")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask AffectMask;

	[Token(Token = "0x4001D38")]
	[FieldOffset(Offset = "0x2C")]
	public float MagnetDistance;

	[Token(Token = "0x4001D39")]
	[FieldOffset(Offset = "0x30")]
	public float MagnetForce;

	[Token(Token = "0x4001D3A")]
	[FieldOffset(Offset = "0x34")]
	public ForceMode MagnetForceMode;

	[Token(Token = "0x4001D3B")]
	[FieldOffset(Offset = "0x38")]
	public MeshRenderer MagnetRenderer;

	[Token(Token = "0x4001D3C")]
	[FieldOffset(Offset = "0x40")]
	public Material CraneMaterial;

	[Token(Token = "0x4001D3D")]
	[FieldOffset(Offset = "0x48")]
	public Color OnColor;

	[Token(Token = "0x4001D3E")]
	[FieldOffset(Offset = "0x58")]
	public Color OffColor;

	[Token(Token = "0x4001D3F")]
	[FieldOffset(Offset = "0x68")]
	private List<FixedJoint> stuckRigidbodies;

	[Token(Token = "0x4001D40")]
	[FieldOffset(Offset = "0x70")]
	private Rigidbody rigid;

	[Token(Token = "0x4001D41")]
	[FieldOffset(Offset = "0x78")]
	private AudioSource magnetSource;

	[Token(Token = "0x4001D42")]
	[FieldOffset(Offset = "0x80")]
	private bool attractingAny;

	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x155332C", Offset = "0x155332C", VA = "0x155332C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x1553484", Offset = "0x1553484", VA = "0x1553484")]
	private void Update()
	{
	}

	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x15535EC", Offset = "0x15535EC", VA = "0x15535EC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x1553B28", Offset = "0x1553B28", VA = "0x1553B28")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x1553C88", Offset = "0x1553C88", VA = "0x1553C88")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x1553D30", Offset = "0x1553D30", VA = "0x1553D30")]
	public MagnetCraneShooter()
	{
	}

	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x1553D44", Offset = "0x1553D44", VA = "0x1553D44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x63604", Offset = "0x63604")]
	private float _003CFixedUpdate_003Eb__16_0(RaycastHit h)
	{
		return default;
	}
}
