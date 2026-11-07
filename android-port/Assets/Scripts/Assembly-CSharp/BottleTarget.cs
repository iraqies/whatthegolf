using System;
using UnityEngine;
using UnityEngine.Events;

public class BottleTarget : MonoBehaviour, IHitscanTarget
{
	public UnityEvent OnHitUnityEvent;

	public Action<IHitscanTarget> OnHitscanHit { get; set; }

	public void OnHit(Vector3 point)
	{
	}
}
