using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Audio;
using Audio.Rumble;
using Menu;
using UnityEngine;

public class ShortcutTunnel : MonoBehaviour
{
	private Action<ShortcutTunnel> m_OnBallEnterTunnel;
	private Action<ShortcutTunnel> m_OnBallExitTunnel;
	private Action<float> m_OnMovementUpdate;

	public Transform pathContainer;
	public bool useCameraBlend = true;
	public float speed = 1f;
	public float shootoutSpeed = 1f;
	public float shootOutOffset = 0.1f;
	public RandomAudioClips clips;
	public RandomAudioClips tunnelHitClips;
	public RumbleEventAsset rumbleOnCorner;

	private ShortcutTunnelEntry[] entries;
	private Coroutine movementRoutine;
	private bool isTraveling;
	private ShortcutTunnelTraversable lastThing;
	private bool isPaused;

	public event Action<ShortcutTunnel> OnBallEnterTunnel
	{
		[CompilerGenerated]
		add => m_OnBallEnterTunnel = (Action<ShortcutTunnel>)Delegate.Combine(m_OnBallEnterTunnel, value);
		[CompilerGenerated]
		remove => m_OnBallEnterTunnel = (Action<ShortcutTunnel>)Delegate.Remove(m_OnBallEnterTunnel, value);
	}

	public event Action<ShortcutTunnel> OnBallExitTunnel
	{
		[CompilerGenerated]
		add => m_OnBallExitTunnel = (Action<ShortcutTunnel>)Delegate.Combine(m_OnBallExitTunnel, value);
		[CompilerGenerated]
		remove => m_OnBallExitTunnel = (Action<ShortcutTunnel>)Delegate.Remove(m_OnBallExitTunnel, value);
	}

	public event Action<float> OnMovementUpdate
	{
		[CompilerGenerated]
		add => m_OnMovementUpdate = (Action<float>)Delegate.Combine(m_OnMovementUpdate, value);
		[CompilerGenerated]
		remove => m_OnMovementUpdate = (Action<float>)Delegate.Remove(m_OnMovementUpdate, value);
	}

	public void Start()
	{
		entries = GetComponentsInChildren<ShortcutTunnelEntry>(true);
		if (entries != null)
		{
			for (int i = 0; i < entries.Length; i++)
			{
				if (entries[i] != null)
				{
					entries[i].OnEntered -= Entry_OnEntered;
					entries[i].OnEntered += Entry_OnEntered;
				}
			}
		}
	}

	public void Pause() => isPaused = true;
	public void Resume() => isPaused = false;

	private void Entry_OnEntered(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
		if (thing == null || isTraveling) return;
		isPaused = false;
		movementRoutine = StartCoroutine(TraverseTunnelRoutine(entry, thing));
	}

	private void OnDisable()
	{
		if (movementRoutine != null && isTraveling)
			KillTravel();
	}

	public void KillTravel()
	{
		if (lastThing != null)
		{
			lastThing.EndTravel(Vector3.zero, 0f);
			m_OnBallExitTunnel?.Invoke(this);
			if (entries != null)
			{
				for (int i = 0; i < entries.Length; i++)
				{
					if (entries[i] != null)
					{
						entries[i].UnblockAndSave();
						entries[i].canBeUsed = true;
					}
				}
			}
			lastThing.nextTravelTime = Time.time + 0.2f;
		}
		isTraveling = false;
		if (movementRoutine != null)
			StopCoroutine(movementRoutine);
	}

	private IEnumerator TraverseTunnelRoutine(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
		thing.nextTravelTime = Time.time + 20f;
		var ball2d = thing.GetComponent<OverworldBall2D>();
		if (ball2d != null)
		{
			m_OnBallEnterTunnel?.Invoke(this);
			if (ball2d.Controller != null)
			{
				ball2d.Controller.CancelShooting();
				ball2d.Controller.enabled = false;
			}
			ball2d.Hide();
			if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.UI != null)
				OverworldManager2d.Instance.UI.DisableUI();
		}

		lastThing = thing;
		isTraveling = true;
		thing.StartTravel();

		Vector3 startThingPos = thing.transform.position;
		Vector3 currentPos = entry != null ? entry.transform.position : startThingPos;
		Vector3 lastDir = Vector3.zero;
		float moveSpeed = (speed > 0.01f ? speed : 1f) * 50f;
		float lastSfxTime = 0f;

