using Core;
using UnityEngine;

public class GolferInSnowballController : MonoBehaviour
{
	[SerializeField]
	private GolfBallController GolferController;

	[SerializeField]
	private GolfBallController SnowballController;

	[SerializeField]
	private Rigidbody SnowballRigid;

	[SerializeField]
	private Collider SnowballCollider;

	[SerializeField]
	private ParticleSystem HitParticles;

	[SerializeField]
	private Animator CameraController;

	[SerializeField]
	private float ConnectedMassScale = 1f;

	private float timer;

	private void Awake()
	{
		GolferController.OnShoot += ControllerOnShoot;
	}

	private void ControllerOnShoot(Vector3 dir)
	{
		GolferController.enabled = false;
		GolferController.shootArrow.Hide();
	}

	private void Update()
	{
		if (timer > 0f && SnowballRigid.isKinematic)
		{
			timer -= Time.deltaTime;
			if (timer <= 0f)
			{
				SnowballRigid.isKinematic = false;
				SnowballCollider.isTrigger = false;
				CameraController.SetTrigger("Trigger");
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == LayerMask.NameToLayer("GolfBall"))
		{
			SnowballController.enabled = true;
			if (other.attachedRigidbody != null && other.attachedRigidbody.gameObject.GetComponent<FixedJoint>() == null)
			{
				HitParticles.transform.position = other.attachedRigidbody.transform.position;
				HitParticles.Emit(75);
				FixedJoint fixedJoint = other.attachedRigidbody.gameObject.AddComponent<FixedJoint>();
				fixedJoint.connectedBody = SnowballRigid;
				fixedJoint.enablePreprocessing = false;
				fixedJoint.connectedMassScale = ConnectedMassScale;
				timer = 0.5f;
			}
		}
	}
}
