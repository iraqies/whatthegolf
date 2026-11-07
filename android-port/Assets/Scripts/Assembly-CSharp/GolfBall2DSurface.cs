using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007EA")]
public class GolfBall2DSurface : MonoBehaviour
{
	[Token(Token = "0x4002A6C")]
	[FieldOffset(Offset = "0x18")]
	public GolfBall2DSurfaceMaterial Material;

	[Token(Token = "0x170003F7")]
	public Vector2 Point
	{
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x14904C4", Offset = "0x14904C4", VA = "0x14904C4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170003F8")]
	public Vector2 Normal
	{
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x14904E8", Offset = "0x14904E8", VA = "0x14904E8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6002460")]
	[Address(RVA = "0x149128C", Offset = "0x149128C", VA = "0x149128C")]
	public GolfBall2DSurface()
	{
	}
}
