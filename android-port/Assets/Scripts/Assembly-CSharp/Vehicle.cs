using UnityEngine;

public class Vehicle : MonoBehaviour
{
	public bool controllable = true;

	public Transform vehicleModel;

	public Rigidbody sphere;

	public ParticleSystem smoke;

	public Transform body;

	public float acceleration = 30f;

	public float steering = 80f;

	public float jumpForce = 60f;

	public float gravity = 10f;

	public float drift = 1f;

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
		if (vehicleModel != null && vehicleModel.childCount > 0)
		{
			container = vehicleModel.GetChild(0);
			if (container != null)
			{
				containerBase = container.localPosition;
			}
		}
	}

	private void Update()
	{
		speedTarget = Mathf.SmoothStep(speedTarget, speed, Time.deltaTime * 12f);
		speed = 0f;
		rotateTarget = Mathf.Lerp(rotateTarget, rotate, Time.deltaTime * 4f);
		rotate = 0f;
		base.transform.rotation = Quaternion.Slerp(base.transform.rotation, Quaternion.Euler(new Vector3(0f, base.transform.eulerAngles.y + rotateTarget, 0f)), Time.deltaTime * 2f);
		if (wheelFrontLeft != null)
		{
			wheelFrontLeft.localRotation = Quaternion.Euler(0f, rotateTarget * 0.5f, 0f);
		}
		if (wheelFrontRight != null)
		{
			wheelFrontRight.localRotation = Quaternion.Euler(0f, rotateTarget * 0.5f, 0f);
		}
		if (body != null)
		{
			body.localRotation = Quaternion.Slerp(body.localRotation, Quaternion.Euler(new Vector3(speedTarget * 0.25f, 0f, rotateTarget / 6f)), Time.deltaTime * 4f);
		}
		float num = rotateTarget / -1.5f;
		if (container != null)
		{
			container.localPosition = containerBase + new Vector3(0f, Mathf.Abs(num) / 2000f, 0f);
			container.localRotation = Quaternion.Slerp(container.localRotation, Quaternion.Euler(0f, rotateTarget * 0.125f, num), Time.deltaTime * 10f);
		}
		if (smoke != null && sphere != null)
		{
			ParticleSystem.EmissionModule emission = smoke.emission;
			emission.enabled = onGround && sphere.velocity.magnitude > acceleration * 0.25f;
			if (trailLeft != null)
			{
				trailLeft.emitting = smoke.emission.enabled;
			}
			if (trailRight != null)
			{
				trailRight.emitting = smoke.emission.enabled;
			}
		}
		if (speed == 0f && sphere != null && sphere.velocity.magnitude < 4f)
		{
			sphere.velocity = Vector3.Lerp(sphere.velocity, Vector3.zero, Time.deltaTime * 2f);
		}
	}

	private void FixedUpdate()
	{
		onGround = Physics.Raycast(base.transform.position, Vector3.down, out var _, 1.1f);
		nearGround = Physics.Raycast(base.transform.position, Vector3.down, out var hitInfo, 2f);
		if (vehicleModel != null)
		{
			vehicleModel.up = Vector3.Lerp(vehicleModel.up, hitInfo.normal, Time.deltaTime * 8f);
			vehicleModel.Rotate(0f, base.transform.eulerAngles.y, 0f);
		}
		if (sphere != null && vehicleModel != null)
		{
			if (nearGround)
			{
				sphere.AddForce(vehicleModel.forward * speedTarget, ForceMode.Acceleration);
			}
			else
			{
				sphere.AddForce(vehicleModel.forward * (speedTarget / 10f), ForceMode.Acceleration);
				sphere.AddForce(Vector3.down * gravity, ForceMode.Acceleration);
			}
			base.transform.position = sphere.transform.position + new Vector3(0f, 0.35f, 0f);
			Vector3 vector = base.transform.InverseTransformVector(sphere.velocity);
			if (nearGround)
			{
				vector.x *= 0.9f + drift / 10f;
				sphere.velocity = base.transform.TransformVector(vector);
			}
		}
	}

	public void ControlAccelerate()
	{
		if (controllable)
		{
			speed = acceleration;
		}
	}

	public void ControlSteer(int direction)
	{
		if (controllable)
		{
			rotate = steering * (float)direction;
		}
	}

	public void SetPosition(Vector3 position, Quaternion rotation)
	{
		rotate = 0f;
		speed = 0f;
		if (sphere != null)
		{
			sphere.velocity = Vector3.zero;
			sphere.position = position;
		}
		base.transform.position = position;
		base.transform.rotation = rotation;
	}
}
