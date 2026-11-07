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
	private float ConnectedMassScale;

	private float timer;

	private void Awake()
	{
	}

	private void ControllerOnShoot(Vector3 dir)
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
