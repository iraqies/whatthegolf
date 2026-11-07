using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A1")]
public class JetpackJoyrideBackgroundObject : MonoBehaviour
{
	[Token(Token = "0x4002852")]
	[FieldOffset(Offset = "0x18")]
	public float MoveSpeedMod;

	[Token(Token = "0x4002853")]
	[FieldOffset(Offset = "0x1C")]
	public bool MoveWithPhysics;

	[Token(Token = "0x4002854")]
	[FieldOffset(Offset = "0x20")]
	public Transform BackgroundObjectStartPosition;

	[Token(Token = "0x4002855")]
	[FieldOffset(Offset = "0x28")]
	public Transform BackgroundObjectEndPosition;

	[Token(Token = "0x4002856")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4EAAC", Offset = "0x4EAAC")]
	private Rigidbody2D Rigidbody__BackingField;

	[Token(Token = "0x170003D4")]
	public Rigidbody2D Rigidbody
	{
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x14F69A8", Offset = "0x14F69A8", VA = "0x14F69A8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FA4", Offset = "0x65FA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x14F69B0", Offset = "0x14F69B0", VA = "0x14F69B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65FB4", Offset = "0x65FB4")]
		set
		{
		}
	}

	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x14F69B8", Offset = "0x14F69B8", VA = "0x14F69B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002300")]
	[Address(RVA = "0x14F6A18", Offset = "0x14F6A18", VA = "0x14F6A18")]
	public JetpackJoyrideBackgroundObject()
	{
	}
}
