using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Audio;
using Audio.Rumble;
using UnityEngine;

public class Chest : MonoBehaviour
{
	[CompilerGenerated]
	private Action<Chest> m_OnPreChestOpen;

	[CompilerGenerated]
	private Action<Chest> m_OnPostChestOpen;

	[CompilerGenerated]
	private Action<Chest> m_OnInstantChestOpen;

	public Sprite popupSprite;

	public SpriteRenderer ItemSpriteRenderer;

	public float ItemScaleOverride = 0.45f;

	public ClipSettingsCollection sfxOnOpen;

	private OverworldID id;

	private bool didInit;

	private bool isUnlocked;

	private Animator anim;

	public Transform PortalTransform;

	public ParticleSystem PortalParticles;

	private Transform playerBall;

	[SerializeField]
	private RumbleEventAsset rumbleEventAssetChestOpen;

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

	public event Action<Chest> OnInstantChestOpen
	{
		[CompilerGenerated]
		add
		{
			m_OnInstantChestOpen = (Action<Chest>)Delegate.Combine(m_OnInstantChestOpen, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnInstantChestOpen = (Action<Chest>)Delegate.Remove(m_OnInstantChestOpen, value);
		}
	}

	public void Init()
	{
		id = GetComponent<OverworldID>();
		anim = GetComponent<Animator>();
		if (id != null && SaveGame.GetIsChestUnlocked(id.id) && base.gameObject.activeInHierarchy)
		{
			InstantOpen();
		}
		if (ItemSpriteRenderer != null)
		{
			ItemSpriteRenderer.sprite = popupSprite;
			if (ItemSpriteRenderer.transform.parent != null)
			{
				ItemSpriteRenderer.transform.parent.localScale = new Vector3(ItemScaleOverride, ItemScaleOverride, ItemScaleOverride);
			}
		}
		didInit = true;
	}

	public bool IsUnlocked()
	{
		return isUnlocked;
	}

	private void InstantOpen()
	{
		isUnlocked = true;
		StartCoroutine(OpenChestInstantly());
		m_OnInstantChestOpen?.Invoke(this);
	}

	private IEnumerator OpenChestInstantly()
	{
		if (anim != null)
		{
			anim.StartPlayback();
			anim.SetTrigger("InstantOpen");
		}
		yield return new WaitForSeconds(10f);
		if (anim != null)
		{
			anim.enabled = false;
		}
	}

	private IEnumerator OpenChestRoutine()
	{
		if (sfxOnOpen != null && AudioManager.Instance != null)
		{
			sfxOnOpen.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
		}
		if (rumbleEventAssetChestOpen != null)
		{
			rumbleEventAssetChestOpen.Play(0, 1f);
		}
		if (anim != null)
		{
			anim.SetTrigger("Open");
		}
		m_OnPreChestOpen?.Invoke(this);
		yield return new WaitForSecondsRealtime(4f);
		m_OnPostChestOpen?.Invoke(this);
		yield return new WaitForSecondsRealtime(0.5f);
		if (ItemSpriteRenderer != null)
		{
			ItemSpriteRenderer.enabled = false;
		}
		yield return new WaitForSecondsRealtime(3f);
		if (anim != null)
		{
			anim.enabled = false;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (isUnlocked)
		{
			return;
		}
		if (!didInit)
		{
			Init();
		}
		if (collision != null && collision.collider != null && collision.collider.attachedRigidbody != null)
		{
			Rigidbody2D attachedRigidbody = collision.collider.attachedRigidbody;
			if (attachedRigidbody.GetComponent<OverworldBall2D>() != null)
			{
				playerBall = attachedRigidbody.transform;
				StartCoroutine(OpenChestRoutine());
				isUnlocked = true;
				if (id != null)
				{
					SaveGame.SetChestUnlocked(id.id);
				}
				SaveGame.Save(false);
			}
		}
	}
}
