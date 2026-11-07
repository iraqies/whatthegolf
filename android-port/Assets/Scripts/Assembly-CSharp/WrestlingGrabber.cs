using RootMotion.Dynamics;
using UnityEngine;

public class WrestlingGrabber : MonoBehaviour
{
	public PuppetMaster puppetMaster;

	public int grabLayer;

	public float massScale;

	private ConfigurableJoint joint;

	private Collider otherCollider;

	private Rigidbody thisRigidbody;

	private Collider thisCollider;

	private const float massMlp = 15f;

	private const int solverIterationMlp = 20;

	public bool Grabbed { get; private set; }

	public BehaviourPuppet GrabbedPuppet { get; private set; }

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void DoGrab(Collision collision, MuscleCollisionBroadcaster muscle)
	{
	}

	private void Update()
	{
	}

	private void Release()
	{
	}
}
