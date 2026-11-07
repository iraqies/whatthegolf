using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Audio;
using UnityEngine;

public class ShortcutTunnelEntry : MonoBehaviour
{
	public bool isBlocked;

	public bool isOnlyForExit;

	public bool isOneWayAndItsNotThisOne;

	public float pushAwayForce;

	public float pushAwayTime;

	[NonSerialized]
	public bool canBeUsed;

	public bool isPathReverse;

	public Transform block;

	public ClipSettingsCollection EnterSFX;

	[CompilerGenerated]
	private Action<ShortcutTunnelEntry, ShortcutTunnelTraversable> m_OnEntered;

	private readonly string saveFormat;

	private GridFiller filler;

	private float nextEnterTime;

	public event Action<ShortcutTunnelEntry, ShortcutTunnelTraversable> OnEntered
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

	public IEnumerator Start()
	{
		return null;
	}

	public void UnblockAndSave()
	{
	}

	private IEnumerator PushAway(ShortcutTunnelTraversable thing)
	{
		return null;
	}

	public void EnterTunnel(ShortcutTunnelTraversable thing)
	{
	}
}
