using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E27")]
public class RotateToNormal : MonoBehaviour
{
	[Token(Token = "0x4004CCB")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 contactNormal;

	[Token(Token = "0x6004267")]
	[Address(RVA = "0x165F720", Offset = "0x165F720", VA = "0x165F720")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6004268")]
	[Address(RVA = "0x165F8B4", Offset = "0x165F8B4", VA = "0x165F8B4")]
	public RotateToNormal()
	{
	}
}
