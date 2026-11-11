using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using RootMotion.Dynamics;
using UnityEngine;

public class PoleVaultController : GolfBallShooterBase
{
	[Serializable]
	public struct OneshotTime
	{
		public float delay;

		public ClipSettingsCollection sfx;
	}

	public Joint HandJoint;

	public HingeJoint PoleJoint;

	public HingeJoint PoleAnchor;

	public float MinTargetVelocity = -10f;

	public float MaxTargetVelocity = 10f;

	public PuppetMaster PoleVaulter;

	public bool SpawnFakeArrowOnShoot;

	public Transform FakeArrowParent;

	public bool CanShootAgainAfterGettingUp;

	public float ReleasePoleThreshold = 0.9f;

	public bool ReleaseWhenAboutToGetUp;

	public Collider PoleCollider;

	public bool IgnoreBoundsAfterAnchored;

	public ClipSettingsCollection ReleaseClip;

	public List<OneshotTime> oneshotsOnVault;

	private float target;

	private bool hasShot;

	private Quaternion startRot;

	private Vector3 startOffset;

	private Vector3 anchor;

	private Rigidbody hingeJointConnectedBody;

	private GameObject handJointGameObject;

	private PuppetAutoRun puppet;

	private GameObject fakeArrow;

	protected override void Awake()
	{
		base.Awake();
		startRot = base.transform.rotation;
		if (PoleVaulter != null && PoleVaulter.transform.parent != null)
		{
			puppet = PoleVaulter.transform.parent.GetComponentInChildren<PuppetAutoRun>();
			if (puppet != null)
			{
				startOffset = puppet.transform.position - base.transform.position;
			}
		}
		if (PoleJoint != null)
		{
			hingeJointConnectedBody = PoleJoint.connectedBody;
			anchor = PoleJoint.connectedAnchor;
		}
		if (HandJoint != null)
		{
			handJointGameObject = HandJoint.gameObject;
		}
		if (SpawnFakeArrowOnShoot && GolfBallController != null)
		{
			GolfBallController.OnShootArrowInitialized += OnShootArrowInitialized;
		}
	}

	private void Start()
	{
		if (PoleCollider != null)
		{
			PoleCollider.enabled = false;
		}
	}

	public void OnRegainBalance()
	{
		if (!CanShootAgainAfterGettingUp || !(PoleJoint == null))
		{
			return;
		}
		if (fakeArrow != null)
		{
			fakeArrow.transform.SetParent(null, true);
		}
		hasShot = false;
		if (GolfBallController != null)
		{
			GolfBallController.enabled = true;
		}
		base.transform.rotation = startRot;
		if (puppet != null)
		{
			base.transform.position = puppet.transform.position + startOffset;
		}
		PoleJoint = base.gameObject.AddComponent<HingeJoint>();
		PoleJoint.connectedBody = hingeJointConnectedBody;
		PoleJoint.connectedMassScale = 10f;
		PoleJoint.autoConfigureConnectedAnchor = false;
		PoleJoint.connectedAnchor = anchor;
		JointMotor motor = PoleJoint.motor;
		motor.targetVelocity = MinTargetVelocity;
		PoleJoint.motor = motor;
		PoleJoint.useMotor = false;
		if (rigid != null)
		{
			rigid.constraints = (RigidbodyConstraints)112;
		}
		JointLimits limits = PoleJoint.limits;
		limits.max = -33.134f;
		PoleJoint.limits = limits;
		PoleJoint.useLimits = false;
		if (handJointGameObject != null)
		{
			HandJoint = handJointGameObject.AddComponent<CharacterJoint>();
			HandJoint.connectedBody = rigid;
			HandJoint.connectedMassScale = 0.0001f;
			HandJoint.enablePreprocessing = false;
		}
		if (PoleAnchor != null)
		{
			PoleAnchor.gameObject.SetActive(false);
		}
	}

	public void AboutToGetUp()
	{
		if (ReleaseWhenAboutToGetUp && PoleAnchor != null && PoleAnchor.gameObject.activeSelf)
		{
			if (HandJoint != null)
			{
				UnityEngine.Object.Destroy(HandJoint);
			}
			if (PoleJoint != null)
			{
				UnityEngine.Object.Destroy(PoleJoint);
			}
		}
	}

