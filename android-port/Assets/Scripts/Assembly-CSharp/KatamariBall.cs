using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class KatamariBall : MonoBehaviour
{
	public float CurrentSize;

	public float BallCompression = 2f;

	public float GrowthMod = 1f;

	public float ElevationMod = 1.5f;

	public float MinCameraElevation = 20f;

	public float ElevationChangeSpeed = 3f;

	public float RequiredSizeToWin = 300f;

	public float MinShotSpeed = 40f;

	public float ForceMod = 1f;

	public Vector2 ArrowScaleRange = new Vector2(1f, 12f);

	public bool IncreaseMass;

	public bool DestroyCollider;

	[SerializeField]
	private ClipSettingsCollection absorbClip;

	private CBFollow followCam;

	private float targetElevation;

	private float currentElevation;

	private ConstantForce force;

	private GolfBallShooterExperimental shooter;

	private GolfBallController controller;

	private Rigidbody rigidbody;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
		followCam = CameraManager.Instance.gameObject.GetComponent<CBFollow>();
		force = GetComponent<ConstantForce>();
		targetElevation = MinCameraElevation;
		currentElevation = MinCameraElevation;
		shooter = GetComponent<GolfBallShooterExperimental>();
		controller = GetComponent<GolfBallController>();
		controller.OnReset += Controller_OnReset;
	}

	private void Controller_OnReset()
	{
		base.transform.position += Vector3.up * CurrentSize * 0.5f;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == "Collectible" && other.collider.bounds.size.magnitude <= CurrentSize)
		{
			other.transform.position += (base.transform.position - other.transform.position).normalized * other.collider.bounds.extents.magnitude / BallCompression;
			other.transform.SetParent(base.transform, worldPositionStays: true);
			other.transform.tag = "AdditionalGolfThing";
			Object.Destroy(other.rigidbody);
			if (DestroyCollider)
			{
				Collider[] componentsInChildren = other.gameObject.GetComponentsInChildren<Collider>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					Object.Destroy(componentsInChildren[i]);
				}
			}
			CurrentSize += other.collider.bounds.size.magnitude * GrowthMod;
			targetElevation = Mathf.Max(CurrentSize * ElevationMod, MinCameraElevation);
			absorbClip.Play(base.transform.position);
		}
		if (CurrentSize >= RequiredSizeToWin && other.transform.tag == "GolfGoal")
		{
			other.gameObject.GetComponent<GolfGoal>().Complete();
			base.enabled = false;
		}
	}

	private void Update()
	{
		currentElevation = Mathf.MoveTowards(currentElevation, targetElevation, Time.deltaTime * ElevationChangeSpeed);
		if (shooter != null)
		{
			shooter.fullShootVelocity = Mathf.Max(CurrentSize, MinShotSpeed);
		}
		controller.Scale = Mathf.Lerp(ArrowScaleRange.x, ArrowScaleRange.y, CurrentSize / RequiredSizeToWin);
		if (followCam != null)
		{
			followCam.Elevation = currentElevation;
		}
		if (force != null)
		{
			force.force = new Vector3(0f, CurrentSize * ForceMod, 0f);
		}
		if (IncreaseMass)
		{
			rigidbody.mass = CurrentSize;
		}
	}
}
