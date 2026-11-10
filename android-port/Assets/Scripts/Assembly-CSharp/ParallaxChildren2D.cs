using System.Collections.Generic;
using CameraStack;
using UnityEngine;

public class ParallaxChildren2D : MonoBehaviour
{
	[SerializeField]
	private float parallaxCoefficient = 0.1f;

	public bool UseFixedUpdate;

	private Vector3 lastCameraPos;

	private List<Transform> children;

	private Transform cameraTransform;

	private void Awake()
	{
		children = new List<Transform>();
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform ch = transform.GetChild(i);
			if (ch != null)
			{
				children.Add(ch);
			}
		}
		if (OverworldCamera.Instance != null)
		{
			cameraTransform = OverworldCamera.Instance.transform;
		}
		else if (Camera.main != null)
		{
			cameraTransform = Camera.main.transform;
		}
		if (cameraTransform != null)
		{
			lastCameraPos = cameraTransform.position;
		}
	}

	private void LateUpdate()
	{
		if (!UseFixedUpdate)
		{
			DoParallax();
		}
	}

	private void FixedUpdate()
	{
		if (UseFixedUpdate)
		{
			DoParallax();
		}
	}

	private void DoParallax()
	{
		if (cameraTransform == null)
		{
			if (OverworldCamera.Instance != null)
			{
				cameraTransform = OverworldCamera.Instance.transform;
			}
			else if (Camera.main != null)
			{
				cameraTransform = Camera.main.transform;
			}
			if (cameraTransform != null)
			{
				lastCameraPos = cameraTransform.position;
			}
			return;
		}
		Vector3 delta = cameraTransform.position - lastCameraPos;
		delta.z = 0f;
		if (delta.sqrMagnitude > 1e-6f && children != null)
		{
			Vector3 offset = delta * parallaxCoefficient;
			for (int i = 0; i < children.Count; i++)
			{
				if (children[i] != null)
				{
					children[i].position += offset;
				}
			}
		}
		lastCameraPos = cameraTransform.position;
	}
}
