using System;
using UnityEngine;

public class Collectable : ScriptableObject
{
	public string serializationId;

	public Sprite icon;

	public bool IsImportant;

	public Action OnUnlocked;

	[SerializeField]
	private bool requireUnlock;

	public bool IsUnlocked()
	{
		return false;
	}

	public void Unlock()
	{
	}

	public bool WasCollected(string id)
	{
		return false;
	}

	public void Collect(string id)
	{
	}
}
