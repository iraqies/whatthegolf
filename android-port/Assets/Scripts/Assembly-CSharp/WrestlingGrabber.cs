using RootMotion.Dynamics;
using UnityEngine;

public class WrestlingGrabber : MonoBehaviour
{
	public PuppetMaster puppetMaster;

	public int grabLayer;

	public float massScale = 1f;

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
		thisRigidbody = GetComponent<Rigidbody>();
		thisCollider = GetComponent<Collider>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (Grabbed || collision == null || collision.rigidbody == null || collision.gameObject == null)
		{
			return;
		}
		if (collision.gameObject.layer == grabLayer && collision.gameObject.TryGetComponent<MuscleCollisionBroadcaster>(out MuscleCollisionBroadcaster muscle))
		{
			if (muscle != null && muscle.puppetMaster != puppetMaster)
			{
				DoGrab(collision, muscle);
			}
		}
	}

	private void DoGrab(Collision collision, MuscleCollisionBroadcaster muscle)
	{
		if (muscle == null || muscle.puppetMaster == null || muscle.puppetMaster.behaviours == null)
		{
			return;
		}
		for (int i = 0; i < muscle.puppetMaster.behaviours.Length; i++)
		{
			if (muscle.puppetMaster.behaviours[i] is BehaviourPuppet bp)
			{
				GrabbedPuppet = bp;
				GrabbedPuppet.SetState(BehaviourPuppet.State.Unpinned);
				GrabbedPuppet.canGetUp = false;
				break;
			}
		}
		joint = gameObject.AddComponent<ConfigurableJoint>();
		joint.connectedBody = collision.rigidbody;
		joint.anchor = Vector3.zero;
		joint.xMotion = ConfigurableJointMotion.Locked;
		joint.yMotion = ConfigurableJointMotion.Locked;
		joint.zMotion = ConfigurableJointMotion.Locked;
		joint.angularXMotion = ConfigurableJointMotion.Limited;
		joint.angularYMotion = ConfigurableJointMotion.Limited;
		joint.angularZMotion = ConfigurableJointMotion.Limited;
		joint.enablePreprocessing = false;
		joint.projectionMode = JointProjectionMode.PositionAndRotation;
		joint.projectionDistance = 0f;
		joint.projectionAngle = 0f;
		joint.connectedMassScale = massScale;
		if (thisRigidbody != null)
		{
			thisRigidbody.mass *= 15f;
		}
		if (puppetMaster != null)
		{
			puppetMaster.solverIterationCount *= 20;
			if (GrabbedPuppet != null && GrabbedPuppet.puppetMaster != null)
			{
				GrabbedPuppet.puppetMaster.solverIterationCount = puppetMaster.solverIterationCount;
			}
		}
		otherCollider = collision.collider;
		if (thisCollider != null && otherCollider != null)
		{
			Physics.IgnoreCollision(thisCollider, otherCollider, true);
		}
		Grabbed = true;
	}

	private void Update()
	{
		if (Grabbed && Input.GetKeyDown(KeyCode.Space))
		{
			Release();
		}
	}

	private void Release()
	{
		if (!Grabbed)
		{
			return;
		}
		if (joint != null)
		{
			Object.Destroy(joint);
		}
		if (thisRigidbody != null)
		{
			thisRigidbody.mass /= 15f;
		}
		if (puppetMaster != null)
		{
			puppetMaster.solverIterationCount = Mathf.Max(1, puppetMaster.solverIterationCount / 20);
		}
		if (thisCollider != null && otherCollider != null)
		{
			Physics.IgnoreCollision(thisCollider, otherCollider, false);
		}
		if (GrabbedPuppet != null)
		{
			if (GrabbedPuppet.puppetMaster != null && puppetMaster != null)
			{
				GrabbedPuppet.puppetMaster.solverIterationCount = puppetMaster.solverIterationCount;
			}
			GrabbedPuppet.canGetUp = true;
		}
		GrabbedPuppet = null;
		otherCollider = null;
		Grabbed = false;
	}
}
