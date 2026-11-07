using System;
using System.Threading.Tasks;
using UnityEngine;

public class ArcadeIdentityHelper : MonoBehaviour
{
	private static ArcadeIdentityHelper _instance;

	public static ArcadeIdentityHelper instance => null;

	public bool HasLocalSaveFile(string filename)
	{
		return false;
	}

	private void SetGameCenterUserFromCurrent(bool forceAuth)
	{
	}

	public Task DetermineGameCenterUserAsync(float authTimeoutSeconds, Action<bool> onDone)
	{
		return null;
	}
}
