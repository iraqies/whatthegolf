using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TweenScaleLoop : MonoBehaviour
{
	[SerializeField]
	private Vector3 start;

	[SerializeField]
	private Vector3 end;

	[SerializeField]
	private AnimationCurve animationCurve;

	[SerializeField]
	private float duration;

	[SerializeField]
	private float delay;

	[SerializeField]
	private UnityEvent OnScaleDown;

	[SerializeField]
	private bool StartsUp;

	[SerializeField]
	private UnityEvent OnScaleUp;

	private void Start()
	{
	}

	private IEnumerator ScaleDownCR()
	{
		return null;
	}

	private IEnumerator ScaleUpCR()
	{
		return null;
	}
}
