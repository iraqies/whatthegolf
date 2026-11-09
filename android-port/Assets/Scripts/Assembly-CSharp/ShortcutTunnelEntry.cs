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
	private readonly string saveFormat = "TUNNEL_UNBLOCKED_{0}";
	private GridFiller filler;
	private float nextEnterTime;

	public event Action<ShortcutTunnelEntry, ShortcutTunnelTraversable> OnEntered
	{
		add => m_OnEntered = (Action<ShortcutTunnelEntry, ShortcutTunnelTraversable>)Delegate.Combine(m_OnEntered, value);
		remove => m_OnEntered = (Action<ShortcutTunnelEntry, ShortcutTunnelTraversable>)Delegate.Remove(m_OnEntered, value);
	}

	public IEnumerator Start()
	{
		yield return null;
		filler = GetComponentInParent<GridFiller>() ?? FindObjectOfType<GridFiller>();
		var tmap = filler != null ? (filler.currentGroundMap ?? filler.groundMap) : null;
		if (isBlocked && tmap != null)
		{
			Vector3Int cell = tmap.WorldToCell(transform.position);
			string key = string.Format(saveFormat, cell);
			if (SaveGame.GetValue(key, false))
			{
				isBlocked = false;
				if (block != null)
					block.gameObject.SetActive(false);
			}
		}
		canBeUsed = !isBlocked && !isOnlyForExit;
	}

	public void UnblockAndSave()
	{
		if (isBlocked)
		{
			var tmap = filler != null ? (filler.currentGroundMap ?? filler.groundMap) : null;
			if (tmap != null)
			{
				Vector3Int cell = tmap.WorldToCell(transform.position);
				string key = string.Format(saveFormat, cell);
				SaveGame.SetValue(key, true, false);
				SaveGame.Save(false);
			}
			isBlocked = false;
			if (block != null)
				block.gameObject.SetActive(false);
		}
		canBeUsed = true;
	}

	private IEnumerator PushAway(ShortcutTunnelTraversable thing)
	{
		if (thing == null) yield break;
		var rb = thing.GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			Vector2 dir = ((Vector2)(thing.transform.position - transform.position)).normalized;
			if (dir.sqrMagnitude < 1e-4f) dir = Vector2.down;
			rb.velocity = dir * pushAwayForce;
		}
		yield return new WaitForSeconds(pushAwayTime);
	}

	public void EnterTunnel(ShortcutTunnelTraversable thing)
	{
		if (isOnlyForExit || Time.time <= nextEnterTime) return;
		nextEnterTime = Time.time + 0.1f + pushAwayTime;
		if (EnterSFX != null && AudioManager.Instance != null)
			EnterSFX.Play(AudioManager.Instance.shortEffects, transform.position, 0f);
		if (isOneWayAndItsNotThisOne || isBlocked)
		{
			StartCoroutine(PushAway(thing));
			return;
		}
		if (!canBeUsed) return;
		m_OnEntered?.Invoke(this, thing);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null) return;
		var tr = other.GetComponentInParent<ShortcutTunnelTraversable>();
		if (tr != null) EnterTunnel(tr);
	}
}
