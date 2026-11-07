using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200099D")]
public class OverworldTunnelCameraBlender : GolfBehaviour
{
	[Token(Token = "0x40034F7")]
	[FieldOffset(Offset = "0x20")]
	public OverworldCameraSettings inTunnel;

	[Token(Token = "0x40034F8")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine current;

	[Token(Token = "0x40034F9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<ShortcutTunnel> tunnels;

	[Token(Token = "0x6002D29")]
	[Address(RVA = "0x15CF0E0", Offset = "0x15CF0E0", VA = "0x15CF0E0", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002D2A")]
	[Address(RVA = "0x15CF18C", Offset = "0x15CF18C", VA = "0x15CF18C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D2B")]
	[Address(RVA = "0x15CF34C", Offset = "0x15CF34C", VA = "0x15CF34C")]
	private void Tunnel_OnBallEnterTunnel(ShortcutTunnel tunnel)
	{
	}

	[Token(Token = "0x6002D2C")]
	[Address(RVA = "0x15CF4A8", Offset = "0x15CF4A8", VA = "0x15CF4A8")]
	private void Tunnel_OnBallExitTunnel(ShortcutTunnel tunnel)
	{
	}

	[Token(Token = "0x6002D2D")]
	[Address(RVA = "0x15CF604", Offset = "0x15CF604", VA = "0x15CF604")]
	public OverworldTunnelCameraBlender()
	{
	}

	[Token(Token = "0x6002D2E")]
	[Address(RVA = "0x15CF60C", Offset = "0x15CF60C", VA = "0x15CF60C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68464", Offset = "0x68464")]
	private void _003CTunnel_OnBallEnterTunnel_003Eb__5_0(float t)
	{
	}

	[Token(Token = "0x6002D2F")]
	[Address(RVA = "0x15CF640", Offset = "0x15CF640", VA = "0x15CF640")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68474", Offset = "0x68474")]
	private void _003CTunnel_OnBallExitTunnel_003Eb__6_0(float t)
	{
	}
}
