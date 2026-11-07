using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChestTrophee : MonoBehaviour
{
	public Chest chestPC;

	public Chest chestMobile;

	public Animator anim;

	public SpriteRenderer TrophyRenderer;

	public Vector3 TeleportOffset;

	[CompilerGenerated]
	private Action<Chest> m_OnPreChestOpen;

	[CompilerGenerated]
	private Action<Chest> m_OnPostChestOpen;

	private UnlockAchievement achievement;

	public event Action<Chest> OnPreChestOpen
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

	public event Action<Chest> OnPostChestOpen
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

	public void Init()
	{
	}

	private void CheckChest(Chest chest)
	{
	}

	private void RecheckChest(Chest chest)
	{
	}

	private void OnEnable()
	{
	}

	private void Chest_OnPreChestOpen(Chest chest)
	{
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public void Chest_OnChestOpen(Chest chest)
	{
	}

	public bool HasChest()
	{
		return false;
	}

	private IEnumerator FirstUnlockRoutine()
	{
		return null;
	}

	private void InstantUnlock()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
