using Cinemachine;
using Core;
using UnityEngine;

public class AttachToLawnMover : MonoBehaviour
{
	public GolfBallController Controller;

	public GameObject FakeVike;

	public CinemachineDollyCart Dolly;

	public float DollyMaxSpeed;

	public Animator CameraController;

	public Animator LawnMoverSequenceAnimator;

	private bool hasAttached;

	private void OnTriggerEnter(Collider other)
	{
	}
}
