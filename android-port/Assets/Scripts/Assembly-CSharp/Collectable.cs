using System;
using UnityEngine;

public class Collectable : ScriptableObject
{
	public string serializationId;

	public Sprite icon;

	public bool IsImportant;

	public Action OnUnlocked;

	[SerializeField]
	public bool requireUnlock;

	public bool IsUnlocked()
	{
		if (!requireUnlock)
			return true;
		return SaveGame.GetValue(serializationId + "_UNLOCKED", false);
	}

	public void Unlock()
	{
		if (!IsUnlocked())
		{
			SaveGame.SetValue(serializationId + "_UNLOCKED", true, true);
			OnUnlocked?.Invoke();
		}
	}

	public bool WasCollected(string id)
	{
		return SaveGame.IsElementInList(serializationId, id);
	}

	public void Collect(string id)
	{
		SaveGame.AddToSet(serializationId, id);
		SaveGame.Save(false);
	}
}
