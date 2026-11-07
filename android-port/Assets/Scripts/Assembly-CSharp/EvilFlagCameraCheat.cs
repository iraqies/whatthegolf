using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E4")]
public class EvilFlagCameraCheat : MonoBehaviour
{
	[Token(Token = "0x4002416")]
	[FieldOffset(Offset = "0x18")]
	public Material ScreenMaterial;

	[Token(Token = "0x4002417")]
	[FieldOffset(Offset = "0x20")]
	public Camera NewCam;

	[Token(Token = "0x4002418")]
	[FieldOffset(Offset = "0x28")]
	public List<MeshFilter> Quads;

	[Token(Token = "0x4002419")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 Forward;

	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0x144A4C8", Offset = "0x144A4C8", VA = "0x144A4C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0x144A5E4", Offset = "0x144A5E4", VA = "0x144A5E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x144AA20", Offset = "0x144AA20", VA = "0x144AA20")]
	public EvilFlagCameraCheat()
	{
	}
}
