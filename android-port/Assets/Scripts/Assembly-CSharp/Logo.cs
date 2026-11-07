using Core;
using Il2CppDummyDll;
using Triband.MountainGeneratorTool;
using UnityEngine;

[Token(Token = "0x200009E")]
public class Logo : AddressableSingleton<Logo>
{
	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x18")]
	public Camera logoAnimationMobileCam;

	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x20")]
	public Camera logoAnimationDesktopCam;

	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x28")]
	public MountainGenerator mountainGenerator;

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x154B37C", Offset = "0x154B37C", VA = "0x154B37C")]
	public Logo()
	{
	}
}
