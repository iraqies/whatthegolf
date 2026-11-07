using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B1E")]
[Attribute(Name = "RequireComponent", RVA = "0x43508", Offset = "0x43508")]
public class Pull2DObject : MonoBehaviour
{
	[Token(Token = "0x2000B1F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x43570", Offset = "0x43570")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4003E35")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 mousePoint;

		[Token(Token = "0x6003511")]
		[Address(RVA = "0x182EE5C", Offset = "0x182EE5C", VA = "0x182EE5C")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6003512")]
		[Address(RVA = "0x182EE64", Offset = "0x182EE64", VA = "0x182EE64")]
		internal float _003CMouseDown_003Eb__0(Collider2D col)
		{
			return default;
		}
	}

	[Token(Token = "0x4003E2A")]
	[FieldOffset(Offset = "0x18")]
	public bool UsePhysics;

	[Token(Token = "0x4003E2B")]
	[FieldOffset(Offset = "0x1C")]
	public float PullStrength;

	[Token(Token = "0x4003E2C")]
	[FieldOffset(Offset = "0x20")]
	public ForceMode2D PullMode;

	[Token(Token = "0x4003E2D")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource PullSource;

	[Token(Token = "0x4003E2E")]
	[FieldOffset(Offset = "0x30")]
	public LineRope PullDrawer;

	[Token(Token = "0x4003E2F")]
	[FieldOffset(Offset = "0x38")]
	public float PullRadius;

	[Token(Token = "0x4003E30")]
	[FieldOffset(Offset = "0x3C")]
	public LayerMask PullLayers;

	[Token(Token = "0x4003E31")]
	[FieldOffset(Offset = "0x40")]
	private bool pulling;

	[Token(Token = "0x4003E32")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody2D pullingBody;

	[Token(Token = "0x4003E33")]
	[FieldOffset(Offset = "0x50")]
	private SpringJoint2D joint;

	[Token(Token = "0x4003E34")]
	[FieldOffset(Offset = "0x58")]
	private Camera mainCamera;

	[Token(Token = "0x600350B")]
	[Address(RVA = "0x1628888", Offset = "0x1628888", VA = "0x1628888")]
	private void Awake()
	{
	}

	[Token(Token = "0x600350C")]
	[Address(RVA = "0x16288F0", Offset = "0x16288F0", VA = "0x16288F0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600350D")]
	[Address(RVA = "0x16288F4", Offset = "0x16288F4", VA = "0x16288F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600350E")]
	[Address(RVA = "0x1628ABC", Offset = "0x1628ABC", VA = "0x1628ABC")]
	private void MouseDown()
	{
	}

	[Token(Token = "0x600350F")]
	[Address(RVA = "0x1628E4C", Offset = "0x1628E4C", VA = "0x1628E4C")]
	private void MouseUp()
	{
	}

	[Token(Token = "0x6003510")]
	[Address(RVA = "0x1628F9C", Offset = "0x1628F9C", VA = "0x1628F9C")]
	public Pull2DObject()
	{
	}
}
