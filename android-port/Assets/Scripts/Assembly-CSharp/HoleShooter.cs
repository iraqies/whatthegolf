using Core;
using UnityEngine;

public class HoleShooter : GolfBallShooterBase
{
	[SerializeField]
	private float startUpForce;

	[SerializeField]
	private float startForwardForce;

	[SerializeField]
	private Collider croundCollider;

	[SerializeField]
	private ParticleSystem breakFreeParticles;

	[SerializeField]
	private float minShootVelocity = 10f;

	[SerializeField]
	private float fullShootVelocity = 25f;

	[SerializeField]
	private float pitch;

	[SerializeField]
	private float spin;

	[SerializeField]
	private Transform newArrowPosition;

	private Collider col;

	private bool firstShot = true;

	private Transform firstShotArrowPosition;

	protected override void Awake()
	{
		base.Awake();
		col = GetComponent<Collider>() ?? GetComponentInChildren<Collider>();
		if (GolfBallController != null)
			firstShotArrowPosition = GolfBallController.ArrowPosition;
	}

	public override void OnShoot(Vector3 boost)
	{
		if (firstShot)
		{
			if (rigidbodyC == null)
				rigidbodyC = GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>();
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = false;
				rigidbodyC.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
			}
			if (col != null && croundCollider != null)
				Physics.IgnoreCollision(col, croundCollider, true);

			Vector3 jumpVec = Vector3.up * startUpForce + boost.normalized * startForwardForce;
			boost = jumpVec;
			base.OnShoot(boost);
			float mag = boost.magnitude;
			StandardShoot(boost, 1f, mag, mag, 30f);

			StartCoroutine(pTween.To(0.2f, _ => { }).Then(() =>
			{
				if (col != null && croundCollider != null)
					Physics.IgnoreCollision(col, croundCollider, false);
			}));

			if (breakFreeParticles != null)
			{
				breakFreeParticles.transform.position = transform.position;
				breakFreeParticles.Play();
			}
			firstShot = false;
			if (GolfBallController != null && newArrowPosition != null)
				GolfBallController.ArrowPosition = newArrowPosition;
		}
		else
		{
			base.OnShoot(boost);
			if (breakFreeParticles != null)
				breakFreeParticles.Emit(10);
			Vector3 axis = Vector3.Cross(boost, Vector3.up);
			if (axis.sqrMagnitude > 1e-6f)
				boost = Quaternion.AngleAxis(pitch, axis) * boost;
			StandardShoot(boost, pitch, minShootVelocity, fullShootVelocity, spin);
		}
	}

	public override void OnReset()
	{
		firstShot = true;
		if (rigidbodyC != null)
		{
			rigidbodyC.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
			rigidbodyC.isKinematic = true;
		}
		if (GolfBallController != null && firstShotArrowPosition != null)
			GolfBallController.ArrowPosition = firstShotArrowPosition;
	}
}
