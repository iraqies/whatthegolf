using UnityEngine;

public class SmartCarAgent : MonoBehaviour
{
	public float Speed;

	public float Gravity;

	public float RotateSpeed = 10f;

	public LayerMask IgnoreLayers;

	private Rigidbody rigid;

	private TrafficController.TrafficPoint _currentPath;

	private bool isLocked;

	private Vector3 smoothedNormal;

	private float nonGroundTime;

	private bool hasBeenFlat;

	private Vector3 smoothedFlatForward;

	private void Awake()
	{
		IgnoreLayers = (int)IgnoreLayers | (1 << gameObject.layer);
		rigid = GetComponent<Rigidbody>();
		if (rigid != null)
			rigid.useGravity = false;
	}

	public void Iniitialize(Vector3 position, Vector3 forward)
	{
		transform.position = position;
		smoothedNormal = Vector3.up;
		smoothedNormal = GetNormal();
		transform.LookAt(transform.position + forward, smoothedNormal);
		isLocked = true;
	}

	private Vector3 GetNormal()
	{
		int mask = ~((int)IgnoreLayers);
		if (Physics.Raycast(transform.position, -smoothedNormal, out RaycastHit hit, 30f, mask))
			return hit.normal;
		return Vector3.up;
	}

	private void Unlock()
	{
		if (isLocked)
		{
			if (rigid != null)
				rigid.useGravity = true;
			isLocked = false;
		}
	}

	private bool IsGrounded()
	{
		int mask = ~((int)IgnoreLayers);
		return Physics.Raycast(transform.position, -smoothedNormal, out _, 3f, mask);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.contacts == null || collision.contacts.Length == 0) return;
		if (Vector3.Angle(collision.contacts[0].normal, transform.up) > 60f && collision.relativeVelocity.magnitude > 5f)
		{
			if (collision.gameObject != null && collision.gameObject.layer == LayerMask.NameToLayer("Player"))
			{
				Unlock();
			}
		}
	}

	private void FixedUpdate()
	{
		if (isLocked)
		{
			if (rigid != null)
				rigid.velocity = transform.forward * Speed - smoothedNormal * Gravity;
			Vector3 normal = GetNormal();
			smoothedNormal = Vector3.MoveTowards(smoothedNormal, normal, Time.fixedDeltaTime * 2.5f);
			Vector3 projForward = Vector3.ProjectOnPlane(transform.forward, smoothedNormal);
			smoothedFlatForward = Vector3.MoveTowards(smoothedFlatForward, projForward, Time.fixedDeltaTime);
			if (IsGrounded())
				nonGroundTime = 0f;
			else
				nonGroundTime += Time.deltaTime;

			if (Vector3.Angle(transform.up, Vector3.up) < 5f)
				hasBeenFlat = true;

			if ((hasBeenFlat && Vector3.Angle(transform.forward, Vector3.down) < 70f) || nonGroundTime > 0.06f)
			{
				Unlock();
			}
		}
		else if (IsGrounded() && rigid != null)
		{
			rigid.AddForce(transform.forward * Speed * Time.fixedDeltaTime * 500f, ForceMode.Acceleration);
		}
	}
}
