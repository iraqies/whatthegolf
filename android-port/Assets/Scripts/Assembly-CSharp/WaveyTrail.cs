using System.Collections;
using UnityEngine;

public class WaveyTrail : MonoBehaviour
{
	public float Speed = 1f;

	public Vector2 MoveRange = new Vector2(-0.1f, 0.1f);

	public Vector3 Axis = new Vector3(1f, 0f, 0f);

	public SHMUPController Player;

	private TrailRenderer trail;

	private Transform cachedTransform;

	private void Start()
	{
		trail = GetComponent<TrailRenderer>();
		if (Player != null)
		{
			Player.OnSinkReset += OnSinkReset;
		}
		cachedTransform = transform;
	}

	private void OnSinkReset()
	{
		if (trail != null)
		{
			trail.Clear();
			trail.emitting = false;
		}
		StartCoroutine(DelayedTrailClear());
	}

	private IEnumerator DelayedTrailClear()
	{
		yield return new WaitForSeconds(0.2f);
		if (trail != null)
		{
			trail.Clear();
			trail.emitting = true;
		}
	}

	private void Update()
	{
		if (cachedTransform == null)
		{
			return;
		}
		float t = Mathf.SmoothStep(MoveRange.x, MoveRange.y, Mathf.PingPong(Time.time * Speed, 1f));
		Vector3 lp = cachedTransform.localPosition;
		cachedTransform.localPosition = new Vector3(
			Mathf.Lerp(lp.x, t, Axis.x),
			Mathf.Lerp(lp.y, t, Axis.y),
			Mathf.Lerp(lp.z, t, Axis.z)
		);
	}
}
