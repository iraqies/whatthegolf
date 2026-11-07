using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E03")]
public class AmongUsEpisodeButtonUpdate : MonoBehaviour
{
	[Token(Token = "0x4004C3E")]
	[FieldOffset(Offset = "0x18")]
	public Sprite amongUsSprite;

	[Token(Token = "0x4004C3F")]
	[FieldOffset(Offset = "0x20")]
	public Sprite defaultSprite;

	[Token(Token = "0x4004C40")]
	[FieldOffset(Offset = "0x28")]
	public GameObject eyes;

	[Token(Token = "0x4004C41")]
	[FieldOffset(Offset = "0x30")]
	public SVGImage image;

	[Token(Token = "0x60041EB")]
	[Address(RVA = "0x140F66C", Offset = "0x140F66C", VA = "0x140F66C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60041EC")]
	[Address(RVA = "0x140F790", Offset = "0x140F790", VA = "0x140F790")]
	public AmongUsEpisodeButtonUpdate()
	{
	}
}
