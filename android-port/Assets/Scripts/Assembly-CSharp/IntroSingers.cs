using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009CA")]
public class IntroSingers : MonoBehaviour
{
	[Token(Token = "0x40035B8")]
	[FieldOffset(Offset = "0x18")]
	public IntroTunnelInOverworld tunnel;

	[Token(Token = "0x40035B9")]
	[FieldOffset(Offset = "0x20")]
	private IntroSinger[] singers;

	[Token(Token = "0x6002E02")]
	[Address(RVA = "0x14F40B8", Offset = "0x14F40B8", VA = "0x14F40B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002E03")]
	[Address(RVA = "0x14F42E4", Offset = "0x14F42E4", VA = "0x14F42E4")]
	private void Tunnel_OnPreAtLogo()
	{
	}

	[Token(Token = "0x6002E04")]
	[Address(RVA = "0x14F4358", Offset = "0x14F4358", VA = "0x14F4358")]
	public IntroSingers()
	{
	}
}
