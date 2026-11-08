using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Audio;
using Audio.Rumble;
using UnityEngine;

public class ShortcutTunnel : MonoBehaviour
{
	private Action<ShortcutTunnel> m_OnBallEnterTunnel;
	private Action<ShortcutTunnel> m_OnBallExitTunnel;
	private Action<float> m_OnMovementUpdate;

	public Transform pathContainer;
	public bool useCameraBlend = true;
	public float speed = 15f;
	public float shootoutSpeed = 12f;
	public float shootOutOffset = 0.8f;
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
		add => m_OnBallEnterTunnel = (Action<ShortcutTunnel>)Delegate.Combine(m_OnBallEnterTunnel, value);
		remove => m_OnBallEnterTunnel = (Action<ShortcutTunnel>)Delegate.Remove(m_OnBallEnterTunnel, value);
	}

	public event Action<ShortcutTunnel> OnBallExitTunnel
	{
		add => m_OnBallExitTunnel = (Action<ShortcutTunnel>)Delegate.Combine(m_OnBallExitTunnel, value);
		remove => m_OnBallExitTunnel = (Action<ShortcutTunnel>)Delegate.Remove(m_OnBallExitTunnel, value);
	}

	public event Action<float> OnMovementUpdate
	{
		add => m_OnMovementUpdate = (Action<float>)Delegate.Combine(m_OnMovementUpdate, value);
		remove => m_OnMovementUpdate = (Action<float>)Delegate.Remove(m_OnMovementUpdate, value);
	}

	public void Start()
	{
		entries = GetComponentsInChildren<ShortcutTunnelEntry>(true);
		if (entries != null)
		{
			foreach (var e in entries)
			{
				if (e != null)
				{
					e.OnEntered -= Entry_OnEntered;
					e.OnEntered += Entry_OnEntered;
				}
			}
		}
	}

	public void Pause() => isPaused = true;
	public void Resume() => isPaused = false;

	private void Entry_OnEntered(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
		if (!isTraveling && thing != null)
			movementRoutine = StartCoroutine(TraverseTunnelRoutine(entry, thing));
	}

	private void OnDisable() => KillTravel();

	public void KillTravel()
	{
		if (movementRoutine != null) StopCoroutine(movementRoutine);
		isTraveling = false;
	}

	private IEnumerator TraverseTunnelRoutine(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
		isTraveling = true;
		lastThing = thing;
		m_OnBallEnterTunnel?.Invoke(this);
		if (pathContainer != null && pathContainer.childCount > 0)
		{
			int count = pathContainer.childCount;
			bool rev = entry != null && entry.isPathReverse;
			for (int i = 0; i < count; i++)
			{
				int idx = rev ? (count - 1 - i) : i;
				Transform wp = pathContainer.GetChild(idx);
				if (wp == null) continue;
				while (Vector2.Distance(thing.transform.position, wp.position) > 0.15f)
				{
					if (!isPaused)
						thing.transform.position = Vector3.MoveTowards(thing.transform.position, wp.position, Mathf.Max(8f, speed) * Time.deltaTime);
					yield return null;
				}
			}
		}
		m_OnBallExitTunnel?.Invoke(this);
		isTraveling = false;
	}
}
