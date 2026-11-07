using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C2A")]
public class RotateBasedOnPlatform : MonoBehaviour
{
	[Token(Token = "0x4004312")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 StandaloneRotation;

	[Token(Token = "0x4004313")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 MobileRotation;

	[Token(Token = "0x6003A28")]
	[Address(RVA = "0x165EFA0", Offset = "0x165EFA0", VA = "0x165EFA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003A29")]
	[Address(RVA = "0x165F060", Offset = "0x165F060", VA = "0x165F060")]
	public RotateBasedOnPlatform()
	{
	}
}
