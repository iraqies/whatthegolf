using System.Collections;
using CameraStack;
using Core;
using UnityEngine;

public class MiniGolfCourseSwitchGoal : MonoBehaviour
{
	public float Delay;

	public string HitText;

	public Transform NextHolePosition;

	public GolfBallController Controller;

	private Transform cameraFollow;

	private CBFollow follow;

	private bool transitionStarted;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private IEnumerator WaitForGoal()
	{
		return null;
	}
}
