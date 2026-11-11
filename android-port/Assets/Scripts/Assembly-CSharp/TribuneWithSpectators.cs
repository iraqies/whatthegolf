using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TribuneWithSpectators : MonoBehaviour
{
	public List<GameObject> SpectatorPrefabs;

	public Transform SeatContainer;

	public int MinSpectators = 1;

	public int MaxSpectators = 10;

	public bool SpectatorsUsePhysics;

	public Transform PlayerTransform;

	public float ViewDistance = 50f;

	public Transform ViewOrigin;

	public float RandomScaleOffset = 0.25f;

	private List<Spectator> spectators = new List<Spectator>();

	public event Action OnTribunePopulated;

	private IEnumerator Start()
	{
		if (SeatContainer == null || SpectatorPrefabs == null || SpectatorPrefabs.Count == 0)
		{
			yield break;
		}
		var seats = new List<Transform>(SeatContainer.childCount);
		foreach (Transform seat in SeatContainer)
		{
			seats.Add(seat);
		}
		int count = Mathf.Min(UnityEngine.Random.Range(MinSpectators, MaxSpectators + 1), SeatContainer.childCount);
		for (int i = 0; i < count; i++)
		{
			if (seats.Count == 0) break;
			Transform seat = seats[UnityEngine.Random.Range(0, seats.Count)];
			seats.Remove(seat);
			GameObject prefab = SpectatorPrefabs[UnityEngine.Random.Range(0, SpectatorPrefabs.Count)];
			if (seat == null || prefab == null) continue;
			GameObject inst = Instantiate(prefab, seat.position, seat.rotation, transform);
			float s = 1f + UnityEngine.Random.Range(-RandomScaleOffset, RandomScaleOffset);
			inst.transform.localScale = new Vector3(s, s, s);
			Spectator spec = inst.GetComponent<Spectator>();
			if (spec != null)
			{
				spec.LookingAt = PlayerTransform;
				spec.ViewDistance = ViewDistance;
				spec.ViewOriginOverride = ViewOrigin != null ? ViewOrigin : transform;
				if (!SpectatorsUsePhysics)
				{
					inst.SetActive(false);
					StartCoroutine(delayedActivation(inst));
				}
				spectators.Add(spec);
			}
		}
		yield return null;
		OnTribunePopulated?.Invoke();
	}

	public void DoBriefApplause()
	{
		StartCoroutine(DoBriefApplauseRoutine(2f));
	}

	private IEnumerator DoBriefApplauseRoutine(float duration)
	{
		if (spectators != null)
		{
			for (int i = 0; i < spectators.Count; i++)
			{
				if (spectators[i] != null && spectators[i].Animator != null)
				{
					spectators[i].Animator.SetTrigger("LevelCompleted");
				}
			}
		}
		yield return new WaitForSeconds(duration);
		if (spectators != null)
		{
			for (int i = 0; i < spectators.Count; i++)
			{
				if (spectators[i] != null && spectators[i].Animator != null)
				{
					spectators[i].Animator.SetTrigger("Reset");
				}
			}
		}
	}

	private IEnumerator delayedActivation(GameObject go)
	{
		yield return null;
		if (go != null)
		{
			go.SetActive(true);
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(transform.position, ViewDistance);
	}
}
