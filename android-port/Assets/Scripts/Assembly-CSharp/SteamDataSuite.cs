using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class SteamDataSuite
{
	private class SteamDataSuiteRunner : MonoBehaviour
	{
	}

	private static SteamDataSuiteRunner _instance;

	[CompilerGenerated]
	private static Action<string> m_OnSuccessfulHTTPResponse;

	public static event Action<string> OnSuccessfulHTTPResponse
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void Initialize()
	{
	}

	private static void InternalInit()
	{
	}

	private static void SendForm(SteamDataSuiteConfig config)
	{
	}

	private static IEnumerator HandleFormPost(SteamDataSuiteConfig config)
	{
		return null;
	}
}
