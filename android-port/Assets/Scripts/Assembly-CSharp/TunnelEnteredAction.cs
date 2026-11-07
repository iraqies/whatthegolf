using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20001C2")]
[Attribute(Name = "RequireComponent", RVA = "0x3E040", Offset = "0x3E040")]
public class TunnelEnteredAction : MonoBehaviour
{
	[Token(Token = "0x40007EB")]
	[FieldOffset(Offset = "0x18")]
	private ShortcutTunnel tunnel;

	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent onTunnelEnter;

	[Token(Token = "0x40007ED")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onTunnelExit;

	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x30")]
	private bool inTunnel;

	[Token(Token = "0x1700010A")]
	private ShortcutTunnel Tunnel
	{
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x172FDF4", Offset = "0x172FDF4", VA = "0x172FDF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x172FE74", Offset = "0x172FE74", VA = "0x172FE74")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x1730028", Offset = "0x1730028", VA = "0x1730028")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x17301DC", Offset = "0x17301DC", VA = "0x17301DC")]
	private void TunnelExited(ShortcutTunnel obj)
	{
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x17301F4", Offset = "0x17301F4", VA = "0x17301F4")]
	private void TunnelEntered(ShortcutTunnel obj)
	{
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x1730210", Offset = "0x1730210", VA = "0x1730210")]
	private void Update()
	{
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x173033C", Offset = "0x173033C", VA = "0x173033C")]
	public TunnelEnteredAction()
	{
	}
}
