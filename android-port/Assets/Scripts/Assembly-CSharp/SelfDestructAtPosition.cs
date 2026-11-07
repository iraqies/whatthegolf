using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F25")]
public class SelfDestructAtPosition : MonoBehaviour
{
	[Token(Token = "0x40051B1")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 axisToCheck;

	[Token(Token = "0x40051B2")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 axisVectorValues;

	[Token(Token = "0x40051B3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject toDestroy;

	[Token(Token = "0x60046CA")]
	[Address(RVA = "0x1689304", Offset = "0x1689304", VA = "0x1689304")]
	private void Update()
	{
	}

	[Token(Token = "0x60046CB")]
	[Address(RVA = "0x16893E8", Offset = "0x16893E8", VA = "0x16893E8")]
	private void DestroyIfInPos(float checkValue, float posAxis, float position)
	{
	}

	[Token(Token = "0x60046CC")]
	[Address(RVA = "0x16894DC", Offset = "0x16894DC", VA = "0x16894DC")]
	public SelfDestructAtPosition()
	{
	}
}
