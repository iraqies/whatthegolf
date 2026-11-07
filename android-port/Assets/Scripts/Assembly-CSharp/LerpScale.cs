using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class LerpScale : MonoBehaviour
{
	public GameObject objectToScale;

	public float scaleMultiplier;

	private float timeToLerp;

	private float scaleModifier;

	public float scaleSpeed;

	public bool startOnAwake;

	public AnimationCurve animationCurve;

	public UnityEvent OnScaled;

	private void Start()
	{
	}

	public void Scale()
	{
	}

	private IEnumerator StartScaling(float endValue, float duration)
	{
		return null;
	}
}
