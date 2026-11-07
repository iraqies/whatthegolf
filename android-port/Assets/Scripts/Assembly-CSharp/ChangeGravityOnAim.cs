using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ADD")]
public class ChangeGravityOnAim : MonoBehaviour
{
	[Token(Token = "0x4003CA0")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x4003CA1")]
	[FieldOffset(Offset = "0x20")]
	public float GravityStrength;

	[Token(Token = "0x4003CA2")]
	[FieldOffset(Offset = "0x28")]
	public Transform InnerWhiteArrow;

	[Token(Token = "0x4003CA3")]
	[FieldOffset(Offset = "0x30")]
	public float WhiteArrowMoveSpeed;

	[Token(Token = "0x4003CA4")]
	[FieldOffset(Offset = "0x38")]
	public AudioSource OnSource;

	[Token(Token = "0x4003CA5")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> Balls;

	[Token(Token = "0x4003CA6")]
	[FieldOffset(Offset = "0x48")]
	private float moveTimer;

	[Token(Token = "0x60033E9")]
	[Address(RVA = "0x1896AE8", Offset = "0x1896AE8", VA = "0x1896AE8")]
	private void Start()
	{
	}

	[Token(Token = "0x60033EA")]
	[Address(RVA = "0x1896B98", Offset = "0x1896B98", VA = "0x1896B98")]
	private void OnAimUpdate(Vector3 dir, bool b)
	{
	}

	[Token(Token = "0x60033EB")]
	[Address(RVA = "0x1896C88", Offset = "0x1896C88", VA = "0x1896C88")]
	private void Update()
	{
	}

	[Token(Token = "0x60033EC")]
	[Address(RVA = "0x1896EF4", Offset = "0x1896EF4", VA = "0x1896EF4")]
	public ChangeGravityOnAim()
	{
	}
}
