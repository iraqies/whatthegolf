using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200049F")]
public class EditorGame : MonoBehaviour
{
	[Token(Token = "0x4001870")]
	[FieldOffset(Offset = "0x18")]
	public LevelData levelData;

	[Token(Token = "0x4001871")]
	[FieldOffset(Offset = "0x20")]
	public string ChallengeID;

	[Token(Token = "0x4001872")]
	[FieldOffset(Offset = "0x28")]
	public string PlayerCount;

	[Token(Token = "0x600155E")]
	[Address(RVA = "0x143AA78", Offset = "0x143AA78", VA = "0x143AA78")]
	public EditorGame()
	{
	}
}
