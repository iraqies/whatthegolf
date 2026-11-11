using System.Collections.Generic;
using Audio;
using UnityEngine;

public class ArmBlob : MonoBehaviour
{
	public List<Transform> throwTargets;

	public float pullForce = 30f;

	public float pushForce = 50f;

	public float isCloseThreshold = 3f;

	public float isCloseEnoughThreshold = 1.5f;

	public float isTooCloseThreshold = 0.8f;

	public Transform center;

	public Transform target;

	public bool debug;

	public Transform eyeLeft;

	public Transform eyeRight;

	public float eyeMaxMovement = 0.2f;

	public List<Transform> endpoints;

	public float maxDistance = 6f;

	public float raycastOffsetForFindingBall = 0.5f;

	[SerializeField]
	private LayerMask layerMask;

	public float extraDragWhilePulling = 5f;

	public float dragMinimumVelocity = 1f;

	public float multiplyOldVelocityBeforeThrowing = 0.2f;

	private Vector3 eyeLeftBase;

	private Vector3 eyeRightBase;

	private Vector3 lastBallPos;

	private float nextGrab;

	private bool wasGrabbing;

	private int nextTarget;

	private Rigidbody2D rigid;

	public Transform[] ClawLeft;

	public Transform[] ClawRight;

	public float ClawRotationOffset = 45f;

	private float clawPct;

	private float lastClawPct;

	public bool ignoreRaycast;

	private RaycastHit2D[] results = new RaycastHit2D[10];

	public AudioEventAsset throwSFX;

	public AudioEventAsset clawSFX;

	public float clawSFXCooldown = 0.5f;

	private float nextSFXTime;

	public bool isPulling { get; private set; }

	private void Start()
	{
		isPulling = true;
		if (eyeLeft != null)
		{
			eyeLeftBase = eyeLeft.position;
		}
		if (eyeRight != null)
		{
			eyeRightBase = eyeRight.position;
		}
		if (OverworldBallManager.Instance != null)
		{
			if (OverworldBallManager.Instance.Ball != null)
			{
				rigid = OverworldBallManager.Instance.Ball.GetComponent<Rigidbody2D>();
			}
			OverworldBallManager.Instance.OnNewBall += Instance_OnNewBall;
		}
	}

	private void NextRandomTarget()
	{
		if (throwTargets == null || throwTargets.Count == 0)
		{
			return;
		}
		nextTarget = (nextTarget + 1) % throwTargets.Count;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			rigid = OverworldBallManager.Instance.Ball.GetComponent<Rigidbody2D>();
		}
	}

	private void UpdateClaws(bool isClawed)
	{
		clawPct = Mathf.MoveTowards(clawPct, isClawed ? 1f : 0f, Time.deltaTime * 5f);
		if (ClawLeft != null)
		{
			for (int i = 0; i < ClawLeft.Length; i++)
			{
				if (ClawLeft[i] != null)
				{
					ClawLeft[i].localRotation = Quaternion.Euler(0f, 0f, Mathf.Lerp(0f, ClawRotationOffset, clawPct));
				}
			}
		}
		if (ClawRight != null)
		{
			for (int i = 0; i < ClawRight.Length; i++)
			{
				if (ClawRight[i] != null)
				{
					ClawRight[i].localRotation = Quaternion.Euler(0f, 0f, Mathf.Lerp(0f, -ClawRotationOffset, clawPct));
				}
			}
		}
	}

	private void Update()
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			lastBallPos = OverworldBallManager.Instance.Ball.transform.position;
			if (rigid == null)
			{
				rigid = OverworldBallManager.Instance.Ball.GetComponent<Rigidbody2D>();
			}
		}
		if (eyeLeft != null)
		{
			Vector3 dirL = (lastBallPos - eyeLeftBase).normalized;
			eyeLeft.position = eyeLeftBase + new Vector3(dirL.x, dirL.y, 0f) * eyeMaxMovement;
		}
		if (eyeRight != null)
		{
			Vector3 dirR = (lastBallPos - eyeRightBase).normalized;
			eyeRight.position = eyeRightBase + new Vector3(dirR.x, dirR.y, 0f) * eyeMaxMovement;
		}
		if (center == null || rigid == null)
		{
			return;
		}
		float distToCenter = Vector2.Distance(center.position, rigid.position);
		bool inRange = distToCenter <= maxDistance && Time.time >= nextGrab;
		if (inRange)
		{
			if (target != null)
			{
				target.position = lastBallPos;
			}
			if (isPulling)
			{
				if (distToCenter < isTooCloseThreshold)
				{
					rigid.velocity *= multiplyOldVelocityBeforeThrowing;
					NextRandomTarget();
					isPulling = false;
					if (throwSFX != null)
					{
						throwSFX.Play(transform.position, 1f, 1f);
					}
				}
				else
				{
					Vector2 toCenter = ((Vector2)center.position - rigid.position).normalized;
					rigid.AddForce(toCenter * (pullForce * Time.deltaTime * 60f));
				}
			}
			else if (throwTargets != null && throwTargets.Count > 0 && throwTargets[nextTarget] != null)
			{
				Vector2 throwDir = ((Vector2)throwTargets[nextTarget].position - (Vector2)center.position).normalized;
				rigid.AddForce(throwDir * pushForce, ForceMode2D.Impulse);
				nextGrab = Time.time + 0.75f;
				isPulling = true;
			}
		}
		UpdateClaws(inRange && isPulling);
	}
}
