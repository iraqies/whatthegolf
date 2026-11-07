using System.Collections.Generic;
using UnityEngine;

public class ParallaxChildren2D : MonoBehaviour
{
	[SerializeField]
	private float parallaxCoefficient;

	public bool UseFixedUpdate;

	private Vector3 lastCameraPos;

	private List<Transform> children;

	private Transform cameraTransform;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void DoParallax()
	{
	}
}
