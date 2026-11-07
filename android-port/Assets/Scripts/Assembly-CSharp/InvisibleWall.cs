using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000786")]
public class InvisibleWall : MonoBehaviour
{
	[Token(Token = "0x40027C5")]
	[FieldOffset(Offset = "0x18")]
	private Material localMaterial;

	[Token(Token = "0x40027C6")]
	[FieldOffset(Offset = "0x20")]
	public Color visibleColor;

	[Token(Token = "0x40027C7")]
	[FieldOffset(Offset = "0x30")]
	public Color invisibleColor;

	[Token(Token = "0x40027C8")]
	[FieldOffset(Offset = "0x40")]
	private float visibility;

	[Token(Token = "0x6002293")]
	[Address(RVA = "0x14F50BC", Offset = "0x14F50BC", VA = "0x14F50BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002294")]
	[Address(RVA = "0x14F5140", Offset = "0x14F5140", VA = "0x14F5140")]
	private void Update()
	{
	}

	[Token(Token = "0x6002295")]
	[Address(RVA = "0x14F51DC", Offset = "0x14F51DC", VA = "0x14F51DC")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002296")]
	[Address(RVA = "0x14F51EC", Offset = "0x14F51EC", VA = "0x14F51EC")]
	public InvisibleWall()
	{
	}
}
