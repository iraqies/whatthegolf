using System.Linq;
using UnityEngine;

public class Pull2DObject : MonoBehaviour
{
	public bool UsePhysics = true;

	public float PullStrength = 10f;

	public ForceMode2D PullMode;

	public AudioSource PullSource;

	public LineRope PullDrawer;

	public float PullRadius = 2f;

	public LayerMask PullLayers;

	private bool pulling;

	private Rigidbody2D pullingBody;

	private SpringJoint2D joint;

	private Camera mainCamera;

	private void Awake()
	{
		joint = GetComponent<SpringJoint2D>();
		mainCamera = Camera.main;
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
		if (mainCamera == null)
		{
			mainCamera = Camera.main;
		}
		if (pulling && pullingBody != null && mainCamera != null)
		{
			Vector3 worldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
			if (!UsePhysics)
			{
				pullingBody.position = worldPos;
			}
			if (PullDrawer != null)
			{
				PullDrawer.transform.position = worldPos;
			}
			if (joint != null)
			{
				joint.distance = Mathf.Min(Vector2.Distance(transform.position, pullingBody.position), PullRadius);
			}
		}
		if (Input.GetMouseButtonDown(0))
		{
			MouseDown();
		}
		if (Input.GetMouseButtonUp(0))
		{
			MouseUp();
		}
	}

	private void MouseDown()
	{
		if (mainCamera == null)
		{
			return;
		}
		Vector2 mouseWorld = mainCamera.ScreenToWorldPoint(Input.mousePosition);
		Collider2D[] hits = Physics2D.OverlapCircleAll(mouseWorld, PullRadius, PullLayers);
		if (hits == null || hits.Length == 0)
		{
			return;
		}
		Collider2D closest = hits.OrderBy(c => Vector2.Distance(c.transform.position, mouseWorld)).FirstOrDefault();
		if (closest == null || closest.attachedRigidbody == null)
		{
			return;
		}
		pullingBody = closest.attachedRigidbody;
		pulling = true;
		if (!UsePhysics)
		{
			pullingBody.bodyType = RigidbodyType2D.Kinematic;
			pullingBody.velocity = Vector2.zero;
			pullingBody.angularVelocity = 0f;
		}
		if (PullSource != null)
		{
			PullSource.Play();
		}
		if (PullDrawer != null)
		{
			PullDrawer.Target = pullingBody.transform;
			PullDrawer.transform.position = mouseWorld;
		}
		if (joint != null)
		{
			joint.connectedBody = pullingBody;
		}
	}

	private void MouseUp()
	{
		if (pullingBody != null)
		{
			pullingBody.bodyType = RigidbodyType2D.Dynamic;
		}
		pulling = false;
		if (PullSource != null)
		{
			PullSource.Stop();
		}
		if (PullDrawer != null)
		{
			PullDrawer.Target = null;
		}
		pullingBody = null;
		if (joint != null)
		{
			joint.connectedBody = null;
		}
	}
}
