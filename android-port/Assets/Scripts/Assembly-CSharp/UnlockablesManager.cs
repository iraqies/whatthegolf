using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

[Serializable]
public class UnlockablesManager : ScriptableObject
{
	[SerializeField]
	private UnlockList unlocks;

	public int CoinsAvailable
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int CoinsDonatedLocally
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public UnlockableContentPackage GetPackage(int coinsDonated)
	{
		return null;
	}

	public List<LevelData> GetAllUnlockedLevels()
	{
		return null;
	}

	public List<LevelData> GetUnlockableLevels()
	{
		return null;
	}

	public List<PlayerColors.AvatarIDs> GetAllUnlockedAvatars()
	{
		return null;
	}

	public void ResetAll()
	{
	}
}
