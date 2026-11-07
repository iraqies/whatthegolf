using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000448")]
public class ChallengeTVScreenColor : MonoBehaviour
{
	[Token(Token = "0x4001754")]
	[FieldOffset(Offset = "0x18")]
	public Color[] screenColors;

	[Token(Token = "0x4001755")]
	[FieldOffset(Offset = "0x20")]
	private Renderer _renderer;

	[Token(Token = "0x6001417")]
	[Address(RVA = "0x18951B4", Offset = "0x18951B4", VA = "0x18951B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6001418")]
	[Address(RVA = "0x1895328", Offset = "0x1895328", VA = "0x1895328")]
	private void OnChallengeTrigger(int count)
	{
	}

	[Token(Token = "0x6001419")]
	[Address(RVA = "0x18953D8", Offset = "0x18953D8", VA = "0x18953D8")]
	public ChallengeTVScreenColor()
	{
	}
}
