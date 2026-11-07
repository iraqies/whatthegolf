using System.Runtime.InteropServices;

public static class OpenUrl_iOSImpl
{
	public static void OpenURL(string url)
	{
	}

	[PreserveSig]
	public static extern void _OpenURL(string url);
}
