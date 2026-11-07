using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E6D")]
public class AutoMoveDolly : MonoBehaviour
{
	[Token(Token = "0x4004E11")]
	[FieldOffset(Offset = "0x18")]
	public float moveSpeed;

	[Token(Token = "0x4004E12")]
	[FieldOffset(Offset = "0x20")]
	public CinemachineStateDrivenCamera virtualCamera;

	[Token(Token = "0x6004371")]
	[Address(RVA = "0x1515108", Offset = "0x1515108", VA = "0x1515108")]
	public AutoMoveDolly()
	{
	}
}
