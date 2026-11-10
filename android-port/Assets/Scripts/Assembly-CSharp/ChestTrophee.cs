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

	public Vector3 TeleportOffset = new Vector3(0.1f, 0f, 0f);

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
			m_OnPreChestOpen = (Action<Chest>)Delegate.Combine(m_OnPreChestOpen, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnPreChestOpen = (Action<Chest>)Delegate.Remove(m_OnPreChestOpen, value);
		}
	}

	public event Action<Chest> OnPostChestOpen
	{
		[CompilerGenerated]
		add
		{
			m_OnPostChestOpen = (Action<Chest>)Delegate.Combine(m_OnPostChestOpen, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnPostChestOpen = (Action<Chest>)Delegate.Remove(m_OnPostChestOpen, value);
		}
	}

	public void Init()
	{
		CheckChest(chestPC);
		CheckChest(chestMobile);
		achievement = GetComponent<UnlockAchievement>();
		if (chestPC != null)
		{
			chestPC.OnInstantChestOpen += RecheckChest;
		}
		if (chestMobile != null)
		{
			chestMobile.OnInstantChestOpen += RecheckChest;
		}
	}

	private void CheckChest(Chest chest)
	{
		if (chest == null)
		{
			return;
		}
		chest.Init();
		if (chest.IsUnlocked())
		{
			if (TrophyRenderer != null)
			{
				TrophyRenderer.sprite = chest.popupSprite;
				if (TrophyRenderer.transform.parent != null)
				{
					TrophyRenderer.transform.parent.gameObject.SetActive(true);
				}
			}
			InstantUnlock();
		}
		else
		{
			chest.OnPreChestOpen += Chest_OnPreChestOpen;
		}
	}

	private void RecheckChest(Chest chest)
	{
		if (chest != null && chest.IsUnlocked())
		{
			if (TrophyRenderer != null)
			{
				TrophyRenderer.sprite = chest.popupSprite;
				if (TrophyRenderer.transform.parent != null)
				{
					TrophyRenderer.transform.parent.gameObject.SetActive(true);
				}
			}
			InstantUnlock();
		}
	}

	private void OnEnable()
	{
		RecheckChest(chestMobile);
		RecheckChest(chestPC);
	}

	private void Chest_OnPreChestOpen(Chest chest)
	{
		if (achievement != null)
		{
			achievement.ManualUnlock();
		}
		m_OnPreChestOpen?.Invoke(chest);
	}

	public bool IsUnlocked()
	{
		if (chestPC != null && chestPC.IsUnlocked())
		{
			return true;
		}
		if (chestMobile != null)
		{
			return chestMobile.IsUnlocked();
		}
		return false;
	}

	public void Chest_OnChestOpen(Chest chest)
	{
		if (chest != null && TrophyRenderer != null)
		{
			TrophyRenderer.sprite = chest.popupSprite;
		}
		StartCoroutine(FirstUnlockRoutine());
	}

	public bool HasChest()
	{
		return chestPC != null;
	}

	private IEnumerator FirstUnlockRoutine()
	{
		yield return new WaitForSeconds(0.1f);
		if (anim != null)
		{
			anim.SetTrigger("Unlock");
		}
		yield return new WaitForSeconds(6f);
		if (anim != null)
		{
			anim.enabled = false;
		}
	}

	private void InstantUnlock()
	{
		if (achievement != null)
		{
			achievement.ManualUnlock();
		}
		if (anim != null)
		{
			anim.SetTrigger("InstantUnlock");
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawSphere(base.transform.position + TeleportOffset, 0.25f);
	}
}
