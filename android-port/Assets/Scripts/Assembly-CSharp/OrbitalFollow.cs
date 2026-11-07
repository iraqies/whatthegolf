using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200030D")]
[ExecuteAlways]
public class OrbitalFollow : MonoBehaviour
{
	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x18")]
	public Transform center;

	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x20")]
	public Transform controller;

	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x28")]
	public float dist;

	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x2C")]
	private float distance;

	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x159DAB0", Offset = "0x159DAB0", VA = "0x159DAB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x159DAB4", Offset = "0x159DAB4", VA = "0x159DAB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x159DCA4", Offset = "0x159DCA4", VA = "0x159DCA4")]
	public OrbitalFollow()
	{
	}
}
