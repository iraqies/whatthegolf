using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200085E")]
public class RotatingPlanet : MonoBehaviour
{
	[Token(Token = "0x4002D6F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x4002D70")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform targetPlanet;

	[Token(Token = "0x6002693")]
	[Address(RVA = "0x1661584", Offset = "0x1661584", VA = "0x1661584")]
	private void Update()
	{
	}

	[Token(Token = "0x6002694")]
	[Address(RVA = "0x1661674", Offset = "0x1661674", VA = "0x1661674")]
	public RotatingPlanet()
	{
	}
}
