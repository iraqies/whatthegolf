using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A47")]
[Attribute(Name = "RequireComponent", RVA = "0x42BF8", Offset = "0x42BF8")]
public class ShortcutTunnelTraversable : MonoBehaviour
{
	[Token(Token = "0x40038DE")]
	[FieldOffset(Offset = "0x18")]
	public bool isTraveling;

	[Token(Token = "0x40038DF")]
	[FieldOffset(Offset = "0x19")]
	public bool isDebug;

	[Token(Token = "0x40038E0")]
	[FieldOffset(Offset = "0x1A")]
	public bool EndTravelOnDisable;

	[Token(Token = "0x40038E1")]
	[FieldOffset(Offset = "0x1C")]
	public float nextTravelTime;

	[Token(Token = "0x6003106")]
	[Address(RVA = "0x16A5AEC", Offset = "0x16A5AEC", VA = "0x16A5AEC")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6003107")]
	[Address(RVA = "0x16A5BE8", Offset = "0x16A5BE8", VA = "0x16A5BE8")]
	public void StartTravel()
	{
	}

	[Token(Token = "0x6003108")]
	[Address(RVA = "0x16A53E8", Offset = "0x16A53E8", VA = "0x16A53E8")]
	public void EndTravel(Vector3 dir, float speed)
	{
	}

	[Token(Token = "0x6003109")]
	[Address(RVA = "0x16A5D68", Offset = "0x16A5D68", VA = "0x16A5D68")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600310A")]
	[Address(RVA = "0x16A5DA4", Offset = "0x16A5DA4", VA = "0x16A5DA4")]
	public ShortcutTunnelTraversable()
	{
	}
}
