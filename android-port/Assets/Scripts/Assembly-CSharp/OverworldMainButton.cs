using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Audio;
using Audio.Rumble;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OverworldMainButton : MonoBehaviour
{
	[CompilerGenerated]
	private Action<OverworldMainButton> m_OnPressed;

	[CompilerGenerated]
	private Action m_OnInit;

	public GameObject openIndicator;

	public OverworldMainDoorPlate doorplate;

	public bool isEnabled;

	public bool didInit;

	public SpriteRenderer button;

	public OverworldCable cable;

	public OverworldButton2D PreviousDoor;

	public AudioClipSettings sfxOnButtonClick;

	public AudioClip sfxOnCableEndReached;

	public AudioSource srcOnCableSparkle;

	public float travelStartPitch;

	public float travelEndPitch;

	public RumbleEventAsset cableSparkRumble;

	private Collider2D buttonCollider;

	private Coroutine currentBlinkRoutine;

	public float UnlockBlinkRate;

	public Color OpenColor;

	public Color UnlockedColor;

	public Color LockedColor;

	public bool DoNotAlignToGrid;

	[CompilerGenerated]
	private Action<OverworldMainButton> m_OnEnteredCable;

	public bool isReusable;

	[SerializeField]
	private AudioClip m_PS5RumbleHapticsClip;

	public event Action<OverworldMainButton> OnPressed
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

	public event Action OnInit
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

	public event Action<OverworldMainButton> OnEnteredCable
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

	public void Init(Tilemap tilemap)
	{
	}

	private void PreviousDoor_OnOpen()
	{
	}

	private void UpdateStatus()
	{
	}

	public void SetBlinking()
	{
	}

	private IEnumerator BlinkRoutine()
	{
		return null;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	public IEnumerator EnableButtonAndCable(Action<Vector3> OnMove, Action OnCompleted)
	{
		return null;
	}

	public void OnDrawGizmos()
	{
	}
}
