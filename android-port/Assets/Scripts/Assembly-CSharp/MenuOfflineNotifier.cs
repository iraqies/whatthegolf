using UnityEngine;
using UnityEngine.Events;

public class MenuOfflineNotifier
{
	private static bool _shownOfflineWarning;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public static bool ShouldShowOfflineWarning()
	{
		return false;
	}

	public static void ShowOfflineMode(UnityAction onClose)
	{
	}
}
