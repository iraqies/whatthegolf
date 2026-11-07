using System.Collections;
using UnityEngine;

public class SnapToPositionOnGoal : MonoBehaviour
{
	public Transform target;

	public Transform head;

	public float angleRotations;

	public float speed;

	private bool started;

	public ParticleSystem Particles;

	private Quaternion headStart;

	public AnimationCurve animationCurve;

	private void Start()
	{
	}

	public void SnapToPosition()
	{
	}

	private IEnumerator Snap()
	{
		return null;
	}
}
