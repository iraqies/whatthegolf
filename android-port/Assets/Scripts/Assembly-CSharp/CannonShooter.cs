using System.Collections;
using Core;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private Rigidbody cannonBall;

	[SerializeField]
	private Transform shootPosition;

	[SerializeField]
	private Vector3 additionalShootDirection;

	[SerializeField]
	private Transform recoilPos;

	[SerializeField]
	private float recoilDuration;

	[SerializeField]
	private AnimationCurve recoilCurve;

	[SerializeField]
	private float shootForce;

	[SerializeField]
	private bool useArrowForce;

	[SerializeField]
	private float LookInAimDirectionSpeed = float.PositiveInfinity;

	private Rigidbody rigid;

	private Vector3 startPos;

	private bool canShoot = true;

	[SerializeField]
	private bool moveable;

	[SerializeField]
	private bool lookInAim = true;

	[SerializeField]
	private float spin;

	[SerializeField]
	private float forceOnShoot;

	private float ShootTime = -10f;

	private void AimUpdate(Vector3 boost, bool b)
	{
		if (!canShoot || !lookInAim || boost.magnitude < 0.1f || (Time.time - ShootTime) < 0.5f || rigid == null)
			return;

		rigid.constraints = (RigidbodyConstraints)10;
		Quaternion targetRot = Quaternion.identity;
		targetRot.SetLookRotation(boost);
		float t = Mathf.Clamp(Time.deltaTime * LookInAimDirectionSpeed, 0f, 1f);
		rigid.MoveRotation(Quaternion.Lerp(rigid.rotation, targetRot, t));
	}

	private void Shoot(Vector3 boost)
	{
		if (!canShoot || (Time.time - ShootTime) < 0.5f || rigid == null || shootPosition == null)
			return;

		rigid.constraints = RigidbodyConstraints.FreezeRotationX;
		if (cannonBall != null)
		{
			Rigidbody spawned = Object.Instantiate(cannonBall, shootPosition.position, base.transform.rotation);
			if (spawned != null)
			{
				if (useArrowForce)
				{
					spawned.velocity = base.transform.forward * boost.magnitude * shootForce;
				}
				else
				{
					spawned.AddTorque(-Vector3.right * spin, ForceMode.VelocityChange);
				}
				spawned.AddForce((base.transform.forward + additionalShootDirection) * shootForce, ForceMode.Force);
			}
		}

		if (moveable)
		{
			Vector3 backDir = (-boost).normalized;
			rigid.AddForce(backDir * forceOnShoot * boost.magnitude);
			ShootTime = Time.time;
		}
		else
		{
			rigid.angularVelocity = Vector3.zero;
			rigid.velocity = Vector3.zero;
			StartCoroutine(Recoil());
		}
	}

	private IEnumerator Recoil()
	{
		yield return StartCoroutine(pTween.To(recoilDuration, 0f, 1f, delegate(float t)
		{
			if (recoilPos != null && recoilCurve != null && rigid != null)
			{
				Vector3 target = recoilPos.position;
				float eval = recoilCurve.Evaluate(t);
				rigid.MovePosition(startPos + (target - startPos) * eval);
			}
		}));
	}

	private bool Cool()
	{
		return (Time.time - ShootTime) < 0.5f;
	}

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		if (controller != null)
		{
			controller.OnAimUpdate += AimUpdate;
			controller.AddBlockingFunction(Cool);
			controller.OnShoot += Shoot;
		}
		startPos = base.transform.position;
	}

	private void OnDestroy()
	{
		if (controller != null)
		{
			controller.OnAimUpdate -= AimUpdate;
			controller.OnShoot -= Shoot;
		}
	}
}
