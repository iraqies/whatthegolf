using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BCE")]
[Attribute(Name = "RequireComponent", RVA = "0x43D00", Offset = "0x43D00")]
public class ClearTrailOnOutOfBounds : MonoBehaviour
{
	[Token(Token = "0x40041B4")]
	[FieldOffset(Offset = "0x18")]
	private TrailRenderer trail;

	[Token(Token = "0x60038CC")]
	[Address(RVA = "0x189FD98", Offset = "0x189FD98", VA = "0x189FD98")]
	private void Awake()
	{
	}

	[Token(Token = "0x60038CD")]
	[Address(RVA = "0x189FF08", Offset = "0x189FF08", VA = "0x189FF08")]
	private void OnReset()
	{
	}

	[Token(Token = "0x60038CE")]
	[Address(RVA = "0x189FF24", Offset = "0x189FF24", VA = "0x189FF24")]
	public ClearTrailOnOutOfBounds()
	{
	}
}
