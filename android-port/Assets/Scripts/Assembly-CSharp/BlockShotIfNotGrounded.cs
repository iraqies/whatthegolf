using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BBE")]
public class BlockShotIfNotGrounded : MonoBehaviour
{
	[Token(Token = "0x2000BBF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43C68", Offset = "0x43C68")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4004173")]
		[FieldOffset(Offset = "0x10")]
		public BlockShotIfNotGrounded _003C_003E4__this;

		[Token(Token = "0x4004174")]
		[FieldOffset(Offset = "0x18")]
		public bool isGrounded;

		[Token(Token = "0x600389C")]
		[Address(RVA = "0x1773494", Offset = "0x1773494", VA = "0x1773494")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x600389D")]
		[Address(RVA = "0x177349C", Offset = "0x177349C", VA = "0x177349C")]
		internal void _003CIsBlocking_003Eb__0()
		{
		}

		[Token(Token = "0x600389E")]
		[Address(RVA = "0x17734BC", Offset = "0x17734BC", VA = "0x17734BC")]
		internal void _003CIsBlocking_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000BC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43C78", Offset = "0x43C78")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4004175")]
		[FieldOffset(Offset = "0x10")]
		public BlockShotIfNotGrounded _003C_003E4__this;

		[Token(Token = "0x4004176")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 d;

		[Token(Token = "0x600389F")]
		[Address(RVA = "0x17734C8", Offset = "0x17734C8", VA = "0x17734C8")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x17734D0", Offset = "0x17734D0", VA = "0x17734D0")]
		internal bool _003CCheckAdditionalTransforms_003Eb__0(Transform t)
		{
			return default;
		}
	}

	[Token(Token = "0x4004165")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LayerMask groundMask;

	[Token(Token = "0x4004166")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float groundDist;

	[Token(Token = "0x4004167")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 down;

	[Token(Token = "0x4004168")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 checkOffset;

	[Token(Token = "0x4004169")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float AcceptedNormalUp;

	[Token(Token = "0x400416A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int framesNeeded;

	[Token(Token = "0x400416B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool addToControllerBlockingFunctions;

	[Token(Token = "0x400416C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform[] additionalTransformChecks;

	[Token(Token = "0x400416D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool is2D;

	[Token(Token = "0x400416E")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float circleCastRadius;

	[Token(Token = "0x400416F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool useLocalDown;

	[Token(Token = "0x4004170")]
	[FieldOffset(Offset = "0x59")]
	[SerializeField]
	public bool isBlocked;

	[Token(Token = "0x4004171")]
	[FieldOffset(Offset = "0x60")]
	private GolfBallController controller;

	[Token(Token = "0x4004172")]
	[FieldOffset(Offset = "0x68")]
	private int frameCount;

	[Token(Token = "0x6003891")]
	[Address(RVA = "0x16132E4", Offset = "0x16132E4", VA = "0x16132E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6003892")]
	[Address(RVA = "0x1613414", Offset = "0x1613414", VA = "0x1613414")]
	private bool IsBlocking()
	{
		return default;
	}

	[Token(Token = "0x6003893")]
	[Address(RVA = "0x1613738", Offset = "0x1613738", VA = "0x1613738")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003894")]
	[Address(RVA = "0x1613660", Offset = "0x1613660", VA = "0x1613660")]
	private bool CheckIsGrounded3D(Vector3 d, Action onDidNotHit, Action onDidHit)
	{
		return default;
	}

	[Token(Token = "0x6003895")]
	[Address(RVA = "0x161398C", Offset = "0x161398C", VA = "0x161398C")]
	private bool HasHitGroundFromPosition(Vector3 position, Vector3 d)
	{
		return default;
	}

	[Token(Token = "0x6003896")]
	[Address(RVA = "0x1613B94", Offset = "0x1613B94", VA = "0x1613B94")]
	private bool AccecptNormals(RaycastHit hit)
	{
		return default;
	}

	[Token(Token = "0x6003897")]
	[Address(RVA = "0x1613A80", Offset = "0x1613A80", VA = "0x1613A80")]
	private bool CheckAdditionalTransforms(Vector3 d)
	{
		return default;
	}

	[Token(Token = "0x6003898")]
	[Address(RVA = "0x1613BF4", Offset = "0x1613BF4", VA = "0x1613BF4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003899")]
	[Address(RVA = "0x1613D98", Offset = "0x1613D98", VA = "0x1613D98")]
	public BlockShotIfNotGrounded()
	{
	}

	[Token(Token = "0x600389A")]
	[Address(RVA = "0x1613DC4", Offset = "0x1613DC4", VA = "0x1613DC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B120", Offset = "0x6B120")]
	private void _003CFixedUpdate_003Eb__16_0()
	{
	}

	[Token(Token = "0x600389B")]
	[Address(RVA = "0x1613E04", Offset = "0x1613E04", VA = "0x1613E04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B130", Offset = "0x6B130")]
	private void _003CFixedUpdate_003Eb__16_1()
	{
	}
}
