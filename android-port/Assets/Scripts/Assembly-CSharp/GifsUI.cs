using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005D2")]
public class GifsUI : MonoBehaviour
{
	[Token(Token = "0x4001DAC")]
	[FieldOffset(Offset = "0x0")]
	private static GifsUI s_instance;

	[Token(Token = "0x170002E7")]
	public static GifsUI instance
	{
		[Token(Token = "0x6001A82")]
		[Address(RVA = "0x1489F30", Offset = "0x1489F30", VA = "0x1489F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E8")]
	public GifsPanel gifsPanel
	{
		[Token(Token = "0x6001A83")]
		[Address(RVA = "0x1489F7C", Offset = "0x1489F7C", VA = "0x1489F7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E9")]
	public GifDetailPanel gifDetailPanel
	{
		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x1489FD8", Offset = "0x1489FD8", VA = "0x1489FD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001A85")]
	[Address(RVA = "0x148A034", Offset = "0x148A034", VA = "0x148A034")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001A86")]
	[Address(RVA = "0x148A2B8", Offset = "0x148A2B8", VA = "0x148A2B8")]
	public GifsUI()
	{
	}
}
