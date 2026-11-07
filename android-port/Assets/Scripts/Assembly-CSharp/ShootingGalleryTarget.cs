using System;
using Audio;
using UnityEngine;

public class ShootingGalleryTarget : MonoBehaviour, IHitscanTarget, IAudioEvent
{
	public bool Hit;

	public bool IsGoal;

	public LayerMask AcceptedHitLayers;

	public Action<Vector3> OnAudioEvent { get; set; }

	public Action<IHitscanTarget> OnHitscanHit
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void OnHit(Vector3 point)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