	private void OnShootArrowInitialized(ShootArrow arrow)
	{
		if (arrow != null && arrow.arrowOutline != null)
		{
			arrow.arrowOutline.enabled = false;
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (!onlyAimArrow && PoleCollider != null)
		{
			PoleCollider.enabled = true;
		}
	}

	public override void OnCancel()
	{
		base.OnCancel();
		if (PoleCollider != null)
		{
			PoleCollider.enabled = false;
		}
	}

	private void SetJointMotorTargetVel(float val)
	{
		if (PoleJoint != null)
		{
			JointMotor motor = PoleJoint.motor;
			motor.targetVelocity = Mathf.Lerp(MinTargetVelocity, MaxTargetVelocity, val);
			PoleJoint.motor = motor;
			PoleJoint.useMotor = true;
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (hasShot)
		{
			return;
		}
		if (SpawnFakeArrowOnShoot && GolfBallController != null && GolfBallController.arrow != null)
		{
			GameObject obj = UnityEngine.Object.Instantiate(GolfBallController.arrow.gameObject, GolfBallController.arrow.transform.position, GolfBallController.arrow.transform.rotation);
			UnityEngine.Object.Destroy(obj.GetComponent<ShootArrow>());
			fakeArrow = obj;
		}
		hasShot = true;
		if (GolfBallController != null)
		{
			GolfBallController.StopAiming();
			GolfBallController.enabled = false;
			GolfBallController.isShooting = true;
		}
		if (rigid != null)
		{
			rigid.constraints = (RigidbodyConstraints)96;
			rigid.angularVelocity = Vector3.zero;
			rigid.velocity = Vector3.zero;
		}
		SetJointMotorTargetVel(1f);
		if (PoleJoint != null)
		{
			JointLimits limits = PoleJoint.limits;
			limits.max = 95f;
			PoleJoint.limits = limits;
		}
	}

	protected override void FixedUpdate()
	{
		if (PoleAnchor != null && PoleAnchor.gameObject.activeSelf && base.transform.up.y > ReleasePoleThreshold && HandJoint != null)
		{
			UnityEngine.Object.Destroy(HandJoint);
			if (PoleJoint != null)
			{
				UnityEngine.Object.Destroy(PoleJoint);
			}
			if (ReleaseClip != null)
			{
				ReleaseClip.Play(null, base.transform.position, 1f, 1f);
			}
		}
		if (fakeArrow != null)
		{
			fakeArrow.transform.position = base.transform.position;
			fakeArrow.transform.up = base.transform.forward;
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (PoleJoint == null || PoleAnchor == null || PoleAnchor.gameObject.activeSelf || other == null || other.gameObject.layer != LayerMask.NameToLayer("Ground"))
		{
			return;
		}
		if (rigid != null)
		{
			rigid.velocity = Vector3.zero;
			rigid.angularVelocity = Vector3.zero;
		}
		if (PoleVaulter != null && PoleVaulter.behaviours != null)
		{
			for (int i = 0; i < PoleVaulter.behaviours.Length; i++)
			{
				BehaviourPuppet behaviourPuppet = PoleVaulter.behaviours[i] as BehaviourPuppet;
				if (behaviourPuppet != null)
				{
					behaviourPuppet.SetState(BehaviourPuppet.State.Unpinned);
					behaviourPuppet.canGetUp = false;
				}
			}
		}
		PoleJoint.useLimits = false;
		PoleJoint.useMotor = false;
		PoleAnchor.transform.position = base.transform.TransformPoint(new Vector3(0f, -2f, 0f));
		PoleAnchor.gameObject.SetActive(true);
		if (oneshotsOnVault != null && oneshotsOnVault.Count >= 1)
		{
			foreach (OneshotTime item in oneshotsOnVault)
			{
				if (item.sfx != null)
				{
					item.sfx.PlayDelayed(base.transform.position, null, item.delay, 1f, 1f);
				}
			}
		}
		if (IgnoreBoundsAfterAnchored)
		{
			int layer = LayerMask.NameToLayer("Gate (OW High)");
			base.gameObject.layer = layer;
			for (int j = 0; j < base.transform.childCount; j++)
			{
				base.transform.GetChild(j).gameObject.layer = layer;
			}
		}
		StartCoroutine(ReenablePuppet());
	}

	private IEnumerator ReenablePuppet()
	{
		yield return new WaitForSeconds(1f);
		if (PoleVaulter != null && PoleVaulter.behaviours != null)
		{
			for (int i = 0; i < PoleVaulter.behaviours.Length; i++)
			{
				BehaviourPuppet behaviourPuppet = PoleVaulter.behaviours[i] as BehaviourPuppet;
				if (behaviourPuppet != null)
				{
					behaviourPuppet.canGetUp = true;
				}
			}
		}
	}
}
