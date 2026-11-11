using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class KatamariBallSnake : MonoBehaviour
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

	public GameObject SphereCollider;

	public PlayAudioClipSetting audioClipSetting;

	public Material snakeMaterial;

	public List<Transform> points;

	public AnimationCurve swallowedObjectMovement;

	public float MoveSpeed;

	public float targetScale;

	public float timeToLerp = 0.25f;

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
		if (other.transform.tag == "Collectible")
		{
			List<MeshRenderer> list = new List<MeshRenderer>(other.transform.GetComponentInParent<Rigidbody>().transform.GetComponentsInChildren<MeshRenderer>());
			for (int i = 0; i < list.Count; i++)
			{
				Material[] array = new Material[list[i].materials.Length];
				for (int j = 0; j < list[i].materials.Length; j++)
				{
					array[j] = snakeMaterial;
				}
				list[i].materials = array;
			}
			if (other.collider.bounds.size.magnitude <= CurrentSize)
			{
				audioClipSetting.Play();
				currentObjectToMove = other.gameObject;
				StartCoroutine(MoveObjectInSnake(other.gameObject));
				other.transform.SetParent(base.transform, worldPositionStays: true);
				other.transform.tag = "AdditionalGolfThing";
				Object.Destroy(other.rigidbody);
				if (DestroyCollider)
				{
					Collider[] componentsInChildren = other.gameObject.GetComponentsInChildren<Collider>();
					for (int k = 0; k < componentsInChildren.Length; k++)
					{
						Object.Destroy(componentsInChildren[k]);
					}
				}
				CurrentSize += other.collider.bounds.size.magnitude * GrowthMod;
				targetElevation = Mathf.Max(CurrentSize * ElevationMod, MinCameraElevation);
				absorbClip.Play(base.transform.position);
			}
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

	private IEnumerator MoveObjectInSnake(GameObject otherObject)
	{
		float time = 0f;
		float duration = 1f;
		int rand = Random.Range(3, points.Count - 1);
		while (time < duration)
		{
			otherObject.transform.position = Vector3.Lerp(points[0].position, points[rand].position, Mathf.Clamp01(swallowedObjectMovement.Evaluate(time / duration)));
			time += Time.deltaTime;
			yield return null;
		}
		otherObject.transform.position = points[rand].position;
		yield return null;
	}
}
