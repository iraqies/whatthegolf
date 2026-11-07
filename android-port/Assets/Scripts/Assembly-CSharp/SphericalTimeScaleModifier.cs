using CameraStack;
using UnityEngine;

public class SphericalTimeScaleModifier : MonoBehaviour
{
	public TimeControl TimeControl;

	public float MinTimeScale;

	private CBFollow followCam;

	public float MinElevation;

	public float MaxRotationAngle;

	public float RotationMoveSpeed;

	private SphereCollider collider;

	private float startElevation;

	private float rotTarget;

	private Transform playerEntered;

	private bool playerHasExit;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Update()
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
