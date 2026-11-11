using Core;
using UnityEngine;

public class HorseJudge : MonoBehaviour
{
	public Animator Animator;

	public SetMaterialColorToPlayerColor LeftFlag;

	public SetMaterialColorToPlayerColor RightFlag;

	private void Awake()
	{
		if (Level.Instance != null)
		{
			Level.Instance.OnMultiplayerSetup += InstanceOnOnMultiplayerSetup;
		}
	}

	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo info)
	{
		MultiplayerConfiguration config = Level.Instance != null ? Level.Instance.GetMultiplayerConfiguration() : null;
		if (config == null || config.Players == null)
		{
			return;
		}
		for (int i = 0; i < config.Players.Count; i++)
		{
			MultiplayerConfiguration.PlayerInfo p = config.Players[i];
			if (p == null)
			{
				continue;
			}
			if (p.Side == LobbySpawnPoint.SpawnPointPositions.Left)
			{
				if (LeftFlag != null)
				{
					LeftFlag.UpdateMaterials(p.Avatar);
				}
			}
			else if (RightFlag != null)
			{
				RightFlag.UpdateMaterials(p.Avatar);
			}
		}
	}
}
