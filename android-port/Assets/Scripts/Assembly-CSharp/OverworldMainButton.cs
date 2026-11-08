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
	public float travelStartPitch = 0.6f;
	public float travelEndPitch = 1.2f;
	public RumbleEventAsset cableSparkRumble;
	private Collider2D buttonCollider;
	private Coroutine currentBlinkRoutine;
	public float UnlockBlinkRate = 1f;
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
		add => m_OnPressed = (Action<OverworldMainButton>)Delegate.Combine(m_OnPressed, value);
		[CompilerGenerated]
		remove => m_OnPressed = (Action<OverworldMainButton>)Delegate.Remove(m_OnPressed, value);
	}

	public event Action OnInit
	{
		[CompilerGenerated]
		add => m_OnInit = (Action)Delegate.Combine(m_OnInit, value);
		[CompilerGenerated]
		remove => m_OnInit = (Action)Delegate.Remove(m_OnInit, value);
	}

	public event Action<OverworldMainButton> OnEnteredCable
	{
		[CompilerGenerated]
		add => m_OnEnteredCable = (Action<OverworldMainButton>)Delegate.Combine(m_OnEnteredCable, value);
		[CompilerGenerated]
		remove => m_OnEnteredCable = (Action<OverworldMainButton>)Delegate.Remove(m_OnEnteredCable, value);
	}

	public void Init(Tilemap tilemap)
	{
		if (button != null)
			buttonCollider = button.gameObject.GetComponentInParent<Collider2D>();
		if (buttonCollider == null)
			buttonCollider = GetComponentInChildren<Collider2D>();

		if (tilemap != null && !DoNotAlignToGrid)
		{
			Vector3 pos = transform.position;
			Vector3Int cell = tilemap.WorldToCell(pos);
			Vector3 cellWorld = tilemap.CellToWorld(cell);
			transform.position = new Vector3(cellWorld.x + 0.5f, cellWorld.y + 0.5f, pos.z);
		}

		if (cable != null)
			cable.Toggle(false);

		if (doorplate != null && doorplate.isOn)
		{
			isEnabled = true;
			if (cable != null)
				cable.Toggle(true);
			if (currentBlinkRoutine != null)
			{
				StopCoroutine(currentBlinkRoutine);
				currentBlinkRoutine = null;
			}
			if (button != null)
				button.color = OpenColor;
		}

		UpdateStatus();

		if (PreviousDoor != null && !PreviousDoor.openOrOpening)
		{
			PreviousDoor.OnOpen -= PreviousDoor_OnOpen;
			PreviousDoor.OnOpen += PreviousDoor_OnOpen;
		}

		didInit = true;
		m_OnInit?.Invoke();
	}

	private void PreviousDoor_OnOpen()
	{
		UpdateStatus();
	}

	private void UpdateStatus()
	{
		if (!gameObject.activeInHierarchy)
			return;
		bool prevOpen = PreviousDoor == null || PreviousDoor.openOrOpening;
		if (prevOpen && !isEnabled && (doorplate == null || !doorplate.isOn))
		{
			if (currentBlinkRoutine == null)
				currentBlinkRoutine = StartCoroutine(BlinkRoutine());
			if (openIndicator != null)
				openIndicator.SetActive(true);
		}
		if (isEnabled && currentBlinkRoutine != null)
		{
			StopCoroutine(currentBlinkRoutine);
			currentBlinkRoutine = null;
		}
	}

	public void SetBlinking()
	{
		if (currentBlinkRoutine == null)
			currentBlinkRoutine = StartCoroutine(BlinkRoutine());
	}

	private IEnumerator BlinkRoutine()
	{
		float timer = 0f;
		while (!isEnabled)
		{
			timer += Time.deltaTime * Mathf.Max(0.5f, UnlockBlinkRate);
			if (button != null)
				button.color = Color.Lerp(LockedColor, UnlockedColor, Mathf.PingPong(timer, 1f));
			yield return null;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null) return;
		var ball = collision.gameObject.GetComponentInParent<OverworldBall2D>();
		if (ball == null) return;
		if (isEnabled && !isReusable) return;
		if (buttonCollider != null && collision.contacts != null && collision.contacts.Length > 0)
		{
			if (collision.contacts[0].otherCollider != buttonCollider)
				return;
		}
		isEnabled = true;
		if (currentBlinkRoutine != null)
		{
			StopCoroutine(currentBlinkRoutine);
			currentBlinkRoutine = null;
		}
		if (openIndicator != null)
			openIndicator.SetActive(false);
		if (button != null)
			button.color = OpenColor;
		m_OnPressed?.Invoke(this);
	}

	public IEnumerator EnableButtonAndCable(Action<Vector3> OnMove, Action OnCompleted)
	{
		m_OnEnteredCable?.Invoke(this);
		Collider2D bCol = button != null ? button.GetComponentInChildren<Collider2D>() : null;
		if (bCol != null)
			bCol.enabled = false;
		yield return new WaitForSeconds(0.5f);

		Vector3 startPos = button != null ? button.transform.position : transform.position;
		Vector3 downPos = startPos + (button != null ? button.transform.up : transform.up) * 0.3f;
		if (sfxOnButtonClick != null && AudioManager.Instance != null)
			sfxOnButtonClick.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);

		yield return StartCoroutine(pTween.To(0.1f, t =>
		{
			if (button != null)
				button.transform.position = Vector3.Lerp(startPos, downPos, t);
		}));

		if (srcOnCableSparkle != null)
			srcOnCableSparkle.Play();
		if (cable != null)
		{
			cable.OnMoveNormalized = pct =>
			{
				if (srcOnCableSparkle != null)
					srcOnCableSparkle.pitch = Mathf.Lerp(travelStartPitch, travelEndPitch, pct);
			};
			yield return StartCoroutine(cable.SetEnableColorRoutine(OnMove, false));
		}

		if (srcOnCableSparkle != null)
			srcOnCableSparkle.Stop();
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && sfxOnCableEndReached != null)
			AudioManager.Instance.sfx.PlaySimple(sfxOnCableEndReached, 1f, 1f, Vector3.zero);

		if (doorplate != null)
		{
			doorplate.SetState(true, false);
			if (doorplate.SFX_TurnOn != null)
				doorplate.SFX_TurnOn.Play(doorplate.transform.position);
		}

		if (isReusable)
		{
			if (bCol != null)
				bCol.enabled = true;
			if (button != null)
				button.transform.position = startPos;
		}

		OnCompleted?.Invoke();
	}

	public void OnDrawGizmos()
	{
	}
}
