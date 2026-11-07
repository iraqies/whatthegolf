using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DF0")]
public class BlocMagnet : MonoBehaviour
{
	[Token(Token = "0x4004BEC")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody magnetRigidbody;

	[Token(Token = "0x4004BED")]
	[FieldOffset(Offset = "0x20")]
	public Transform arrowPos;

	[Token(Token = "0x4004BEE")]
	[FieldOffset(Offset = "0x28")]
	public int spaceBetweenBlocs;

	[Token(Token = "0x60041A2")]
	[Address(RVA = "0x1612668", Offset = "0x1612668", VA = "0x1612668")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60041A3")]
	[Address(RVA = "0x1612750", Offset = "0x1612750", VA = "0x1612750")]
	private void Assimilate(GameObject blocToAssimilate, Vector3 colliderBlocPos)
	{
	}

	[Token(Token = "0x60041A4")]
	[Address(RVA = "0x1612B08", Offset = "0x1612B08", VA = "0x1612B08")]
	private int RoundFloat(float value)
	{
		return default;
	}

	[Token(Token = "0x60041A5")]
	[Address(RVA = "0x1612B30", Offset = "0x1612B30", VA = "0x1612B30")]
	public BlocMagnet()
	{
	}
}
