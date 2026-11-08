using UnityEngine;

public class QuickMenuActions : MonoBehaviour
{
	public void ExitGame()
	{
		if (QuickMenu.Instance != null)
			QuickMenu.Instance.ExitGame();
		else if (Core.Level.HasInstance)
			Core.Level.Instance.Abort();
		else if (OverworldManager2d.HasInstance && OverworldManager2d.Instance.ui != null)
			OverworldManager2d.Instance.ui.ExitToMenu();
	}

	public void SkipLevel()
	{
		if (QuickMenu.Instance != null)
			QuickMenu.Instance.SkipLevel();
		else if (Core.Level.HasInstance)
			Core.Level.Instance.Complete("SKIPPED!", 0.2f);
	}

	public void RestartLevel()
	{
		if (QuickMenu.Instance != null)
			QuickMenu.Instance.RestartLevel();
		else if (Core.Level.HasInstance)
			Core.Level.Instance.Restart();
	}
}
