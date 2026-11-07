using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AA1")]
public class CowPose : MonoBehaviour
{
	[Token(Token = "0x4003B1F")]
	[FieldOffset(Offset = "0x18")]
	public float angle;

	[Token(Token = "0x4003B20")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 bubbleDir;

	[Token(Token = "0x4003B21")]
	[FieldOffset(Offset = "0x28")]
	public Transform bubblePosition;

	[Token(Token = "0x60032BB")]
	[Address(RVA = "0x18BAC58", Offset = "0x18BAC58", VA = "0x18BAC58")]
	public CowPose()
	{
	}
}
