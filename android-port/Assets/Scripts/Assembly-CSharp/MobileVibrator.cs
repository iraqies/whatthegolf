using System.Runtime.InteropServices;

public class MobileVibrator
{
	[PreserveSig]
	private static extern void iOSVibrationHelperVibrate(int type);

	public void Vibrate(EVibrationType type)
	{
	}
}
