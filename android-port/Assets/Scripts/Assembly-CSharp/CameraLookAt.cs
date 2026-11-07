using CameraStack;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
	public float lookAtTarget;

	public Transform target;

	private CBFollow cam;

	private float dot;

	private float elev;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
