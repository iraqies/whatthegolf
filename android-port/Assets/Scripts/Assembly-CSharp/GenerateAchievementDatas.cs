using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000A")]
public class GenerateAchievementDatas : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x18")]
	public string names;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	public string gamecenterIds;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x28")]
	public string steamIds;

	[Token(Token = "0x400001E")]
	private const string ACHIEVEMENT_DATA_PATH = "Assets/AchievementDatas/";

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x14843F0", Offset = "0x14843F0", VA = "0x14843F0")]
	private string[] Split(string _input)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x148447C", Offset = "0x148447C", VA = "0x148447C")]
	public GenerateAchievementDatas()
	{
	}
}
