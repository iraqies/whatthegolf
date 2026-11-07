using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000063")]
public class DemoStoreRedirection : MonoBehaviour
{
	[Token(Token = "0x4000190")]
	private const ulong switchFullVersionId = 72105972787961856uL;

	[Token(Token = "0x4000191")]
	private const string steamFullVersionURL = "https://store.steampowered.com/app/785790";

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x18DA71C", Offset = "0x18DA71C", VA = "0x18DA71C")]
	public void GoToStore()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x18DA720", Offset = "0x18DA720", VA = "0x18DA720")]
	public static void RedirectToStore()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x18DA7F4", Offset = "0x18DA7F4", VA = "0x18DA7F4")]
	public DemoStoreRedirection()
	{
	}
}
