using CameraStack;
using Core;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
	[SerializeField]
	private Transform RotateAroundPoint;

	[SerializeField]
	public float height;

	[SerializeField]
	public float width;

	[SerializeField]
	public float depth;

	[SerializeField]
	private int startClouds;

	[SerializeField]
	private Transform CloudTemplates;

	[SerializeField]
	private Transform CloudContainer;

	[SerializeField]
	private bool cloudsLookAtPlayer;

	[SerializeField]
	private float parallaxCoefficient = 0.5f;

	private GameObject cloudRotator;

	private Vector3 lastCameraPos;

	private void Start()
	{
		if (CloudContainer != null && CloudContainer.childCount == 0)
		{
			CleanUp();
			SpawnClouds();
		}
		if (parallaxCoefficient == 0f && CloudContainer != null)
		{
			CloudContainer.gameObject.isStatic = true;
		}
	}

	private void LateUpdate()
	{
		if (parallaxCoefficient <= 0f)
		{
			return;
		}
		if (CameraManager.Instance == null || CameraManager.Instance.MainCamera == null || !CameraManager.Instance.MainCamera.orthographic)
		{
			return;
		}
		if (lastCameraPos == Vector3.zero)
		{
			lastCameraPos = CameraManager.Instance.transform.position;
		}
		if (CloudContainer != null)
		{
			Vector3 camPos = CameraManager.Instance.transform.position;
			Vector3 delta = (lastCameraPos - camPos) * parallaxCoefficient;
			CloudContainer.transform.position -= delta;
			lastCameraPos = camPos;
		}
	}

	public void SpawnClouds()
	{
		CleanUp();
		if (CloudTemplates == null || CloudTemplates.childCount == 0 || startClouds < 1)
		{
			return;
		}
		if (RotateAroundPoint != null)
		{
			cloudRotator = new GameObject("CloudRotator");
			cloudRotator.transform.position = RotateAroundPoint.position;
			cloudRotator.transform.SetParent(CloudContainer);
		}
		for (int i = 0; i < startClouds; i++)
		{
			int childIndex = Random.Range(0, CloudTemplates.childCount);
			GameObject template = CloudTemplates.GetChild(childIndex).gameObject;
			GameObject cloud = Object.Instantiate(template, CloudContainer);
			float x = Mathf.Lerp(width * -0.5f, width * 0.5f, Random.value);
			float y = Random.Range(height * -0.5f, height * 0.5f);
			float z = Random.Range(depth * -0.5f, depth * 0.5f);
			cloud.transform.localPosition = new Vector3(x, y, z);
			if (cloudsLookAtPlayer && Level.Instance != null && Level.Instance.Ball != null)
			{
				cloud.transform.LookAt(Level.Instance.Ball.transform);
			}
			else
			{
				cloud.transform.localRotation = Quaternion.identity;
			}
			cloud.SetActive(true);
			if (RotateAroundPoint != null && cloudRotator != null)
			{
				cloud.transform.RotateAround(RotateAroundPoint.position, base.transform.up, Random.Range(0, 360));
				cloud.transform.SetParent(cloudRotator.transform);
			}
		}
	}

	public void CleanUp()
	{
		if (CloudContainer == null || CloudContainer.childCount < 1)
		{
			return;
		}
		for (int i = CloudContainer.childCount - 1; i >= 0; i--)
		{
			GameObject child = CloudContainer.GetChild(i).gameObject;
			if (!Application.isPlaying && Application.isEditor)
			{
				Object.DestroyImmediate(child);
			}
			else
			{
				Object.Destroy(child);
			}
		}
	}
}
