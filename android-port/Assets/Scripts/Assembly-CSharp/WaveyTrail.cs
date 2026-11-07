using System.Collections;
using UnityEngine;

public class WaveyTrail : MonoBehaviour
{
	public float Speed;

	public Vector2 MoveRange;

	public Vector3 Axis;

	public SHMUPController Player;

	private TrailRenderer trail;

	private Transform cachedTransform;

	private void Start()
	{
	}

	private void OnSinkReset()
	{
	}

	private IEnumerator DelayedTrailClear()
	{
		return null;
	}

	private void Update()
	{
	}
}
