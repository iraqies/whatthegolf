using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000998")]
public class OverworldEndTunnelCameraBlender : GolfBehaviour
{
	[Token(Token = "0x40034DC")]
	[FieldOffset(Offset = "0x20")]
	public OverworldCameraSettings inTunnel;

	[Token(Token = "0x40034DD")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine current;

	[Token(Token = "0x40034DE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<ShortcutTunnel> tunnels;

	[Token(Token = "0x6002D02")]
	[Address(RVA = "0x15B58FC", Offset = "0x15B58FC", VA = "0x15B58FC", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x15B5B30", Offset = "0x15B5B30", VA = "0x15B5B30")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D04")]
	[Address(RVA = "0x15B5CF0", Offset = "0x15B5CF0", VA = "0x15B5CF0")]
	private void Tunnel_OnBallEnterTunnel(ShortcutTunnel tunnel)
	{
	}

	[Token(Token = "0x6002D05")]
	[Address(RVA = "0x15B5E40", Offset = "0x15B5E40", VA = "0x15B5E40")]
	private void Tunnel_OnBallExitTunnel(ShortcutTunnel tunnel)
	{
	}

	[Token(Token = "0x6002D06")]
	[Address(RVA = "0x15B5F9C", Offset = "0x15B5F9C", VA = "0x15B5F9C")]
	public OverworldEndTunnelCameraBlender()
	{
	}

	[Token(Token = "0x6002D07")]
	[Address(RVA = "0x15B5FA4", Offset = "0x15B5FA4", VA = "0x15B5FA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68364", Offset = "0x68364")]
	private void _003CTunnel_OnBallEnterTunnel_003Eb__5_0(float t)
	{
	}

	[Token(Token = "0x6002D08")]
	[Address(RVA = "0x15B6028", Offset = "0x15B6028", VA = "0x15B6028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68374", Offset = "0x68374")]
	private void _003CTunnel_OnBallExitTunnel_003Eb__6_0(float t)
	{
	}
}
