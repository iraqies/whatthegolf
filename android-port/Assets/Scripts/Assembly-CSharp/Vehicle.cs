using UnityEngine;

public class Vehicle : MonoBehaviour
{
	public bool controllable;

	public Transform vehicleModel;

	public Rigidbody sphere;

	public ParticleSystem smoke;

	public Transform body;

	public float acceleration;

	public float steering;

	public float jumpForce;

	public float gravity;

	public float drift;

	private Transform container;

	private Transform wheelFrontLeft;

	private Transform wheelFrontRight;

	private TrailRenderer trailLeft;

	private TrailRenderer trailRight;

	private float speed;

	private float speedTarget;

	private float rotate;

	private float rotateTarget;

	private bool nearGround;

	private bool onGround;

	private Vector3 containerBase;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void ControlAccelerate()
	{
	}

	public void ControlSteer(int direction)
	{
	}

	public void SetPosition(Vector3 position, Quaternion rotation)
	{
	}
}
