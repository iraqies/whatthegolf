using Il2CppDummyDll;
using OldMoatGames;
using TMPro;
using UnityEngine;

[Token(Token = "0x20008DE")]
public class LevelStatTemplate : MonoBehaviour
{
	[Token(Token = "0x400307E")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI LevelStats;

	[Token(Token = "0x400307F")]
	[FieldOffset(Offset = "0x20")]
	public AnimatedGifPlayer GifImage;

	[Token(Token = "0x4003080")]
	[FieldOffset(Offset = "0x28")]
	public bool GifCompleted;

	[Token(Token = "0x4003081")]
	[FieldOffset(Offset = "0x30")]
	private string level;

	[Token(Token = "0x6002902")]
	[Address(RVA = "0x1530B54", Offset = "0x1530B54", VA = "0x1530B54")]
	private void Start()
	{
	}

	[Token(Token = "0x6002903")]
	[Address(RVA = "0x1530BE8", Offset = "0x1530BE8", VA = "0x1530BE8")]
	public void OpenGif()
	{
	}

	[Token(Token = "0x6002904")]
	[Address(RVA = "0x1530D04", Offset = "0x1530D04", VA = "0x1530D04")]
	public void SetStats(string levelName, int hole, int strokes)
	{
	}

	[Token(Token = "0x6002905")]
	[Address(RVA = "0x1530FEC", Offset = "0x1530FEC", VA = "0x1530FEC")]
	private void GifImage_OnReady()
	{
	}

	[Token(Token = "0x6002906")]
	[Address(RVA = "0x15310AC", Offset = "0x15310AC", VA = "0x15310AC")]
	public LevelStatTemplate()
	{
	}

	[Token(Token = "0x6002907")]
	[Address(RVA = "0x15310B4", Offset = "0x15310B4", VA = "0x15310B4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x674D8", Offset = "0x674D8")]
	private void _003CGifImage_OnReady_003Eb__7_0(float t)
	{
	}
}
