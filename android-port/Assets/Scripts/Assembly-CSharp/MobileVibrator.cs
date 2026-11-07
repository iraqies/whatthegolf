using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x20003ED")]
public class MobileVibrator
{
	[PreserveSig]
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x15693EC", Offset = "0x15693EC", VA = "0x15693EC")]
	private static extern void iOSVibrationHelperVibrate(int type);

	[Token(Token = "0x6001275")]
	[Address(RVA = "0x15693F0", Offset = "0x15693F0", VA = "0x15693F0")]
	public void Vibrate(EVibrationType type)
	{
	}

	[Token(Token = "0x6001276")]
	[Address(RVA = "0x15693F8", Offset = "0x15693F8", VA = "0x15693F8")]
	public MobileVibrator()
	{
	}
}
