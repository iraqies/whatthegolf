using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TribuneWithSpectators : MonoBehaviour
{
	public List<GameObject> SpectatorPrefabs;

	public Transform SeatContainer;

	public int MinSpectators;

	public int MaxSpectators;

	public bool SpectatorsUsePhysics;

	public Transform PlayerTransform;

	public float ViewDistance;

	public Transform ViewOrigin;

	public float RandomScaleOffset;

	[CompilerGenerated]
	private Action m_OnTribunePopulated;

	private List<Spectator> spectators;

	public event Action OnTribunePopulated
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

	private IEnumerator Start()
	{
		return null;
	}

	public void DoBriefApplause()
	{
	}

	private IEnumerator DoBriefApplauseRoutine(float duration)
	{
		return null;
	}

	private IEnumerator delayedActivation(GameObject go)
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
