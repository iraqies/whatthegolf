using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000003")]
public class CinemachineTouchInputMapper : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x18")]
	public float TouchSensitivityX;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x1C")]
	public float TouchSensitivityY;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x20")]
	public string TouchXInputMapTo;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	public string TouchYInputMapTo;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1903854", Offset = "0x1903854", VA = "0x1903854")]
	private void Start()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1903990", Offset = "0x1903990", VA = "0x1903990")]
	private float GetInputAxis(string axisName)
	{
		return default;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1903A60", Offset = "0x1903A60", VA = "0x1903A60")]
	public CinemachineTouchInputMapper()
	{
	}
}
