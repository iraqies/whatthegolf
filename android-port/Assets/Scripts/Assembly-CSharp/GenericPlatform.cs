using System;

public class GenericPlatform : SingletonBehaviour<GenericPlatform>, IPlatform
{
	public bool Initialized { get; }

	public void RunAfterInitialization(Action act)
	{
	}

	public void UnlockAchievement(string achievementId, Action<bool> callback)
	{
	}

	public void ShowTrophies(Action<bool> callback)
	{
	}
}
