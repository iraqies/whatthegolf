using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class KatamariBallSnake : MonoBehaviour
{
	public float CurrentSize = 1f;

	public float BallCompression = 0.5f;

	public float GrowthMod = 0.1f;

	public float ElevationMod = 1f;

	public float MinCameraElevation = 5f;

	public float ElevationChangeSpeed = 5f;

	public float RequiredSizeToWin = 10f;

	public float MinShotSpeed = 10f;

	public float ForceMod = -10f;

	public Vector2 ArrowScaleRange = new Vector2(1f, 3f);

	public bool IncreaseMass = true;

	public bool DestroyCollider = true;

	public GameObject SphereCollider;

	public PlayAudioClipSetting audioClipSetting;

	public Material snakeMaterial;

	public List<Transform> points;

	public AnimationCurve swallowedObjectMovement = AnimationCurve.Linear(0f, 0f, 1f, 1f);

	public float MoveSpeed = 5f;

	public float targetScale = 1f;

	public float timeToLerp = 0.5f;

	private GameObject currentObjectToMove;

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
		if (CameraManager.Instance != null)
		{
			followCam = CameraManager.Instance.gameObject.GetComponent<CBFollow>();
		}
		force = GetComponent<ConstantForce>();
		targetElevation = MinCameraElevation;
		currentElevation = MinCameraElevation;
		shooter = GetComponent<GolfBallShooterExperimental>();
		controller = GetComponent<GolfBallController>();
		if (controller != null)
		{
			controller.OnReset += Controller_OnReset;
		}
	}

	private void Controller_OnReset()
	{
		transform.position += Vector3.up * CurrentSize;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.transform == null || other.collider == null)
		{
			return;
		}
		if (!other.transform.CompareTag("Obstacle"))
		{
			return;
		}
		float objSize = other.collider.bounds.size.magnitude;
		if (objSize > CurrentSize * 1.5f)
		{
			return;
		}
		if (snakeMaterial != null)
		{
			Renderer[] rends = other.transform.GetComponentsInChildren<Renderer>();
			if (rends != null)
			{
				for (int i = 0; i < rends.Length; i++)
				{
					if (rends[i] == null)
					{
						continue;
					}
					Material[] mats = rends[i].materials;
					for (int j = 0; j < mats.Length; j++)
					{
						mats[j] = snakeMaterial;
					}
					rends[i].materials = mats;
				}
			}
		}
		if (audioClipSetting != null)
		{
			audioClipSetting.Play();
		}
		if (absorbClip != null)
		{
			absorbClip.Play(null, transform.position, 1f, 1f);
		}
		currentObjectToMove = other.gameObject;
		StartCoroutine(MoveObjectInSnake(other.gameObject));
		other.transform.SetParent(transform, true);
		other.transform.tag = "Untagged";
		if (other.rigidbody != null)
		{
			Object.Destroy(other.rigidbody);
		}
		if (DestroyCollider)
		{
			Collider[] cols = other.gameObject.GetComponentsInChildren<Collider>();
			if (cols != null)
			{
				for (int i = 0; i < cols.Length; i++)
				{
					if (cols[i] != null)
					{
						Object.Destroy(cols[i]);
					}
				}
			}
		}
		CurrentSize += objSize * GrowthMod;
		targetElevation = Mathf.Max(MinCameraElevation, CurrentSize * ElevationMod);
	}

	private void Update()
	{
		currentElevation = Mathf.MoveTowards(currentElevation, targetElevation, Time.deltaTime * ElevationChangeSpeed);
		if (shooter != null)
		{
			shooter.fullShootVelocity = Mathf.Max(MinShotSpeed, CurrentSize * 2f);
		}
		if (controller != null)
		{
			controller.Scale = Mathf.Lerp(ArrowScaleRange.x, ArrowScaleRange.y, CurrentSize / Mathf.Max(0.01f, RequiredSizeToWin));
		}
		if (followCam != null)
		{
			followCam.Elevation = currentElevation;
		}
		if (force != null)
		{
			force.force = new Vector3(0f, CurrentSize * ForceMod, 0f);
		}
		if (IncreaseMass && rigidbody != null)
		{
			rigidbody.mass = CurrentSize;
		}
	}

	private IEnumerator MoveObjectInSnake(GameObject otherObject)
	{
		if (otherObject == null || points == null || points.Count == 0)
		{
			yield break;
		}
		Transform targetPt = points[Random.Range(0, points.Count)];
		if (targetPt == null)
		{
			yield break;
		}
		float elapsed = 0f;
		float dur = Mathf.Max(0.1f, timeToLerp);
		Vector3 startPos = otherObject.transform.position;
		while (elapsed < dur && otherObject != null && targetPt != null)
		{
			elapsed += Time.deltaTime;
			float t = Mathf.Clamp01(elapsed / dur);
			float eval = swallowedObjectMovement != null && swallowedObjectMovement.length > 0 ? Mathf.Clamp01(swallowedObjectMovement.Evaluate(t)) : t;
			otherObject.transform.position = Vector3.Lerp(startPos, targetPt.position, eval);
			yield return null;
		}
		if (otherObject != null && targetPt != null)
		{
			otherObject.transform.position = targetPt.position;
		}
	}
}
