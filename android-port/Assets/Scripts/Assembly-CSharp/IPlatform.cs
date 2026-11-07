using System;

public interface IPlatform
{
	bool Initialized { get; }

	void RunAfterInitialization(Action act);

	void ShowTrophies(Action<bool> callback);
}
