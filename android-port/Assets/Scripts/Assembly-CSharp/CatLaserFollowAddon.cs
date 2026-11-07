using UnityEngine;

public class CatLaserFollowAddon : MonoBehaviour
{
	public Transform rayTransform;

	public GameObject laserGO;

	public GameObject ballGO;

	public Rigidbody catRb;

	private Vector3 lastBallPos;

	private float laserDefaultY;

	private LineRenderer lineRenderer;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
