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
	private float LookInAimDirectionSpeed;

	private Rigidbody rigid;

	private Vector3 startPos;

	private bool canShoot;

	[SerializeField]
	private bool moveable;

	[SerializeField]
	private bool lookInAim;

	[SerializeField]
	private float spin;

	[SerializeField]
	private float forceOnShoot;

	private float ShootTime;

	private void AimUpdate(Vector3 boost, bool b)
	{
	}

	private void Shoot(Vector3 boost)
	{
	}

	private IEnumerator Recoil()
	{
		return null;
	}

	private bool Cool()
	{
		return false;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}
