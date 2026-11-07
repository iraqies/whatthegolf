using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200016F")]
public class ProgressUIFlag : MonoBehaviour
{
	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SVGImage uncompleted;

	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SVGImage completed;

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x16272B0", Offset = "0x16272B0", VA = "0x16272B0")]
	public void Toggle(bool isCompleted)
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x1627310", Offset = "0x1627310", VA = "0x1627310")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x162736C", Offset = "0x162736C", VA = "0x162736C")]
	public ProgressUIFlag()
	{
	}
}
