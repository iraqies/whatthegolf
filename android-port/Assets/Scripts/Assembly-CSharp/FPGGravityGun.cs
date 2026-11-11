using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class FPGGravityGun : MonoBehaviour
{
	public GolfBallController Controller;

	public List<LineRenderer> Trail;

	public List<ParticleSystem> Particles;

	public Animator Animator;

	public float GravityGunRotateSpeed = 10f;

	public float LineWidth = 1f;

	public float PulseSpeed = 1f;

	public int MaxHeldObjectsSize = 3;

	public float Range = 50f;

	public float BeamSize = 10f;

	public float SuckForce = 10f;

	public LayerMask AffectedLayers;

	public float ShootForce;

	public float CaptureDistance = 5f;

	private List<SpringJoint> joints = new List<SpringJoint>();

	private bool isSucking;

	private float currentSizeSum;

	private void Start()
	{
		joints = new List<SpringJoint>();
		if (Controller != null)
		{
			Controller.OnShoot += OnShoot;
			Controller.OnAimStart += OnAimStart;
			Controller.OnAimUpdate += OnAimUpdate;
			Controller.OnCancel += OnCancel;
		}
	}

	private void OnCancel()
	{
	}

	private void OnAimUpdate(Vector3 boost, bool onlyAim)
	{
		if (onlyAim || (currentSizeSum >= (float)MaxHeldObjectsSize && joints != null && joints.Count != 0) || Camera.main == null)
		{
			return;
		}
		if (!Physics.SphereCast(Camera.main.transform.position, BeamSize, Camera.main.transform.forward, out var hitInfo, Range, AffectedLayers) || !(hitInfo.rigidbody != null) || hitInfo.rigidbody.isKinematic)
		{
			return;
		}
		Rigidbody rb = hitInfo.rigidbody.transform.root.GetComponentInChildren<Rigidbody>();
		if (rb == null || (joints != null && joints.Any((SpringJoint j) => j != null && j.connectedBody == rb)))
		{
			return;
		}
		float num = TweenFunctions.EaseOut(1f - hitInfo.distance / Range);
		Vector3 normalized = (base.transform.position - rb.transform.position).normalized;
		rb.AddForce(normalized * num * SuckForce, ForceMode.Acceleration);
		if (hitInfo.distance <= CaptureDistance)
		{
			rb.useGravity = false;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			SpringJoint springJoint = base.gameObject.AddComponent<SpringJoint>();
			springJoint.connectedBody = rb;
			springJoint.spring = 300f;
			springJoint.damper = 10f;
			springJoint.anchor = new Vector3(0f, 0f, 2.5f);
			springJoint.autoConfigureConnectedAnchor = false;
			springJoint.connectedAnchor = Vector3.zero;
			if (joints != null)
			{
				joints.Add(springJoint);
			}
			currentSizeSum += 1f;
		}
	}

	private void OnAimStart()
	{
		isSucking = true;
		currentSizeSum = 0f;
	}

	private void OnShoot(Vector3 obj)
	{
		if (joints != null)
		{
			foreach (SpringJoint joint in joints)
			{
				if (joint != null)
				{
					if (joint.connectedBody != null)
					{
						joint.connectedBody.useGravity = true;
						if (Camera.main != null)
						{
							joint.connectedBody.velocity = Camera.main.transform.forward * ShootForce;
						}
					}
					Object.Destroy(joint);
				}
			}
			joints.Clear();
		}
		isSucking = false;
	}

	private void Update()
	{
		if (isSucking)
		{
			if (Animator != null)
			{
				Animator.SetBool("IsOn", true);
			}
			if (Trail != null)
			{
				foreach (LineRenderer item in Trail)
				{
					if (item != null)
					{
						item.gameObject.SetActive(true);
						float num = Mathf.PingPong(Time.time * PulseSpeed, 1f);
						item.widthCurve = new AnimationCurve(new Keyframe(0f, num), new Keyframe(1f, 1f - num));
						item.widthMultiplier = LineWidth;
					}
				}
			}
			if (Particles != null)
			{
				foreach (ParticleSystem particle in Particles)
				{
					if (particle != null && !particle.gameObject.activeSelf)
					{
						particle.gameObject.SetActive(true);
						particle.Clear();
					}
				}
			}
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			base.transform.localRotation = Quaternion.Euler(eulerAngles.x, eulerAngles.y, eulerAngles.z + Time.deltaTime * GravityGunRotateSpeed);
			return;
		}
		if (Animator != null)
		{
			Animator.SetBool("IsOn", false);
		}
		if (Trail != null)
		{
			foreach (LineRenderer item2 in Trail)
			{
				if (item2 != null)
				{
					item2.gameObject.SetActive(false);
				}
			}
		}
		if (Particles == null)
		{
			return;
		}
		foreach (ParticleSystem particle2 in Particles)
		{
			if (particle2 != null && particle2.gameObject.activeSelf)
			{
				particle2.gameObject.SetActive(false);
			}
		}
	}
}
