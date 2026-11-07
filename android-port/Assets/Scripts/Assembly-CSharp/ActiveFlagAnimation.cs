using UnityEngine;

public class ActiveFlagAnimation : MonoBehaviour
{
	[SerializeField]
	private float minScale;

	[SerializeField]
	private float maxScale;

	[SerializeField]
	private float frequency;

	[SerializeField]
	private AnimationCurve scaleCurve;

	private float t;

	private Transform cachedTransform;

	private float startTime;

	private float delayedStartTime;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
