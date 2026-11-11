using CameraStack;
using Core;
using UnityEngine;

public class SphericalTimeScaleModifier : MonoBehaviour
{
	public TimeControl TimeControl;

	public float MinTimeScale = 0.3f;

	private CBFollow followCam;

	public float MinElevation = 60f;

	public float MaxRotationAngle = 45f;

	public float RotationMoveSpeed = 10f;

	private SphereCollider collider;

	private float startElevation;

	private float rotTarget;

	private Transform playerEntered;

	private bool playerHasExit;

	private void Start()
	{
		collider = GetComponent<SphereCollider>();
		if (CameraManager.Instance != null)
		{
			CameraManager.Instance.OnActiveBehaviourChanged += delegate(CameraBehavior cb)
			{
				followCam = cb as CBFollow;
				if (followCam != null)
				{
					startElevation = followCam.elevation;
				}
			};
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (base.enabled && other != null && other.attachedRigidbody != null && other.attachedRigidbody.gameObject.GetComponent<GolfBallController>() != null)
		{
			playerEntered = other.attachedRigidbody.transform;
		}
	}

	private void Update()
	{
		if ((bool)playerEntered && followCam != null && collider != null)
		{
			float magnitude = (playerEntered.position - collider.bounds.center).magnitude;
			float t = magnitude / collider.radius;
			if (TimeControl != null)
			{
				TimeControl.SetNewAimTimeScale(Mathf.Lerp(MinTimeScale, 1f, t));
			}
			followCam.elevation = Mathf.Lerp(MinElevation, startElevation, t);
			Vector3 vector = new Vector3(playerEntered.position.x - base.transform.position.x, 0f, playerEntered.position.z - base.transform.position.z);
			float t2 = vector.magnitude / collider.radius;
			Camera[] cameras = followCam.Cameras;
			if (cameras != null && cameras.Length != 0 && cameras[0] != null)
			{
				Transform transform = cameras[0].transform;
				Vector3 localEulerAngles = transform.localEulerAngles;
				float a = ((playerEntered.position.z < base.transform.position.z) ? MaxRotationAngle : rotTarget);
				float y = Mathf.Lerp(a, 0f, t2);
				transform.localEulerAngles = Vector3.MoveTowards(localEulerAngles, new Vector3(0f, y, 0f), Time.deltaTime * RotationMoveSpeed);
				if (playerEntered.position.z < base.transform.position.z)
				{
					rotTarget = transform.localEulerAngles.y;
				}
			}
		}
		else if (playerHasExit)
		{
			if (TimeControl != null)
			{
				TimeControl.SetNewAimTimeScale(1f);
			}
			if (followCam != null)
			{
				followCam.elevation = Mathf.MoveTowards(followCam.elevation, startElevation, Time.deltaTime * 10f);
				Camera[] cameras2 = followCam.Cameras;
				if (cameras2 != null && cameras2.Length != 0 && cameras2[0] != null)
				{
					Transform transform2 = cameras2[0].transform;
					transform2.localEulerAngles = Vector3.MoveTowards(transform2.localEulerAngles, Vector3.zero, Time.deltaTime * RotationMoveSpeed);
				}
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other != null && other.attachedRigidbody != null && other.attachedRigidbody.gameObject.GetComponent<GolfBallController>() != null)
		{
			playerHasExit = true;
		}
	}
}
