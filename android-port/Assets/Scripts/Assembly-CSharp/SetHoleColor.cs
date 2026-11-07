using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D10")]
public class SetHoleColor : MonoBehaviour
{
	[Token(Token = "0x2000D11")]
	public enum HoleColorEnum
	{
		[Token(Token = "0x40046F1")]
		FreezerArea = 0,
		[Token(Token = "0x40046F2")]
		SnowArea = 1,
		[Token(Token = "0x40046F3")]
		GrassArea = 2,
		[Token(Token = "0x40046F4")]
		GolfGreenGrass = 3,
		[Token(Token = "0x40046F5")]
		GreenTiles = 4
	}

	[Token(Token = "0x40046EE")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer holeSprite;

	[Token(Token = "0x40046EF")]
	[FieldOffset(Offset = "0x20")]
	public HoleColorEnum holeColor;

	[Token(Token = "0x6003DAE")]
	[Address(RVA = "0x168CCF4", Offset = "0x168CCF4", VA = "0x168CCF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003DAF")]
	[Address(RVA = "0x168CED0", Offset = "0x168CED0", VA = "0x168CED0")]
	private void SetColor(string str)
	{
	}

	[Token(Token = "0x6003DB0")]
	[Address(RVA = "0x168CF2C", Offset = "0x168CF2C", VA = "0x168CF2C")]
	public SetHoleColor()
	{
	}
}
