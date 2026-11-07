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

	public float ItemScaleOverride;

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

	public event Action<Chest> OnInstantChestOpen
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

	public bool IsUnlocked()
	{
		return false;
	}

	private void InstantOpen()
	{
	}

	private IEnumerator OpenChestInstantly()
	{
		return null;
	}

	private IEnumerator OpenChestRoutine()
	{
		return null;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
