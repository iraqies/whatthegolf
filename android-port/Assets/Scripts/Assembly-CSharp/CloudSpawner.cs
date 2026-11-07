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
	private float parallaxCoefficient;

	private GameObject cloudRotator;

	private Vector3 lastCameraPos;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void SpawnClouds()
	{
	}

	public void CleanUp()
	{
	}
}
