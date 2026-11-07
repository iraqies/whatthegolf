using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006F4")]
public class FPGGyroStatue : MonoBehaviour
{
	[Token(Token = "0x4002480")]
	[FieldOffset(Offset = "0x18")]
	public float mouseMultiplier;

	[Token(Token = "0x4002481")]
	[FieldOffset(Offset = "0x1C")]
	public float timeSpeed;

	[Token(Token = "0x4002482")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 mousepos;

	[Token(Token = "0x4002483")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 lastMouse;

	[Token(Token = "0x4002484")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 mouseEuler;

	[Token(Token = "0x6002017")]
	[Address(RVA = "0x1458F0C", Offset = "0x1458F0C", VA = "0x1458F0C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002018")]
	[Address(RVA = "0x14590D0", Offset = "0x14590D0", VA = "0x14590D0")]
	public FPGGyroStatue()
	{
	}
}