		bool rev = entry != null && entry.isPathReverse;
		int count = pathContainer != null ? pathContainer.childCount : 0;
		float totalDist = 0f;
		if (count > 0)
		{
			Transform firstWp = pathContainer.GetChild(rev ? (count - 1) : 0);
			if (firstWp != null)
				totalDist = Vector2.Distance(startThingPos, firstWp.position);
			for (int i = 1; i < count; i++)
			{
				Transform a = pathContainer.GetChild(i - 1);
				Transform b = pathContainer.GetChild(i);
				if (a != null && b != null)
					totalDist += Vector2.Distance(a.position, b.position);
			}
		}

		float traveledDist = 0f;
		for (int i = 0; i < count; i++)
		{
			if (Time.time > lastSfxTime + 0.08f)
			{
				if (clips != null) clips.PlayRandomClip(thing.transform);
				if (tunnelHitClips != null) tunnelHitClips.PlayRandomClip(thing.transform);
				if (rumbleOnCorner != null) rumbleOnCorner.Play(0, 1f);
				lastSfxTime = Time.time;
			}

			int idx = rev ? (count - 1 - i) : i;
			Transform wp = pathContainer.GetChild(idx);
			if (wp == null) continue;

			Vector3 targetPos = new Vector3(wp.position.x, wp.position.y, startThingPos.z);
			Vector3 segDiff = targetPos - currentPos;
			if (segDiff.sqrMagnitude > 1e-4f)
				lastDir = segDiff.normalized;

			float segDist = Vector3.Distance(targetPos, currentPos);
			float segDuration = segDist / Mathf.Max(5f, moveSpeed);
			float segStartTime = Time.realtimeSinceStartup;
			float segEndTime = segStartTime + segDuration;

			while (Time.realtimeSinceStartup < segEndTime)
			{
				if (lastThing == null)
					yield break;
				if (isPaused)
				{
					segEndTime += Time.unscaledDeltaTime;
					segStartTime += Time.unscaledDeltaTime;
				}
				else
				{
					float t = segDuration > 1e-4f ? Mathf.Clamp01((Time.realtimeSinceStartup - segStartTime) / segDuration) : 1f;
					Vector3 nextPos = Vector3.Lerp(currentPos, targetPos, t);
					traveledDist += Vector2.Distance(nextPos, thing.transform.position);
					thing.transform.position = nextPos;
					if (m_OnMovementUpdate != null)
						m_OnMovementUpdate.Invoke(Mathf.Max(0f, totalDist - traveledDist) / Mathf.Max(5f, moveSpeed));
				}
				yield return null;
			}
			currentPos = targetPos;
			thing.transform.position = currentPos;
		}

		if (entries != null)
		{
			for (int i = 0; i < entries.Length; i++)
			{
				if (entries[i] != null)
					entries[i].canBeUsed = false;
			}
		}

		if (lastDir.sqrMagnitude < 1e-4f)
			lastDir = Vector3.up;

		thing.transform.position = currentPos + lastDir * shootOutOffset;
		if (ball2d != null)
		{
			ball2d.gameObject.SetActive(true);
			ball2d.Show();
		}
		thing.EndTravel(lastDir, shootoutSpeed > 0.01f ? shootoutSpeed : 1f);

		if (entries != null)
		{
			for (int i = 0; i < entries.Length; i++)
			{
				if (entries[i] != null)
					entries[i].UnblockAndSave();
			}
		}

		yield return new WaitForSeconds(0.15f);

		if (entries != null)
		{
			for (int i = 0; i < entries.Length; i++)
			{
				if (entries[i] != null)
					entries[i].canBeUsed = true;
			}
		}

		if (ball2d != null)
		{
			if (!Menu.Menu.Exists || Menu.Menu.Instance == null || !Menu.Menu.Instance.IsOpen())
			{
				if (ball2d.Controller != null)
				{
					ball2d.Controller.CancelShooting();
					ball2d.Controller.enabled = true;
				}
				if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.UI != null)
					OverworldManager2d.Instance.UI.EnableUI();
			}
			m_OnBallExitTunnel?.Invoke(this);
		}

		isTraveling = false;
		thing.nextTravelTime = Time.time + 0.2f;
	}
}
