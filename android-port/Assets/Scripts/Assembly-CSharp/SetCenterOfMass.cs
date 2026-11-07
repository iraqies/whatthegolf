using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B27")]
[Attribute(Name = "RequireComponent", RVA = "0x43580", Offset = "0x43580")]
public class SetCenterOfMass : MonoBehaviour
{
	[Token(Token = "0x4003E59")]
	[FieldOffset(Offset = "0x18")]
	public Transform CenterOfMass;

	[Token(Token = "0x600352A")]
	[Address(RVA = "0x168C2F0", Offset = "0x168C2F0", VA = "0x168C2F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600352B")]
	[Address(RVA = "0x168C3DC", Offset = "0x168C3DC", VA = "0x168C3DC")]
	public void UpdateCenterOfMass(Vector3 newCoMPosition)
	{
	}

	[Token(Token = "0x600352C")]
	[Address(RVA = "0x168C4E0", Offset = "0x168C4E0", VA = "0x168C4E0")]
	public SetCenterOfMass()
	{
	}
}
