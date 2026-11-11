using System.Collections;
using Core;
using RootMotion.Demos;
using UnityEngine;

public class HotdogFishing : UserControlThirdPerson
{
	public GolfBallController Controller;

	public SpringJoint Spring;

	public float SpringReturnSpeed = 1f;

	public Rigidbody Bait;

	public float BaitFollowMinDistance = 2f;

	public float MaxBaitDistance = 30f;

	public float BaitThrowMagnitude = 1f;

	private Vector3 aimDir;

	private float targetSpring;

	private float baseSpring;

	private Vector3 lastBaitVel;

	protected override void Start()
	{
		base.Start();
		if (Controller != null)
		{
			Controller.OnShoot += OnShoot;
			Controller.OnAimUpdate += OnAimUpdate;
			Controller.OnAimStart += OnAimStart;
		}
		if (Spring != null)
		{
			targetSpring = (baseSpring = Spring.spring);
		}
	}

	private void OnAimStart()
	{
		targetSpring = baseSpring;
		if (Spring != null)
		{
			Spring.massScale = 1f;
		}
	}

	public void OnShoot(Vector3 boost)
	{
		if (Spring != null)
		{
			Spring.spring = 0f;
			targetSpring = 0f;
			aimDir = Vector3.zero;
			Spring.massScale = 0.1f;
			StartCoroutine(ThrowBait(boost));
		}
	}

	private IEnumerator ThrowBait(Vector3 dir)
	{
		yield return new WaitForFixedUpdate();
		if (Bait != null)
		{
			Bait.velocity += dir * BaitThrowMagnitude;
		}
	}

	public void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (!onlyAimArrow)
		{
			aimDir = boost.normalized;
		}
	}

	protected override void Update()
	{
		if (Bait == null)
		{
			return;
		}
		Vector3 normalized = (Bait.position - base.transform.position).normalized;
		Vector3 vector = ((Vector3.Distance(Bait.position, base.transform.position) < BaitFollowMinDistance || aimDir != Vector3.zero) ? Vector3.zero : new Vector3(normalized.x, 0f, normalized.z).normalized);
		Vector3 tangent = vector;
		if (vector != Vector3.zero)
		{
			Vector3 normal = base.transform.up;
			Vector3.OrthoNormalize(ref normal, ref tangent);
		}
		else
		{
			tangent = Vector3.zero;
		}
		state.move = tangent;
		bool flag = aimDir != Vector3.zero;
		state.lookPos = (flag ? (base.transform.position + aimDir * 100f) : (base.transform.position + normalized * 100f));
		if (Vector3.Distance(Bait.position, base.transform.position) > MaxBaitDistance)
		{
			Bait.velocity *= 0.9f;
		}
	}

	private void FixedUpdate()
	{
		if (Spring != null)
		{
			Spring.spring = Mathf.MoveTowards(Spring.spring, targetSpring, Time.deltaTime * SpringReturnSpeed);
		}
		if (Bait != null)
		{
			lastBaitVel = Bait.velocity;
		}
	}
}
