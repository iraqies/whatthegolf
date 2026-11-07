using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Audio;
using Audio.Rumble;
using UnityEngine;

public class ShortcutTunnel : MonoBehaviour
{
	[CompilerGenerated]
	private Action<ShortcutTunnel> m_OnBallEnterTunnel;

	[CompilerGenerated]
	private Action<ShortcutTunnel> m_OnBallExitTunnel;

	[CompilerGenerated]
	private Action<float> m_OnMovementUpdate;

	public Transform pathContainer;

	public bool useCameraBlend;

	public float speed;

	public float shootoutSpeed;

	public float shootOutOffset;

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
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ShortcutTunnel> OnBallExitTunnel
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

	public event Action<float> OnMovementUpdate
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

	public void Start()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	private void Entry_OnEntered(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
	}

	private void OnDisable()
	{
	}

	public void KillTravel()
	{
	}

	private IEnumerator TraverseTunnelRoutine(ShortcutTunnelEntry entry, ShortcutTunnelTraversable thing)
	{
		return null;
	}
}
