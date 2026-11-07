using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A3C")]
public class ResetOnInvisible : MonoBehaviour
{
	[Token(Token = "0x4003885")]
	[FieldOffset(Offset = "0x18")]
	public InvisibleCullingObject cullingObject;

	[Token(Token = "0x4003886")]
	[FieldOffset(Offset = "0x20")]
	public bool isResettingOnLevelExit;

	[Token(Token = "0x4003887")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 startPosition;

	[Token(Token = "0x4003888")]
	[FieldOffset(Offset = "0x2C")]
	private Quaternion startRotation;

	[Token(Token = "0x4003889")]
	[FieldOffset(Offset = "0x3C")]
	private bool isMovingObjectVisible;

	[Token(Token = "0x400388A")]
	[FieldOffset(Offset = "0x3D")]
	private bool isStaticObjectVisible;

	[Token(Token = "0x400388B")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody2D rigid;

	[Token(Token = "0x400388C")]
	[FieldOffset(Offset = "0x48")]
	private bool didReset;

	[Token(Token = "0x400388D")]
	[FieldOffset(Offset = "0x49")]
	public bool isDebug;

	[Token(Token = "0x60030C2")]
	[Address(RVA = "0x164A8F8", Offset = "0x164A8F8", VA = "0x164A8F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60030C3")]
	[Address(RVA = "0x164AC34", Offset = "0x164AC34", VA = "0x164AC34")]
	private void TryReset()
	{
	}

	[Token(Token = "0x60030C4")]
	[Address(RVA = "0x164AC54", Offset = "0x164AC54", VA = "0x164AC54")]
	private void Reset()
	{
	}

	[Token(Token = "0x60030C5")]
	[Address(RVA = "0x164AE54", Offset = "0x164AE54", VA = "0x164AE54")]
	public void OnReturnToOverworld()
	{
	}

	[Token(Token = "0x60030C6")]
	[Address(RVA = "0x164AF14", Offset = "0x164AF14", VA = "0x164AF14")]
	public ResetOnInvisible()
	{
	}

	[Token(Token = "0x60030C7")]
	[Address(RVA = "0x164AF24", Offset = "0x164AF24", VA = "0x164AF24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x695AC", Offset = "0x695AC")]
	private void _003CAwake_003Eb__9_0()
	{
	}

	[Token(Token = "0x60030C8")]
	[Address(RVA = "0x164AF34", Offset = "0x164AF34", VA = "0x164AF34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x695BC", Offset = "0x695BC")]
	private void _003CAwake_003Eb__9_1()
	{
	}

	[Token(Token = "0x60030C9")]
	[Address(RVA = "0x164AF50", Offset = "0x164AF50", VA = "0x164AF50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x695CC", Offset = "0x695CC")]
	private void _003CAwake_003Eb__9_2()
	{
	}

	[Token(Token = "0x60030CA")]
	[Address(RVA = "0x164AF60", Offset = "0x164AF60", VA = "0x164AF60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x695DC", Offset = "0x695DC")]
	private void _003CAwake_003Eb__9_3()
	{
	}
}
