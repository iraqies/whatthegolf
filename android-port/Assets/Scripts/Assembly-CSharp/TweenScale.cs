using UnityEngine;

public class TweenScale : MonoBehaviour
{
	[SerializeField]
	private GameObject totween;

	[SerializeField]
	private Vector3 from;

	[SerializeField]
	private Vector3 to;

	[SerializeField]
	private AnimationCurve animationCurve;

	[SerializeField]
	private float duration;

	[SerializeField]
	private bool StartOnAwake;

	private void Start()
	{
	}

	public void Scale()
	{
	}
}
