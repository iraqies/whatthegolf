using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
public class GuidScriptableObject : ScriptableObject
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _guid;

	[Token(Token = "0x17000001")]
	public string guid
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x29F8978", Offset = "0x29F8978", VA = "0x29F8978")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x29F8980", Offset = "0x29F8980", VA = "0x29F8980", Slot = "0")]
	public override bool Equals(object other)
	{
		return default;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x29F8A10", Offset = "0x29F8A10", VA = "0x29F8A10")]
	private static bool EqualsTyped(GuidScriptableObject x, GuidScriptableObject y)
	{
		return default;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x29F8BC4", Offset = "0x29F8BC4", VA = "0x29F8BC4")]
	public static bool operator ==(GuidScriptableObject x, GuidScriptableObject y)
	{
		return default;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x29F8BC8", Offset = "0x29F8BC8", VA = "0x29F8BC8")]
	public static bool operator !=(GuidScriptableObject x, GuidScriptableObject y)
	{
		return default;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x29F8BE0", Offset = "0x29F8BE0", VA = "0x29F8BE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x29F8C70", Offset = "0x29F8C70", VA = "0x29F8C70")]
	public GuidScriptableObject()
	{
	}
}
