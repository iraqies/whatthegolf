using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200056D")]
public class Thankyou : MonoBehaviour
{
	[Token(Token = "0x4001BE7")]
	[FieldOffset(Offset = "0x18")]
	private string key;

	[Token(Token = "0x4001BE8")]
	[FieldOffset(Offset = "0x20")]
	private bool showThankyouOnExit;

	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x1712D20", Offset = "0x1712D20", VA = "0x1712D20")]
	private void Start()
	{
	}

	[Token(Token = "0x60018CB")]
	[Address(RVA = "0x1712E30", Offset = "0x1712E30", VA = "0x1712E30")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x1712E34", Offset = "0x1712E34", VA = "0x1712E34")]
	public Thankyou()
	{
	}
}
