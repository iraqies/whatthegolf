using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B61")]
public class SaveSpot : MonoBehaviour
{
	[Token(Token = "0x4003F46")]
	[FieldOffset(Offset = "0x18")]
	protected OverworldID saveID;

	[Token(Token = "0x170005B8")]
	public string ID
	{
		[Token(Token = "0x60036AF")]
		[Address(RVA = "0x1677C18", Offset = "0x1677C18", VA = "0x1677C18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60036AE")]
	[Address(RVA = "0x1677AE4", Offset = "0x1677AE4", VA = "0x1677AE4")]
	public void Init()
	{
	}

	[Token(Token = "0x60036B0")]
	[Address(RVA = "0x1677C34", Offset = "0x1677C34", VA = "0x1677C34")]
	public SaveSpot()
	{
	}
}
