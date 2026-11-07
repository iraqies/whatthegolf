using System.Collections;
using CameraStack;
using Core;
using UnityEngine;

public class CrabDancePhase : MonoBehaviour
{
	public Rigidbody crabRigidbody;

	public GolfBallController controller;

	public Transform crabHead;

	public float endElevation;

	public float time;

	public void StartDanceRoutine()
	{
	}

	private IEnumerator DanceRoutine(CBFollow follow)
	{
		return null;
	}
}
