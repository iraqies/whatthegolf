using Core;
using UnityEngine;

public class ClearTrailOnOutOfBounds : MonoBehaviour
{
	private TrailRenderer trail;

	private void Awake()
	{
		trail = GetComponent<TrailRenderer>();
		if (Level.HasInstance)
			Level.Instance.OnReset += OnReset;
		GolfBallController gbc = GetComponent<GolfBallController>();
		if (gbc != null)
			gbc.OnReset += OnReset;
	}

	private void OnReset()
	{
		if (trail != null)
			trail.Clear();
	}
}
