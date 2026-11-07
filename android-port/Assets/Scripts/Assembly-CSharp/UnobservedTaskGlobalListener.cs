using System.Threading.Tasks;
using UnityEngine;

public static class UnobservedTaskGlobalListener
{
	[RuntimeInitializeOnLoadMethod]
	public static void Init()
	{
	}

	public static void RegisterGlobalUnobservedTaskExceptionHandler()
	{
	}

	private static void HandleTaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs eventArgs)
	{
	}
}
