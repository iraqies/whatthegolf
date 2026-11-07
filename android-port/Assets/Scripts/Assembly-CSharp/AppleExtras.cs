using System.Runtime.InteropServices;

public static class AppleExtras
{
	[PreserveSig]
	public static extern string _getPreferredLanguage();

	public static string GetPreferredLanguage()
	{
		return null;
	}
}
