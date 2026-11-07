using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003F2")]
public class SetCameraBackground : MonoBehaviour
{
	[Token(Token = "0x4001587")]
	[FieldOffset(Offset = "0x18")]
	public Color backgroundColor;

	[Token(Token = "0x4001588")]
	[FieldOffset(Offset = "0x28")]
	public CameraClearFlags flags;

	[Token(Token = "0x6001280")]
	[Address(RVA = "0x168C274", Offset = "0x168C274", VA = "0x168C274")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001281")]
	[Address(RVA = "0x168C2E8", Offset = "0x168C2E8", VA = "0x168C2E8")]
	public SetCameraBackground()
	{
	}
}
