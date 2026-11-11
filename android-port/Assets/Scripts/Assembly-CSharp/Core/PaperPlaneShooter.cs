using UnityEngine;

namespace Core
{
	public class PaperPlaneShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity = 5f;

		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float pitch;

		[SerializeField]
		protected float spin;

		private ParticleSystem particle;

		private Quaternion targetRotation;

		private Vector3 shootVelocity;

		protected override void Awake()
		{
			base.Awake();
			rigid = GetComponent<Rigidbody>();
			particle = GetComponentInChildren<ParticleSystem>();
		}

		public override void OnShoot(Vector3 boost)
		{
			ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime = particle.velocityOverLifetime;
			velocityOverLifetime.x = boost.x * 50f;
			velocityOverLifetime.y = boost.y * 50f;
			velocityOverLifetime.z = boost.z * 50f;
			particle.Emit(10);
			float num = Mathf.Max(0f, Vector3.Dot(boost, base.transform.forward));
			boost += Vector3.up / 10f;
			targetRotation = Quaternion.LookRotation(boost.normalized);
			PaperShoot(num * num * boost, pitch, minShootVelocity, fullShootVelocity, spin);
		}

		protected override void FixedUpdate()
		{
			particle.transform.position = Camera.main.transform.position - Vector3.down * 10f;
			particle.transform.LookAt(base.transform.position);
			particle.transform.rotation = Quaternion.Euler(0f, particle.transform.rotation.eulerAngles.y, particle.transform.rotation.eulerAngles.z);
			shootVelocity = shootVelocity.normalized * rigid.velocity.magnitude;
			rigid.velocity = Vector3.Lerp(rigid.velocity, shootVelocity, Mathf.Clamp01(Time.deltaTime / 5f));
			if (rigid.velocity.magnitude > 0.1f)
			{
				rigid.rotation = Quaternion.Lerp(rigid.rotation, targetRotation, Time.deltaTime * 5f);
			}
		}

		private void clampRotation(bool reset)
		{
			Quaternion rotation = rigid.rotation;
			rotation.x = (reset ? 0f : Mathf.Clamp(rotation.x, -0.2f, 0.7f));
			rotation.z = 0f;
			rigid.MoveRotation(rotation);
		}

		private Quaternion AdjustRotation(Vector3 dir)
		{
			return Quaternion.LookRotation(dir.normalized);
		}

		protected void PaperShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
			Vector3 vector = Vector3.Cross(boost, Vector3.up);
			rigid.angularVelocity = Vector3.zero;
			rigid.velocity = Vector3.zero;
			Vector3 normalized = boost.normalized;
			Vector3 a = minShootVelocity * normalized;
			Vector3 b = fullShootVelocity * normalized;
			shootVelocity = Vector3.Lerp(a, b, Mathf.Clamp01(boost.magnitude));
			Debug.Log(shootVelocity.magnitude);
			if (rigid.velocity.magnitude < 0.1f)
			{
				rigid.velocity = shootVelocity;
			}
			rigid.AddTorque(-vector * spin, ForceMode.VelocityChange);
		}
	}
}
