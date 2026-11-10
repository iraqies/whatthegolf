using System.Collections.Generic;
using UnityEngine;

public class SpiderLegs : MonoBehaviour
{
	private class LegInfo
	{
		public Rigidbody LegRigid;

		public LineRenderer Line;

		public Transform Foot;

		public Vector3 FootTarget;

		public Vector3? LegTarget;

		public Vector3 OrigPosition;

		public float ForceRepositionTimer;

		public float RepositionTimer;
	}

	public AnimationCurve DragCurveOnShot;

	public bool changeDrag;

	public List<Rigidbody> Legs;

	public float MaxFeetFromLegDistance = 2f;

	public float FeetSpread = 1f;

	public float FeetSpreadVelocity = 0.5f;

	public float FeetMoveSpeed = 10f;

	public float FeetMoveSpeedVelocityMod = 1f;

	public float test;

	public float test2;

	public GameObject footTemplate;

	public int LegJoints = 3;

	public float Height = 1f;

	public float CustomGravity = 9.81f;

	public Transform CustomUp;

	public float CustomUpFollowSpeed = 5f;

	public float RepositionTimerMod = 0.25f;

	public float ForceRepositionTimerMod = 0.5f;

	private List<LegInfo> LegInfos;

	private Vector3 origGravity;

	private ConstantForce customGravity;

	private Vector3 velocityLastFrame;

	private Collider currentGravityCollider;

	private float dragOnShotTimer;

	private float originalDrag;

	private Transform cachedTrans;

	private Collider[] overlapCols;

	private Vector3 lastColliderPosition;

	private Vector3 colliderMoveDelta;

	private Rigidbody rigidbodyC;

	public bool IsFlying;

	private void Start()
	{
		cachedTrans = transform;
		rigidbodyC = GetComponent<Rigidbody>();
		if (rigidbodyC != null)
		{
			originalDrag = rigidbodyC.drag;
		}
		customGravity = GetComponent<ConstantForce>();
		LegInfos = new List<LegInfo>();
		if (Legs != null)
		{
			for (int i = 0; i < Legs.Count; i++)
			{
				Rigidbody legRigid = Legs[i];
				if (legRigid == null)
				{
					continue;
				}
				LegInfo info = new LegInfo
				{
					LegRigid = legRigid,
					Line = legRigid.GetComponent<LineRenderer>(),
					OrigPosition = legRigid.transform.localPosition,
					FootTarget = legRigid.transform.position
				};
				if (footTemplate != null)
				{
					GameObject footObj = Object.Instantiate(footTemplate, legRigid.transform.position, Quaternion.identity, transform);
					info.Foot = footObj.transform;
				}
				LegInfos.Add(info);
			}
		}
	}

	public void Reset()
	{
		IsFlying = false;
		if (rigidbodyC != null)
		{
			rigidbodyC.drag = originalDrag;
		}
	}

	public void ToggleLegs(bool state)
	{
		if (LegInfos == null)
		{
			return;
		}
		for (int i = 0; i < LegInfos.Count; i++)
		{
			if (LegInfos[i].Line != null)
			{
				LegInfos[i].Line.enabled = state;
			}
			if (LegInfos[i].Foot != null)
			{
				LegInfos[i].Foot.gameObject.SetActive(state);
			}
		}
	}

	private void FixedUpdate()
	{
		if (LegInfos == null)
		{
			return;
		}
		for (int i = 0; i < LegInfos.Count; i++)
		{
			LegInfo info = LegInfos[i];
			if (info.LegRigid == null)
			{
				continue;
			}
			Vector3 worldDesired = transform.TransformPoint(info.OrigPosition) + Vector3.down * Height;
			if (Vector3.Distance(info.FootTarget, worldDesired) > MaxFeetFromLegDistance)
			{
				info.FootTarget = worldDesired;
			}
			if (info.Foot != null)
			{
				info.Foot.position = Vector3.MoveTowards(info.Foot.position, info.FootTarget, FeetMoveSpeed * Time.fixedDeltaTime);
			}
			if (info.Line != null && info.Line.positionCount >= 2)
			{
				info.Line.SetPosition(0, info.LegRigid.position);
				info.Line.SetPosition(info.Line.positionCount - 1, info.Foot != null ? info.Foot.position : info.FootTarget);
			}
		}
	}

	public bool IsGrounded()
	{
		return !IsFlying && Physics.Raycast(transform.position, Vector3.down, Height * 1.5f + 0.5f);
	}

	public bool CanMove(Vector3 boost)
	{
		return IsGrounded();
	}

	public void Move(Vector3 boost)
	{
		if (rigidbodyC != null)
		{
			rigidbodyC.AddForce(boost, ForceMode.VelocityChange);
		}
	}

	private void OnCollisionEnter(Collision col)
	{
		IsFlying = false;
	}

	private void OnCollisionExit(Collision col)
	{
	}
}
