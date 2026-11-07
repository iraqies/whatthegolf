using UnityEngine;

public class Pull2DObject : MonoBehaviour
{
	public bool UsePhysics;

	public float PullStrength;

	public ForceMode2D PullMode;

	public AudioSource PullSource;

	public LineRope PullDrawer;

	public float PullRadius;

	public LayerMask PullLayers;

	private bool pulling;

	private Rigidbody2D pullingBody;

	private SpringJoint2D joint;

	private Camera mainCamera;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void MouseDown()
	{
	}

	private void MouseUp()
	{
	}
}
