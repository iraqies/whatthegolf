using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000C53")]
public class TextBasedOnBehaviourEnabled : MonoBehaviour
{
	[Token(Token = "0x40043B0")]
	[FieldOffset(Offset = "0x18")]
	public string TextIfEnabled;

	[Token(Token = "0x40043B1")]
	[FieldOffset(Offset = "0x20")]
	public string TextIfDisabled;

	[Token(Token = "0x40043B2")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro Text;

	[Token(Token = "0x40043B3")]
	[FieldOffset(Offset = "0x30")]
	public MonoBehaviour BehaviourToCheck;

	[Token(Token = "0x6003A9E")]
	[Address(RVA = "0x1710CB8", Offset = "0x1710CB8", VA = "0x1710CB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A9F")]
	[Address(RVA = "0x1710D08", Offset = "0x1710D08", VA = "0x1710D08")]
	public TextBasedOnBehaviourEnabled()
	{
	}
}
