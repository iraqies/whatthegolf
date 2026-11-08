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
	public float pushAwayForce = 5f;
	public float pushAwayTime = 0.25f;
	[NonSerialized] public bool canBeUsed = true;
	public bool isPathReverse;
	public Transform block;
	public ClipSettingsCollection EnterSFX;

	private Action<ShortcutTunnelEntry, ShortcutTunnelTraversable> m_OnEntered;
	private readonly string saveFormat;
	private GridFiller filler;
	private float nextEnterTime;

	public event Action<ShortcutTunnelEntry, ShortcutTunnelTraversable> OnEntered
	{
		add => m_OnEntered = (Action<ShortcutTunnelEntry, ShortcutTunnelTraversable>)Delegate.Combine(m_OnEntered, value);
		remove => m_OnEntered = (Action<ShortcutTunnelEntry, ShortcutTunnelTraversable>)Delegate.Remove(m_OnEntered, value);
	}

	public IEnumerator Start()
	{
		canBeUsed = !isBlocked && !isOnlyForExit;
		yield break;
	}

	public void UnblockAndSave()
	{
		isBlocked = false;
		canBeUsed = true;
		if (block != null) block.gameObject.SetActive(false);
	}

	private IEnumerator PushAway(ShortcutTunnelTraversable thing)
	{
		yield break;
	}

	public void EnterTunnel(ShortcutTunnelTraversable thing)
	{
		if (Time.time < nextEnterTime || isOnlyForExit || isBlocked) return;
		nextEnterTime = Time.time + 0.75f;
		m_OnEntered?.Invoke(this, thing);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null) return;
		var tr = other.GetComponentInParent<ShortcutTunnelTraversable>();
		if (tr != null) EnterTunnel(tr);
	}
}
