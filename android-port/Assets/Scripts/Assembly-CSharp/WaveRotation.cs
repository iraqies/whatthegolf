using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000890")]
public class WaveRotation : MonoBehaviour
{
	[Token(Token = "0x4002F03")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 axis;

	[Token(Token = "0x4002F04")]
	[FieldOffset(Offset = "0x24")]
	public float angle;

	[Token(Token = "0x4002F05")]
	[FieldOffset(Offset = "0x28")]
	public float variance;

	[Token(Token = "0x4002F06")]
	[FieldOffset(Offset = "0x2C")]
	public float frequency;

	[Token(Token = "0x600278B")]
	[Address(RVA = "0x1751084", Offset = "0x1751084", VA = "0x1751084")]
	private void Update()
	{
	}

	[Token(Token = "0x600278C")]
	[Address(RVA = "0x1751120", Offset = "0x1751120", VA = "0x1751120")]
	public WaveRotation()
	{
	}
}
