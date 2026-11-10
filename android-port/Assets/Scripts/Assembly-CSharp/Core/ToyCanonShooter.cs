using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Core
{
	public class ToyCanonShooter : GolfBallShooterBase
	{
		[SerializeField]
		public Transform controllerShootPosition;

		[SerializeField]
		public ParticleSystem insideCanonParticles;

		[SerializeField]
		public ParticleSystem shootParticles;

		[SerializeField]
		public float minShootVelocity = 5f;

		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float pitch = 60f;

		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);

		[SerializeField]
		public float spin;

		[SerializeField]
		protected bool lookInShotDirection;

		public bool lookInAimDirection;

		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		public float LookInAimDirectionSpeed = float.PositiveInfinity;

		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[SerializeField]
		protected bool useLocalUp;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded = true;

		private GolfBallController canonController;

		private Animator canonAnimator;

		private List<Collider> canonColliders;

		private GameObject controllerGO;

		private Rigidbody rigidBodyControllerToShoot;

		private GolfBallController golfBallControllerToShoot;

		protected override void Awake()
		{
			base.Awake();
		}

		private void Start()
		{
			canonAnimator = GetComponentInChildren<Animator>();
			canonController = GetComponent<GolfBallController>();
			if (canonController != null)
				canonController.enabled = false;
			canonColliders = GetComponentsInChildren<Collider>().ToList();
		}

		public override void OnActivate()
		{
			base.OnActivate();
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other == null)
				return;

			if (other.CompareTag("Player"))
			{
				GolfBallController ctrl = other.GetComponent<GolfBallController>();
				if (ctrl != null)
				{
					PutControllerInsideCanon(other.gameObject);
					return;
				}
				Rigidbody rbParent = other.GetComponentInParent<Rigidbody>();
				if (rbParent != null)
				{
					PutControllerInsideCanon(rbParent.gameObject);
				}
			}
		}

		private void PutControllerInsideCanon(GameObject controllerInCanon)
		{
			controllerGO = controllerInCanon;
			if (canonController != null)
				canonController.enabled = true;
			if (controllerInCanon == null)
				return;

			rigidBodyControllerToShoot = controllerInCanon.GetComponent<Rigidbody>();
			golfBallControllerToShoot = controllerInCanon.GetComponent<GolfBallController>();
			if (golfBallControllerToShoot != null)
			{
				golfBallControllerToShoot.StopAiming();
				golfBallControllerToShoot.enabled = false;
			}
			if (insideCanonParticles != null)
			{
				Vector3 dir = transform.position - controllerInCanon.transform.position;
				if (dir.sqrMagnitude > 0.0001f)
					insideCanonParticles.transform.rotation = Quaternion.LookRotation(dir).normalized;
				insideCanonParticles.transform.position = controllerInCanon.transform.position;
				insideCanonParticles.Play();
			}
			if (canonAnimator != null)
				canonAnimator.SetTrigger("EnterCanon");

			controllerInCanon.SetActive(false);
			if (controllerShootPosition != null)
				controllerInCanon.transform.position = controllerShootPosition.position;
		}

		private void EnableControllerInsideTheCanon()
		{
			if (shootParticles != null)
				shootParticles.Play();
			if (canonAnimator != null)
				canonAnimator.SetTrigger("Shoot");
			if (controllerGO != null && controllerShootPosition != null)
				controllerGO.transform.position = controllerShootPosition.position;
			if (golfBallControllerToShoot != null)
				golfBallControllerToShoot.enabled = true;
			if (controllerGO != null)
				controllerGO.SetActive(true);
			if (canonController != null)
				canonController.enabled = false;
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (rigidBodyControllerToShoot == null)
				return;

			base.OnAimUpdate(boost, onlyAimArrow);
			if (!lookInAimDirection)
				return;
			if (onlyAimArrow && onlyLookWhenChargingOnController)
				return;
			if (dontLookInAimDirectionWhenBlocked && IsBlocking())
				return;
			if (boost.sqrMagnitude < 1e-6f || rigidbodyC == null)
				return;

			Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
			Quaternion targetRot = Quaternion.LookRotation(boost, upVec);
			if (float.IsInfinity(LookInAimDirectionSpeed))
			{
				rigidbodyC.MoveRotation(targetRot);
			}
			else
			{
				Quaternion nextRot = Quaternion.RotateTowards(rigidbodyC.rotation, targetRot, LookInAimDirectionSpeed * Time.deltaTime);
				rigidbodyC.MoveRotation(nextRot);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			if (rigidBodyControllerToShoot == null)
				return;

			base.OnShoot(boost);
			Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
			if (lookInShotDirection && rigidbodyC != null && boost.sqrMagnitude > 1e-6f)
			{
				rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upVec));
			}

			Vector3 planeNormal = (GolfBallController != null) ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up;
			Vector3 cross = Vector3.Cross(boost, planeNormal);
			Vector3 pitchedBoost = Quaternion.AngleAxis(pitch, cross) * boost;
			StandardShoot(pitchedBoost, pitch, minShootVelocity, fullShootVelocity, spin);
		}

		protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
			if (rigidBodyControllerToShoot == null)
				return;

			rigidBodyControllerToShoot.angularVelocity = Vector3.zero;
			rigidBodyControllerToShoot.velocity = Vector3.zero;
			Vector3 dir = boost.normalized;
			float mag = boost.magnitude;
			Vector3 minVel = dir * minShootVelocity;
			Vector3 maxVel = dir * fullShootVelocity;
			rigidBodyControllerToShoot.velocity = minVel + (maxVel - minVel) * mag;

			StartCoroutine(DeactivateAllCollidersOnShoot());
			EnableControllerInsideTheCanon();
		}

		private IEnumerator DeactivateAllCollidersOnShoot()
		{
			EnableColliders(false);
			yield return new WaitForSeconds(0.2f);
			EnableColliders(true);
		}

		private void EnableColliders(bool enable)
		{
			if (canonColliders == null)
				return;
			for (int i = 0; i < canonColliders.Count; i++)
			{
				if (canonColliders[i] != null)
					canonColliders[i].enabled = enable;
			}
		}
	}
}
